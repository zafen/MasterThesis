namespace MasterThesis
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxValue1 = new System.Windows.Forms.TextBox();
            this.txtBoxValue2 = new System.Windows.Forms.TextBox();
            this.txtBoxValue4 = new System.Windows.Forms.TextBox();
            this.txtBoxValue3 = new System.Windows.Forms.TextBox();
            this.txtBoxValue5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDataPoints = new System.Windows.Forms.TextBox();
            this.tbnCalculate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxFutureValues = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polynom";
            // 
            // txtBoxValue1
            // 
            this.txtBoxValue1.Location = new System.Drawing.Point(39, 69);
            this.txtBoxValue1.Name = "txtBoxValue1";
            this.txtBoxValue1.Size = new System.Drawing.Size(37, 20);
            this.txtBoxValue1.TabIndex = 1;
            // 
            // txtBoxValue2
            // 
            this.txtBoxValue2.Location = new System.Drawing.Point(101, 69);
            this.txtBoxValue2.Name = "txtBoxValue2";
            this.txtBoxValue2.Size = new System.Drawing.Size(37, 20);
            this.txtBoxValue2.TabIndex = 2;
            // 
            // txtBoxValue4
            // 
            this.txtBoxValue4.Location = new System.Drawing.Point(242, 69);
            this.txtBoxValue4.Name = "txtBoxValue4";
            this.txtBoxValue4.Size = new System.Drawing.Size(37, 20);
            this.txtBoxValue4.TabIndex = 3;
            // 
            // txtBoxValue3
            // 
            this.txtBoxValue3.Location = new System.Drawing.Point(165, 69);
            this.txtBoxValue3.Name = "txtBoxValue3";
            this.txtBoxValue3.Size = new System.Drawing.Size(37, 20);
            this.txtBoxValue3.TabIndex = 4;
            // 
            // txtBoxValue5
            // 
            this.txtBoxValue5.Location = new System.Drawing.Point(319, 69);
            this.txtBoxValue5.Name = "txtBoxValue5";
            this.txtBoxValue5.Size = new System.Drawing.Size(37, 20);
            this.txtBoxValue5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "x^4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "x^3 +";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "x^2 +";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x +";
            // 
            // txtBoxDataPoints
            // 
            this.txtBoxDataPoints.Location = new System.Drawing.Point(39, 114);
            this.txtBoxDataPoints.Name = "txtBoxDataPoints";
            this.txtBoxDataPoints.Size = new System.Drawing.Size(37, 20);
            this.txtBoxDataPoints.TabIndex = 11;
            // 
            // tbnCalculate
            // 
            this.tbnCalculate.Location = new System.Drawing.Point(283, 114);
            this.tbnCalculate.Name = "tbnCalculate";
            this.tbnCalculate.Size = new System.Drawing.Size(83, 48);
            this.tbnCalculate.TabIndex = 12;
            this.tbnCalculate.Text = "Calculate";
            this.tbnCalculate.UseVisualStyleBackColor = true;
            this.tbnCalculate.Click += new System.EventHandler(this.tbnCalculate_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(431, 42);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(459, 565);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of data points";
            // 
            // txtBoxFutureValues
            // 
            this.txtBoxFutureValues.Location = new System.Drawing.Point(39, 142);
            this.txtBoxFutureValues.Name = "txtBoxFutureValues";
            this.txtBoxFutureValues.Size = new System.Drawing.Size(37, 20);
            this.txtBoxFutureValues.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of future values";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 699);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxFutureValues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbnCalculate);
            this.Controls.Add(this.txtBoxDataPoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxValue5);
            this.Controls.Add(this.txtBoxValue3);
            this.Controls.Add(this.txtBoxValue4);
            this.Controls.Add(this.txtBoxValue2);
            this.Controls.Add(this.txtBoxValue1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxValue1;
        private System.Windows.Forms.TextBox txtBoxValue2;
        private System.Windows.Forms.TextBox txtBoxValue4;
        private System.Windows.Forms.TextBox txtBoxValue3;
        private System.Windows.Forms.TextBox txtBoxValue5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDataPoints;
        private System.Windows.Forms.Button tbnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxFutureValues;
        private System.Windows.Forms.Label label8;
    }
}