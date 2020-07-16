using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float func(float x)
        {
            //return (float)(4 - Math.Exp(x) - 2 * Math.Pow(x, 2));
            //return (Math.Sin(Math.PI * x / 180) - 1 / x);
            //return (float)(Math.Sin(x));
            return (float)(Math.Pow(x, 2) + 4 * x - 3);
            //return (float)Math.Tanh(x);
        }
        public float FindKoren(float x0, float x1, double eps)
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
            for (int i = -10; i < 30;)
            {
                chart1.Series[0].Points.Add(func(i));
                i ++;
                cons.Text += i + Environment.NewLine;
            }
            chart1.Series[1].Points.Add(func(x));

            cons.Text += iter + " iterations " + func(x);

            return func(x);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            textBox1.Text += FindKoren(0.0f, 6.0f, 0.001).ToString();
            textBox1.Text += Environment.NewLine;

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(-20, 20);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }
    }
}
