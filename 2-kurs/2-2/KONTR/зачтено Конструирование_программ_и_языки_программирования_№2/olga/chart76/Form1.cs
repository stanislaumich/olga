using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace chart76
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            if (radioButton2.Checked)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
            chart1.Series[0].Points[0].YValues[0] = Convert.ToDouble(textBox1.Text);
            chart1.Series[0].Points[1].YValues[0] = Convert.ToDouble(textBox2.Text);
            chart1.Series[0].Points[2].YValues[0] = Convert.ToDouble(textBox3.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("D:/image.bmp", ChartImageFormat.Bmp);
        }
    }
}
