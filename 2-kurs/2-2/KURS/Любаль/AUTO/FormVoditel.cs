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
    public partial class FormVoditel : Form
    {
        public FormVoditel()
        {
            InitializeComponent();
        }

        private void FormVoditel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.dolg". При необходимости она может быть перемещена или удалена.
            this.dolgTableAdapter.Fill(this.aUTODataSet.dolg);
            this.voditelTableAdapter.Fill(this.aUTODataSet.voditel);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") {
                this.voditelTableAdapter.DeleteQuery(Convert.ToInt32(textBox1.Text));
                this.voditelTableAdapter.Fill(this.aUTODataSet.voditel);
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
            this.voditelTableAdapter.InsertQuery(textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), 
                Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text, Convert.ToInt32(comboBox2.SelectedValue));
            this.voditelTableAdapter.Fill(this.aUTODataSet.voditel);
            MessageBox.Show("Запись вставлена!");
        }
    }
}
