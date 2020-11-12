namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.port = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.WindowL = new System.Windows.Forms.Label();
			this.Prop = new System.Windows.Forms.Label();
			this.HumL = new System.Windows.Forms.Label();
			this.He = new System.Windows.Forms.Label();
			this.Ac = new System.Windows.Forms.Label();
			this.LightLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LightText = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.resetb = new System.Windows.Forms.Button();
			this.SetB = new System.Windows.Forms.Button();
			this.hum_text = new System.Windows.Forms.TextBox();
			this.temp_text = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ProB = new System.Windows.Forms.Button();
			this.HumB = new System.Windows.Forms.Button();
			this.WindowB = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.label4 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(10, 10);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(66, 18);
			this.button1.TabIndex = 0;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(124, 8);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 21);
			this.textBox2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "IP :";
			// 
			// port
			// 
			this.port.AutoSize = true;
			this.port.Location = new System.Drawing.Point(228, 13);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(35, 12);
			this.port.TabIndex = 7;
			this.port.Text = "Port :";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(272, 8);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(88, 21);
			this.textBox3.TabIndex = 6;
			// 
			// chart1
			// 
			chartArea1.AxisY.Interval = 10D;
			chartArea1.AxisY.Maximum = 50D;
			chartArea1.AxisY.Minimum = -50D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(10, 33);
			this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(128, 265);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea2.AxisY.Interval = 10D;
			chartArea2.AxisY.Maximum = 100D;
			chartArea2.AxisY.Minimum = 0D;
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			this.chart2.Location = new System.Drawing.Point(144, 33);
			this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.Name = "Series1";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(119, 265);
			this.chart2.TabIndex = 9;
			this.chart2.Text = "chart2";
			// 
			// chart3
			// 
			chartArea3.AxisY.Interval = 100D;
			chartArea3.AxisY.Maximum = 1023D;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			this.chart3.Location = new System.Drawing.Point(269, 33);
			this.chart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chart3.Name = "chart3";
			this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
			series3.ChartArea = "ChartArea1";
			series3.Name = "Series1";
			this.chart3.Series.Add(series3);
			this.chart3.Size = new System.Drawing.Size(117, 265);
			this.chart3.TabIndex = 10;
			this.chart3.Text = "chart3";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.WindowL);
			this.groupBox1.Controls.Add(this.Prop);
			this.groupBox1.Controls.Add(this.HumL);
			this.groupBox1.Controls.Add(this.He);
			this.groupBox1.Controls.Add(this.Ac);
			this.groupBox1.Controls.Add(this.LightLabel);
			this.groupBox1.Location = new System.Drawing.Point(394, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 67);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "전체상태";
			// 
			// WindowL
			// 
			this.WindowL.AutoSize = true;
			this.WindowL.Location = new System.Drawing.Point(7, 45);
			this.WindowL.Name = "WindowL";
			this.WindowL.Size = new System.Drawing.Size(65, 12);
			this.WindowL.TabIndex = 5;
			this.WindowL.Text = "창문 : 닫힘";
			// 
			// Prop
			// 
			this.Prop.AutoSize = true;
			this.Prop.Location = new System.Drawing.Point(183, 20);
			this.Prop.Name = "Prop";
			this.Prop.Size = new System.Drawing.Size(68, 12);
			this.Prop.TabIndex = 4;
			this.Prop.Text = "선풍기 : Off";
			// 
			// HumL
			// 
			this.HumL.AutoSize = true;
			this.HumL.Location = new System.Drawing.Point(84, 20);
			this.HumL.Name = "HumL";
			this.HumL.Size = new System.Drawing.Size(68, 12);
			this.HumL.TabIndex = 3;
			this.HumL.Text = "가습기 : Off";
			// 
			// He
			// 
			this.He.AutoSize = true;
			this.He.Location = new System.Drawing.Point(183, 45);
			this.He.Name = "He";
			this.He.Size = new System.Drawing.Size(68, 12);
			this.He.TabIndex = 2;
			this.He.Text = "난방기 : Off";
			// 
			// Ac
			// 
			this.Ac.AutoSize = true;
			this.Ac.Location = new System.Drawing.Point(84, 45);
			this.Ac.Name = "Ac";
			this.Ac.Size = new System.Drawing.Size(68, 12);
			this.Ac.TabIndex = 1;
			this.Ac.Text = "냉방기 : Off";
			// 
			// LightLabel
			// 
			this.LightLabel.AutoSize = true;
			this.LightLabel.Location = new System.Drawing.Point(7, 20);
			this.LightLabel.Name = "LightLabel";
			this.LightLabel.Size = new System.Drawing.Size(56, 12);
			this.LightLabel.TabIndex = 0;
			this.LightLabel.Text = "조명 : Off";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LightText);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.resetb);
			this.groupBox2.Controls.Add(this.SetB);
			this.groupBox2.Controls.Add(this.hum_text);
			this.groupBox2.Controls.Add(this.temp_text);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(394, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 91);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "자동제어";
			// 
			// LightText
			// 
			this.LightText.Location = new System.Drawing.Point(202, 58);
			this.LightText.Name = "LightText";
			this.LightText.Size = new System.Drawing.Size(63, 21);
			this.LightText.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(159, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 12);
			this.label10.TabIndex = 6;
			this.label10.Text = "조도 :";
			// 
			// resetb
			// 
			this.resetb.Location = new System.Drawing.Point(90, 52);
			this.resetb.Name = "resetb";
			this.resetb.Size = new System.Drawing.Size(63, 30);
			this.resetb.TabIndex = 5;
			this.resetb.Text = "적용";
			this.resetb.UseVisualStyleBackColor = true;
			this.resetb.Click += new System.EventHandler(this.resetb_Click);
			// 
			// SetB
			// 
			this.SetB.Location = new System.Drawing.Point(11, 52);
			this.SetB.Name = "SetB";
			this.SetB.Size = new System.Drawing.Size(63, 30);
			this.SetB.TabIndex = 4;
			this.SetB.Text = "On";
			this.SetB.UseVisualStyleBackColor = true;
			this.SetB.Click += new System.EventHandler(this.SetB_Click);
			// 
			// hum_text
			// 
			this.hum_text.Location = new System.Drawing.Point(202, 25);
			this.hum_text.Name = "hum_text";
			this.hum_text.Size = new System.Drawing.Size(63, 21);
			this.hum_text.TabIndex = 3;
			// 
			// temp_text
			// 
			this.temp_text.Location = new System.Drawing.Point(72, 25);
			this.temp_text.Name = "temp_text";
			this.temp_text.Size = new System.Drawing.Size(61, 21);
			this.temp_text.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "습도(%) :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "온도(℃) :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.ProB);
			this.groupBox3.Controls.Add(this.HumB);
			this.groupBox3.Controls.Add(this.WindowB);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.hScrollBar3);
			this.groupBox3.Controls.Add(this.hScrollBar2);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.hScrollBar1);
			this.groupBox3.Location = new System.Drawing.Point(394, 184);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 114);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "수동제어";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(203, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 12);
			this.label9.TabIndex = 11;
			this.label9.Text = "선풍기";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(108, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 12);
			this.label8.TabIndex = 10;
			this.label8.Text = "가습기";
			// 
			// ProB
			// 
			this.ProB.Location = new System.Drawing.Point(202, 76);
			this.ProB.Name = "ProB";
			this.ProB.Size = new System.Drawing.Size(80, 23);
			this.ProB.TabIndex = 9;
			this.ProB.Text = "꺼짐";
			this.ProB.UseVisualStyleBackColor = true;
			this.ProB.Click += new System.EventHandler(this.ProB_Click);
			// 
			// HumB
			// 
			this.HumB.Location = new System.Drawing.Point(110, 76);
			this.HumB.Name = "HumB";
			this.HumB.Size = new System.Drawing.Size(80, 23);
			this.HumB.TabIndex = 8;
			this.HumB.Text = "꺼짐";
			this.HumB.UseVisualStyleBackColor = true;
			this.HumB.Click += new System.EventHandler(this.HumB_Click);
			// 
			// WindowB
			// 
			this.WindowB.Location = new System.Drawing.Point(11, 76);
			this.WindowB.Name = "WindowB";
			this.WindowB.Size = new System.Drawing.Size(80, 23);
			this.WindowB.TabIndex = 7;
			this.WindowB.Text = "닫힘";
			this.WindowB.UseVisualStyleBackColor = true;
			this.WindowB.Click += new System.EventHandler(this.WindowB_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 6;
			this.label7.Text = "창문";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(203, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "난방기";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(108, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "냉방기";
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(202, 32);
			this.hScrollBar3.Maximum = 1032;
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(80, 17);
			this.hScrollBar3.TabIndex = 3;
			this.hScrollBar3.MouseCaptureChanged += new System.EventHandler(this.hScrollBar3_MouseCaptureChanged);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(110, 32);
			this.hScrollBar2.Maximum = 1032;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(80, 17);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.MouseCaptureChanged += new System.EventHandler(this.hScrollBar2_MouseCaptureChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "조명";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(9, 32);
			this.hScrollBar1.Maximum = 1032;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.MouseCaptureChanged += new System.EventHandler(this.hScrollBar1_MouseCaptureChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 306);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.chart3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.port);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label LightLabel;
		private System.Windows.Forms.Label WindowL;
		private System.Windows.Forms.Label Prop;
		private System.Windows.Forms.Label HumL;
		private System.Windows.Forms.Label He;
		private System.Windows.Forms.Label Ac;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button SetB;
		private System.Windows.Forms.TextBox hum_text;
		private System.Windows.Forms.TextBox temp_text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.Button WindowB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button ProB;
		private System.Windows.Forms.Button HumB;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox LightText;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button resetb;
	}
}

