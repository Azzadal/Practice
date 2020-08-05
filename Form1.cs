using System;
using System.Windows.Forms;

namespace Practice
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        //математическая функция
        public float F(float x)
        {
            return (float)Math.Pow(x, 3);
        }

        Function function = new Function();

        //построение графика
        private void CreateChartButton_Click(object sender, EventArgs e)
        {
            functionValue.Text = string.Empty;
            chart.Series[0].Points.Clear();
            functionValue.Text += function.ExtremumSearch(0.45f, 0.95f, 0.001, chart, cons, F).ToString();
            functionValue.Text += Environment.NewLine;

            chart.ChartAreas[0].AxisX.ScaleView.Zoom(-20, 20);
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        //очистка поля
        private void Clear_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
        }
    }
}
