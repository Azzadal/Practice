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

        public double f(double x)
        {
            //return 4 - Math.Exp(x) - 2 * Math.Pow(x, 2);
            return Math.Pow(x, 3);
        }
        public double FindKoren(double a, double b)
        {
            const double sigma = 0.001;
            double xm, c, x;
            int k = -20;
            x = (a + b) / 2;
            while (Math.Abs(f(x)) > sigma)
            {
                if (f(x) > 0) b = x;
                else a = x;
                x = (a + b) / 2;

                k++;
                
               // chart1.Series[0].Points.Add(f(x));
                
                

            }



            chart1.Series[1].Points.Add(f(x));

            return x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            textBox1.Text = FindKoren(0, 3).ToString();
            

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

            for (int i = -10; i < 10; i++)
            {
                chart1.Series[0].Points.Add(f(i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }
    }
}
