using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice
{
    class Function
    {
        //метод поиска экстремума
        public float ExtremumSearch(float x0, float x1, double eps, Chart chart, TextBox cons, Func<float, float> function)
        {
            cons.Text = string.Empty;
            float left = x0, right = x1, x, f;
            int iter = 0;
            cons.Text += "x0= " + x0 + " x1= " + x1 + Environment.NewLine;
            do
            {
                x = (left + right) / 2;
                f = function(x);
                if (f > 0) right = x;
                else left = x;
                iter++;
            } while (Math.Abs(f) > eps && iter < 10000);
            for (float i = -10; i < 30;)
            {
                chart.Series[0].Points.AddXY(i, function(i));
                i += 0.1f;
            }
            chart.Series[1].Points.AddXY(x, function(x));
            cons.Text += iter + " iterations " + function(x);
            cons.Text += Environment.NewLine;

            return function(x);
        }
    }
}
