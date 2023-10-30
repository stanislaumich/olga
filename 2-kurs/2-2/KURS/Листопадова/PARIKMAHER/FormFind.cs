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
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }

        private void FormFind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.rasp". При необходимости она может быть перемещена или удалена.
            this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.fio". При необходимости она может быть перемещена или удалена.
            this.fioTableAdapter.Fill(this.lISTDataSet.fio);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.fioTableAdapter.Fill(this.lISTDataSet.fio);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.raspTableAdapter.FillBy(this.lISTDataSet.rasp,dateTimePicker1.Value.Date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fioTableAdapter.FillBy(this.lISTDataSet.fio,"%"+ textBox1.Text+"%");
        }
    }
}
