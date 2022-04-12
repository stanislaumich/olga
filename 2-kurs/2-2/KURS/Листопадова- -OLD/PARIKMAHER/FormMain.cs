using System;
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
            //InitializeComponent();
            this.tipTableAdapter.Fill(this.lISTDataSet.tip);
            this.phoneTableAdapter.Fill(this.lISTDataSet.phone);
            label1.Text = Convert.ToString(DateTime.Now);
            //label1.Visible = true;
            this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
            this.prichTableAdapter.Fill(this.lISTDataSet.prich);
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
            //this.raspTableAdapter.FillByData(this.lISTDataSet.rasp,Convert.ToDateTime("30.04.2022"));
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            comboBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Пустые поля не допускаются!");
            }
            else
            {
                this.raspTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue),
                    dateTimePicker1.Value,
                    Convert.ToInt32(comboBox2.Text),
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(comboBox3.SelectedValue));
                this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
                //this.raspTableAdapter.FillByData(this.lISTDataSet.rasp,
                //    Convert.ToDateTime(label1.Text));
                MessageBox.Show("Запись добавлена!");

            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = Convert.ToInt32(dataGridView2[4, dataGridView2.CurrentRow.Index].Value.ToString());
            }
            catch
            {
                comboBox1.Text = "";
            }
            try
            {
                comboBox3.SelectedIndex = Convert.ToInt32(dataGridView2[3, dataGridView2.CurrentRow.Index].Value.ToString());
            }
            catch
            {
                comboBox3.Text = "";
            }
            textBox1.Text = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString());
            comboBox2.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNastr nastrForm = new FormNastr();
            nastrForm.ShowDialog();
        }
    }
}
