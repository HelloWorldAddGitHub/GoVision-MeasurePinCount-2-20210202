using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoCommon;
using HalconDotNet;

namespace GoVision
{
    class ProcessPinMea : VisionBase
    {
        public HTuple Sigma = 1;
        public HTuple Threshold = 30;

        public ProcessPinMea(string strName) : base(strName)
        {
        }

        public override bool InitConfig()
        {
            LoadParam();
            return true;
        }

        public override bool ProcessImage(VisionControl ctl)
        {
            try
            {
                //清理数据
                foreach (var mea in MeasureMgr.GetInstance().MeasureList)
                {
                    mea.ClearResult();
                }

                ctl.clearObj();
                ctl.DisplayResults();

                //图像预处理
                HObject image;
                if (ProductMgr.GetInstance().Param.PlatformRegion != null)
                {
                    HOperatorSet.ReduceDomain(imgSrc, ProductMgr.GetInstance().Param.PlatformRegion, out image);
                }
                else
                {
                    image = imgSrc;
                }

                //查找模板
                HTuple row, column, angle, scale, score;
                bool result = HDevelopExport.FindScaleShapeModel(image, out row, out column, out angle, out scale, out score);

                //显示轮廓
                HDevelopExport.dev_display_shape_matching_results(ctl.GetHalconWindow(),
                    ProductMgr.GetInstance().Param.ModelID, "blue", row, column, angle, scale, scale, 0);

                if (!result)
                {
                    Log.Show("查找模板失败");
                    return false;
                }


                //***********************测量****************************
                MeasureMgr.GetInstance().MeasureAll(image, row, column, angle);

                //显示数据
                int hasCount = 0, meaCount = 0;
                for (int i = 0; i < MeasureMgr.GetInstance().MeasureList.Count; i++)
                {
                    var mea = MeasureMgr.GetInstance().MeasureList[i];

                    hasCount += mea.PinCount;
                    //meaCount += mea.CountOK + mea.CountAreaNG + mea.CountPosNG;
                    meaCount += mea.CountPinMea;

                    //发送的数据
                    //SendData.CountAreaNG += mea.CountAreaNG;
                    //SendData.CountPosNG += mea.CountPosNG;

                    //if (mea.DiameterMax.Length > 0)
                    //{
                    //    //显示和保存数据
                    //    Data.Show(i, mea.DiameterMax.ToDArr(), mea.DisLeft.ToDArr(), mea.DisRight.ToDArr(), mea.DisTop.ToDArr());
                    //}
                }

                string color = "green";
                if (hasCount == meaCount)
                {
                    color = "green";
                    SendData.PinCountOK = true;
                }
                else
                {
                    color = "red";
                    SendData.PinCountOK = false;
                }

                ctl.AddToStack(ProductMgr.GetInstance().Param.ModelContours);
                ctl.AddToStack(ProductMgr.GetInstance().Param.ModelOriginContours);
                //ctl.AddToStack(ProductMgr.GetInstance().Param.MarkContours);

                ctl.DisplayResults();

                for (int i = 0; i < MeasureMgr.GetInstance().MeasureList.Count; i++)
                {
                    var mea = MeasureMgr.GetInstance().MeasureList[i];

                    if (mea.PinCount == mea.CountPinMea)
                    {
                        HDevelopExport.disp_message(ctl.GetHalconWindow(), $"ROI{i}数量：{mea.PinCount}，测量数量：{mea.CountPinMea}", "window", 10 + 20 * i, -1, "green", "false");
                    }
                    else
                    {
                        HDevelopExport.disp_message(ctl.GetHalconWindow(), $"ROI{i}数量：{mea.PinCount}，测量数量：{mea.CountPinMea}", "window", 10 + 20 * i, -1, "red", "false");
                    }
                }

                HDevelopExport.disp_message(ctl.GetHalconWindow(), $"总数量：{hasCount}，测量数量：{meaCount}", "window", 10 + 20 * MeasureMgr.GetInstance().MeasureList.Count, -1, color, "false");

                //保存窗口图像和原图
                result = result && SendData.CountAreaNG == 0 && SendData.CountPosNG == 0;
                if (AutoForm._autoForm.Param.IsSaveImageAll)
                {
                    SaveImage(ctl.GetHalconWindow(), result);
                }
                else
                {
                    if (AutoForm._autoForm.Param.IsSaveImageNG && !result)
                    {
                        SaveImage(ctl.GetHalconWindow(), result);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override void UpdateVisionControl(VisionControl ctl)
        {
            ctl.LockDisplay();
            try
            {
                if (imgSrc != null && imgSrc.IsInitialized() && imgSrc.Key != IntPtr.Zero)
                {
                    if (imgSrc != null)
                    {
                        HOperatorSet.DispObj(imgSrc, ctl.GetHalconWindow());
                    }

                    while (ctl.getStack().Count > 0)
                    {
                        HOperatorSet.DispObj(ctl.getStack().Pop(), ctl.GetHalconWindow());
                    }

                    foreach (var mea in MeasureMgr.GetInstance().MeasureList)
                    {
                        HOperatorSet.SetColor(ctl.GetHalconWindow(), "blue");
                        HOperatorSet.DispObj(mea.LineEdge, ctl.GetHalconWindow());
                        HOperatorSet.SetColor(ctl.GetHalconWindow(), "green");
                        HOperatorSet.DispObj(mea.ContourOk, ctl.GetHalconWindow());
                        HOperatorSet.SetColor(ctl.GetHalconWindow(), "red");
                        HOperatorSet.DispObj(mea.ContourAreaNG, ctl.GetHalconWindow());
                        HOperatorSet.SetColor(ctl.GetHalconWindow(), "magenta");
                        HOperatorSet.DispObj(mea.ContourPosNG, ctl.GetHalconWindow());
                    }

                    HOperatorSet.SetColor(ctl.GetHalconWindow(), "blue");

                    //HTuple hv_Width, hv_Height;
                    //HOperatorSet.GetImageSize(m_image, out hv_Width, out hv_Height);
                    //HObject ht_CrossLineV, ht_CrossLineH;
                    //HOperatorSet.SetColor(ctl.GetHalconWindow(), "red");
                    //HOperatorSet.GenRegionLine(out ht_CrossLineV, 0, hv_Width / 2, hv_Height, hv_Width / 2);
                    //HOperatorSet.GenRegionLine(out ht_CrossLineH, hv_Height / 2, 0, hv_Height / 2, hv_Width);
                    //HOperatorSet.DispObj(ht_CrossLineV, ctl.GetHalconWindow());
                    //HOperatorSet.DispObj(ht_CrossLineH, ctl.GetHalconWindow());
                }
            }
            catch (HalconException HDevExpDefaultException1)
            {
                System.Diagnostics.Debug.WriteLine(HDevExpDefaultException1.ToString());
            }
            catch (AccessViolationException e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            finally
            {
                ctl.UnlockDisplay();
            }
        }

        /// <summary>
        /// 保存图像
        /// </summary>
        /// <param name="handle">窗口句柄</param>
        /// <param name="result">图像处理是否成功</param>
        private void SaveImage(HTuple handle, bool result)
        {
            try
            {
                Task.Run(() =>
                {
                    string imageName = $"{DateTime.Now:HHmmss}.tiff";

                    string res = result ? "OK" : "NG";
                    string pathSource = $@"{ProductMgr.GetInstance().ProductPath}Images\{DateTime.Now:yyyyMMdd}\{res}\Robot\Source\";
                    string pathWindow = $@"{ProductMgr.GetInstance().ProductPath}Images\{DateTime.Now:yyyyMMdd}\{res}\Robot\Window\";

                    if (!System.IO.Directory.Exists(pathSource))
                    {
                        System.IO.Directory.CreateDirectory(pathSource);
                    }

                    if (!System.IO.Directory.Exists(pathWindow))
                    {
                        System.IO.Directory.CreateDirectory(pathWindow);
                    }

                    string fileNameSource = $"{pathSource}{imageName}";
                    string fileNameWindow = $"{pathWindow}{imageName}";

                    HDevelopExport.WriteImage(imgSrc, fileNameSource);
                    HDevelopExport.DumpWindow(handle, fileNameWindow);
                });
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 设置曝光值
        /// </summary>
        /// <param name="nExp"></param>
        public override void SetExposureTime(int nExp)
        {
            try
            {
                m_Camera.SetGrabParam("ExposureTimeAbs", nExp);
                m_ExposureTime = nExp;

                if (!System.IO.Directory.Exists(m_strDir))
                {
                    System.IO.Directory.CreateDirectory(m_strDir);
                }

                IniTool.Set($@"{m_strDir}param.ini", "camera", "exposure", m_ExposureTime);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 加载参数
        /// </summary>
        /// <returns></returns>
        public override bool LoadParam()
        {
            string fileName = $@"{m_strDir}param.ini";

            if (!System.IO.Directory.Exists(m_strDir))
            {
                System.IO.Directory.CreateDirectory(m_strDir);
                SaveParam();
            }

            m_ExposureTime = IniTool.GetInt(fileName, "camera", "exposure", 0);

            return true;
        }

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <returns></returns>
        public override bool SaveParam()
        {
            string fileName = $@"{m_strDir}param.ini";

            if (!System.IO.Directory.Exists(m_strDir))
            {
                System.IO.Directory.CreateDirectory(m_strDir);
            }

            IniTool.Set(fileName, "camera", "exposure", m_ExposureTime);

            return true;
        }
    }
}
