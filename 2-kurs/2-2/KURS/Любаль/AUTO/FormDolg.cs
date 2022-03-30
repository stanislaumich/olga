using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTO
{
    public partial class FormDolg : Form
    {
        public FormDolg()
        {
            InitializeComponent();
        }

        private void FormDolg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.dolg". При необходимости она может быть перемещена или удалена.
            this.dolgTableAdapter.Fill(this.aUTODataSet.dolg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(); ;
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(); ;
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dolgTableAdapter.DeleteQuery(Convert.ToInt32(textBox3.Text));
            this.dolgTableAdapter.Fill(this.aUTODataSet.dolg);
            MessageBox.Show("Запись удалена!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dolgTableAdapter.InsertQuery(textBox1.Text,textBox2.Text);
            this.dolgTableAdapter.Fill(this.aUTODataSet.dolg);
            MessageBox.Show("Запись вставлена!");

        }
    }
}
