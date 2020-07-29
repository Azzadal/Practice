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

        //несколько функций для примера
        public float func(float x)
        {
            //return (float)(4 - Math.Exp(x) - 2 * Math.Pow(x, 2));
            //return (float)(Math.Sin(Math.PI * x / 180) - 1 / x);
            //return (float)Math.Sin(x);
            //return (float)Math.Cos(x);
            //return (float)(Math.Pow(x, 2) + 4 * x - 3);
            //return (float)Math.Pow(x, 3) - 2 * x + 7;
            return (float)Math.Pow(x, 2);
            //return (float)x;
            //return (float)Math.Tanh(x);
        }
        public float ExtremumSearch(float x0, float x1, double eps)
        {
            float left = x0, right = x1, x, f;
            int iter = 0;
            cons.Text += "x0= " + x0 + " x1= " + x1 + Environment.NewLine;

            do
            {
                x = (left + right) / 2;
                f = func(x);
                if (f > 0) right = x;
                else left = x;
                iter++;
            } while (Math.Abs(f) > eps && iter < 10000);
            for (float i = -10; i < 30;)
            {
                chart.Series[0].Points.AddXY(i, func(i));
                i += 0.1f;
            }
            chart.Series[1].Points.AddXY(x, func(x));

            cons.Text += iter + " iterations " + func(x);

            return func(x);
        }
        private void createChartButton_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            functionValue.Text += ExtremumSearch(0.5f, 5.1f, 0.001).ToString();
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

        private void clear_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
        }
    }
}
