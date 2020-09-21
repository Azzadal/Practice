using System;
using System.Windows.Forms;

namespace Practice
{
    public partial class App : Form
    {
        float startInterval;
        float endInterval;
        public App()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //математическая функция
        public float F(float x)
        {
            int index = comboBox1.SelectedIndex;
            if (index == 1) return (float)Math.Sin(2 * x);
            if (index == 2) return (float)(4 * Math.Pow(x, 2) - 8 * x + 3);
            return (float)Math.Pow(x, 3);
        }

        Function function = new Function();

        //построение графика
        private void CreateChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                startInterval = float.Parse(textBox1.Text);
                endInterval = float.Parse(textBox2.Text);
                functionValue.Text = string.Empty;
                chart.Series[0].Points.Clear();
                chart.Series[1].Points.Clear();
                functionValue.Text += function.ExtremumSearch(startInterval, endInterval, 0.001, chart, cons, F).ToString();
                functionValue.Text += Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            chart.Series[1].Points.Clear();
        }
    }
}
