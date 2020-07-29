namespace Practice
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.createChartButton = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.functionValue = new System.Windows.Forms.TextBox();
            this.cons = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.DimGray;
            this.chart.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 30;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(-1, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.LegendText = "Функция";
            series1.Name = "Series1";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Legend = "Legend1";
            series2.LegendText = "Экстремум";
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.MarkerColor = System.Drawing.Color.Honeydew;
            series2.MarkerSize = 12;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1058, 584);
            this.chart.TabIndex = 0;
            this.chart.Text = "График функции";
            // 
            // createChartButton
            // 
            this.createChartButton.Location = new System.Drawing.Point(-1, 590);
            this.createChartButton.Name = "createChartButton";
            this.createChartButton.Size = new System.Drawing.Size(120, 52);
            this.createChartButton.TabIndex = 1;
            this.createChartButton.Text = "Создать график";
            this.createChartButton.UseVisualStyleBackColor = true;
            this.createChartButton.Click += new System.EventHandler(this.createChartButton_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(125, 590);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 52);
            this.clear.TabIndex = 4;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // functionValue
            // 
            this.functionValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.functionValue.Location = new System.Drawing.Point(236, 590);
            this.functionValue.Multiline = true;
            this.functionValue.Name = "functionValue";
            this.functionValue.Size = new System.Drawing.Size(100, 48);
            this.functionValue.TabIndex = 11;
            // 
            // cons
            // 
            this.cons.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cons.Location = new System.Drawing.Point(636, 591);
            this.cons.Multiline = true;
            this.cons.Name = "cons";
            this.cons.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cons.Size = new System.Drawing.Size(421, 125);
            this.cons.TabIndex = 12;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1131, 728);
            this.Controls.Add(this.cons);
            this.Controls.Add(this.functionValue);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.createChartButton);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button createChartButton;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox functionValue;
        private System.Windows.Forms.TextBox cons;
    }
}

