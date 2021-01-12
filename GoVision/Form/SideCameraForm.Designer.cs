namespace GoVision
{
    partial class SideCameraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudExposure = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnStopGrab = new System.Windows.Forms.Button();
            this.btnReadImage = new System.Windows.Forms.Button();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.btnGrabOne = new System.Windows.Forms.Button();
            this.btnContinuGrab = new System.Windows.Forms.Button();
            this.nudSigma = new System.Windows.Forms.NumericUpDown();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrawMeaScreen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCalib = new System.Windows.Forms.DataGridView();
            this.txtCalibX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCalibY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCalibCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCalibRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalib = new System.Windows.Forms.Button();
            this.btnDrawCalib = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDrawMeaNeedle = new System.Windows.Forms.Button();
            this.visionControl1 = new GoVision.VisionControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalib)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudExposure);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbProcess);
            this.groupBox1.Controls.Add(this.btnSaveImage);
            this.groupBox1.Controls.Add(this.btnStopGrab);
            this.groupBox1.Controls.Add(this.btnReadImage);
            this.groupBox1.Controls.Add(this.btnProcessImage);
            this.groupBox1.Controls.Add(this.btnGrabOne);
            this.groupBox1.Controls.Add(this.btnContinuGrab);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(719, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(267, 462);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "曝光时间";
            // 
            // nudExposure
            // 
            this.nudExposure.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudExposure.Location = new System.Drawing.Point(136, 234);
            this.nudExposure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudExposure.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudExposure.Name = "nudExposure";
            this.nudExposure.Size = new System.Drawing.Size(120, 30);
            this.nudExposure.TabIndex = 9;
            this.nudExposure.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudExposure.ValueChanged += new System.EventHandler(this.nudExposure_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "流程";
            // 
            // cmbProcess
            // 
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Location = new System.Drawing.Point(69, 24);
            this.cmbProcess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(185, 28);
            this.cmbProcess.TabIndex = 2;
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(136, 177);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(120, 50);
            this.btnSaveImage.TabIndex = 0;
            this.btnSaveImage.Text = "保存图像";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnStopGrab
            // 
            this.btnStopGrab.Location = new System.Drawing.Point(8, 177);
            this.btnStopGrab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopGrab.Name = "btnStopGrab";
            this.btnStopGrab.Size = new System.Drawing.Size(120, 50);
            this.btnStopGrab.TabIndex = 3;
            this.btnStopGrab.Text = "停止采集";
            this.btnStopGrab.UseVisualStyleBackColor = true;
            this.btnStopGrab.Click += new System.EventHandler(this.btnStopGrab_Click);
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(136, 119);
            this.btnReadImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(120, 50);
            this.btnReadImage.TabIndex = 0;
            this.btnReadImage.Text = "读取图像";
            this.btnReadImage.UseVisualStyleBackColor = true;
            this.btnReadImage.Click += new System.EventHandler(this.btnReadImage_Click);
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(136, 61);
            this.btnProcessImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(120, 50);
            this.btnProcessImage.TabIndex = 0;
            this.btnProcessImage.Text = "处理图像";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // btnGrabOne
            // 
            this.btnGrabOne.Location = new System.Drawing.Point(8, 61);
            this.btnGrabOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabOne.Name = "btnGrabOne";
            this.btnGrabOne.Size = new System.Drawing.Size(120, 50);
            this.btnGrabOne.TabIndex = 3;
            this.btnGrabOne.Text = "单帧采集";
            this.btnGrabOne.UseVisualStyleBackColor = true;
            this.btnGrabOne.Click += new System.EventHandler(this.btnGrabOne_Click);
            // 
            // btnContinuGrab
            // 
            this.btnContinuGrab.Location = new System.Drawing.Point(8, 119);
            this.btnContinuGrab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContinuGrab.Name = "btnContinuGrab";
            this.btnContinuGrab.Size = new System.Drawing.Size(120, 50);
            this.btnContinuGrab.TabIndex = 3;
            this.btnContinuGrab.Text = "连续采集";
            this.btnContinuGrab.UseVisualStyleBackColor = true;
            this.btnContinuGrab.Click += new System.EventHandler(this.btnContinuGrab_Click);
            // 
            // nudSigma
            // 
            this.nudSigma.DecimalPlaces = 2;
            this.nudSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSigma.Location = new System.Drawing.Point(148, 151);
            this.nudSigma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudSigma.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.nudSigma.Name = "nudSigma";
            this.nudSigma.Size = new System.Drawing.Size(104, 30);
            this.nudSigma.TabIndex = 4;
            this.nudSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSigma.Visible = false;
            this.nudSigma.ValueChanged += new System.EventHandler(this.nudSigma_ValueChanged);
            // 
            // nudThreshold
            // 
            this.nudThreshold.DecimalPlaces = 1;
            this.nudThreshold.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudThreshold.Location = new System.Drawing.Point(113, 115);
            this.nudThreshold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(104, 30);
            this.nudThreshold.TabIndex = 4;
            this.nudThreshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudThreshold.ValueChanged += new System.EventHandler(this.nudThreshold_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "平滑";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "边缘幅度";
            // 
            // btnDrawMeaScreen
            // 
            this.btnDrawMeaScreen.Location = new System.Drawing.Point(7, 29);
            this.btnDrawMeaScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDrawMeaScreen.Name = "btnDrawMeaScreen";
            this.btnDrawMeaScreen.Size = new System.Drawing.Size(316, 35);
            this.btnDrawMeaScreen.TabIndex = 0;
            this.btnDrawMeaScreen.Text = "绘制玻璃测量矩形";
            this.btnDrawMeaScreen.UseVisualStyleBackColor = true;
            this.btnDrawMeaScreen.Click += new System.EventHandler(this.btnDrawMeaRect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(991, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(340, 462);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCalib);
            this.groupBox4.Controls.Add(this.btnCalib);
            this.groupBox4.Controls.Add(this.btnDrawCalib);
            this.groupBox4.Location = new System.Drawing.Point(5, 166);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(329, 181);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标定";
            // 
            // dgvCalib
            // 
            this.dgvCalib.AllowUserToAddRows = false;
            this.dgvCalib.AllowUserToDeleteRows = false;
            this.dgvCalib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCalibX,
            this.txtCalibY,
            this.txtCalibCol,
            this.txtCalibRow});
            this.dgvCalib.Location = new System.Drawing.Point(7, 21);
            this.dgvCalib.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCalib.Name = "dgvCalib";
            this.dgvCalib.RowHeadersVisible = false;
            this.dgvCalib.Size = new System.Drawing.Size(316, 112);
            this.dgvCalib.TabIndex = 10;
            // 
            // txtCalibX
            // 
            this.txtCalibX.HeaderText = "X";
            this.txtCalibX.Name = "txtCalibX";
            this.txtCalibX.Width = 60;
            // 
            // txtCalibY
            // 
            this.txtCalibY.HeaderText = "Y";
            this.txtCalibY.Name = "txtCalibY";
            this.txtCalibY.Width = 60;
            // 
            // txtCalibCol
            // 
            this.txtCalibCol.HeaderText = "Column";
            this.txtCalibCol.Name = "txtCalibCol";
            this.txtCalibCol.Width = 60;
            // 
            // txtCalibRow
            // 
            this.txtCalibRow.HeaderText = "Row";
            this.txtCalibRow.Name = "txtCalibRow";
            this.txtCalibRow.Width = 60;
            // 
            // btnCalib
            // 
            this.btnCalib.Location = new System.Drawing.Point(112, 138);
            this.btnCalib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(93, 38);
            this.btnCalib.TabIndex = 2;
            this.btnCalib.Text = "标定";
            this.btnCalib.UseVisualStyleBackColor = true;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // btnDrawCalib
            // 
            this.btnDrawCalib.Location = new System.Drawing.Point(5, 138);
            this.btnDrawCalib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrawCalib.Name = "btnDrawCalib";
            this.btnDrawCalib.Size = new System.Drawing.Size(93, 38);
            this.btnDrawCalib.TabIndex = 2;
            this.btnDrawCalib.Text = "测量";
            this.btnDrawCalib.UseVisualStyleBackColor = true;
            this.btnDrawCalib.Click += new System.EventHandler(this.btnDrawCalib_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDrawMeaScreen);
            this.groupBox3.Controls.Add(this.btnDrawMeaNeedle);
            this.groupBox3.Controls.Add(this.nudThreshold);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nudSigma);
            this.groupBox3.Location = new System.Drawing.Point(5, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(329, 151);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测量";
            // 
            // btnDrawMeaNeedle
            // 
            this.btnDrawMeaNeedle.Location = new System.Drawing.Point(7, 70);
            this.btnDrawMeaNeedle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDrawMeaNeedle.Name = "btnDrawMeaNeedle";
            this.btnDrawMeaNeedle.Size = new System.Drawing.Size(316, 35);
            this.btnDrawMeaNeedle.TabIndex = 0;
            this.btnDrawMeaNeedle.Text = "绘制针头测量矩形";
            this.btnDrawMeaNeedle.UseVisualStyleBackColor = true;
            this.btnDrawMeaNeedle.Click += new System.EventHandler(this.btnDrawMeaNeedle_Click);
            // 
            // visionControl1
            // 
            this.visionControl1.BackColor = System.Drawing.SystemColors.Highlight;
            this.visionControl1.Location = new System.Drawing.Point(0, 0);
            this.visionControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.visionControl1.MouseMode = GoVision.VisionControl.WindowMouseMode.Move;
            this.visionControl1.Name = "visionControl1";
            this.visionControl1.Size = new System.Drawing.Size(711, 462);
            this.visionControl1.TabIndex = 0;
            this.visionControl1.TabStop = false;
            // 
            // SideCameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.visionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SideCameraForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SideCameraForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalib)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisionControl visionControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnStopGrab;
        private System.Windows.Forms.Button btnReadImage;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.Button btnGrabOne;
        private System.Windows.Forms.Button btnContinuGrab;
        private System.Windows.Forms.Button btnDrawMeaScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSigma;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.NumericUpDown nudExposure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDrawMeaNeedle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalib;
        private System.Windows.Forms.Button btnDrawCalib;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCalib;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCalibX;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCalibY;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCalibCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCalibRow;
    }
}