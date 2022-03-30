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
    public partial class FormPutevka : Form
    {
        public FormPutevka()
        {
            InitializeComponent();
        }

        private void FormPutevka_Load(object sender, EventArgs e)
        {
            this.voditelTableAdapter.Fill(this.aUTODataSet.voditel);
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.putevkaTableAdapter.DeleteQuery(Convert.ToInt32(textBox1.Text));
                this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);
                MessageBox.Show("Запись удалена!");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Запись не указана!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.putevkaTableAdapter.InsertQuery(dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox3.Text, 
                Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);
            MessageBox.Show("Запись вставлена!");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
        }
    }
}
