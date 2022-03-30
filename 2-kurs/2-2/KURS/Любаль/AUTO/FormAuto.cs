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
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.toplivo". При необходимости она может быть перемещена или удалена.
            this.toplivoTableAdapter.Fill(this.aUTODataSet.toplivo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.autoTableAdapter.InsertQuery(textBox2.Text, textBox3.Text, Convert.ToInt32(comboBox1.SelectedValue), textBox4.Text, Convert.ToInt32(textBox5.Text), textBox7.Text, Convert.ToInt32(textBox6.Text));
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            MessageBox.Show("Запись вставлена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.autoTableAdapter.DeleteQuery(Convert.ToInt32(textBox1.Text));
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            MessageBox.Show("Запись удалена!");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox7.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
