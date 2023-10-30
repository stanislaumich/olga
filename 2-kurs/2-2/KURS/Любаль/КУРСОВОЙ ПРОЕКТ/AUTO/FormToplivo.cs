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
    public partial class FormToplivo : Form
    {
        public FormToplivo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void FormToplivo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.toplivo". При необходимости она может быть перемещена или удалена.
            this.toplivoTableAdapter.Fill(this.aUTODataSet.toplivo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.toplivoTableAdapter.InsertQuery(textBox1.Text, Convert.ToDouble(textBox2.Text), textBox3.Text);
            this.toplivoTableAdapter.Fill(this.aUTODataSet.toplivo);
            MessageBox.Show("Запись вставлена!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.toplivoTableAdapter.DeleteQuery(Convert.ToInt32(textBox4.Text));
            this.toplivoTableAdapter.Fill(this.aUTODataSet.toplivo);
            MessageBox.Show("Запись удалена!");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();

        }
    }
}
