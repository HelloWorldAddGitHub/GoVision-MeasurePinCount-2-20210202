using System;

namespace GoVision
{
    public enum UserMode { Operator, Manager }

    public class CameraName
    {
        public static string MainCamera = "MainCam";
        public static string SideCameraA = "HE012A1GMA";
        public static string SideCameraB = "HE012A1GMB";
    }

    public struct VisionStepName
    {
        public const string MainPos = "MainPos";//点碳定位
        public const string MainMea = "MainMea";//测量取料
        public const string PinMea = "PinMea";//测量针脚
        public const string SideMeaA = "SideMeaA";//侧相机测量
        public const string SideMeaB = "SideMeaB";//侧相机测量
    }

    public struct DataColumns
    {
        public const string Index = "index";
        public const string Diameter = "diameter";
        public const string DisLeft = "disLeft";
        public const string DisRight = "disRight";
        public const string DisTop = "disTop";
    }

    public class Log
    {
        public static Action<string> Show;
    }

    public class Data
    {
        public static Action<int, double[], double[], double[], double[]> Show;
    }
}