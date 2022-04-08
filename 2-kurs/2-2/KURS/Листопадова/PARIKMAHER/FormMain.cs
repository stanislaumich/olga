using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARIKMAHER
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.rasp". При необходимости она может быть перемещена или удалена.
            this.raspTableAdapter.FillByData(this.lISTDataSet.rasp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.prich". При необходимости она может быть перемещена или удалена.
            this.prichTableAdapter.Fill(this.lISTDataSet.prich);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.fio". При необходимости она может быть перемещена или удалена.
            this.fioTableAdapter.Fill(this.lISTDataSet.fio);

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport reportForm = new FormReport();
            reportForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "PARIKMAHER.chm";
            p.StartInfo.Arguments = ""; //чтобы программно нажать enter
            p.Start();
        }

        private void raspfioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.raspTableAdapter.FillByData(this.lISTDataSet.rasp,Convert.ToDateTime("30.04.2022"));
        }
    }
}
