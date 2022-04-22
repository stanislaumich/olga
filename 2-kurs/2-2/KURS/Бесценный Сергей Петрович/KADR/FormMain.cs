//using KADR.kadrDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KADR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.stavka". При необходимости она может быть перемещена или удалена.
            this.stavkaTableAdapter.Fill(this.kadrDataSet.stavka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet1.razr". При необходимости она может быть перемещена или удалена.
            this.razrTableAdapter.Fill(this.kadrDataSet.razr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet1.dolg". При необходимости она может быть перемещена или удалена.
            this.dolgTableAdapter.Fill(this.kadrDataSet.dolg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            textBox8.Text=Convert.ToString((float)stavkaTableAdapter.StavkaQuery());
            dateTimePicker1.Value = DateTime.Now;
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport reportForm = new FormReport();
            reportForm.Show();
        }

        private void зарплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZarplata zarplataForm = new FormZarplata();
            zarplataForm.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();//fio
          // 33
            comboBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();//dolg
            
            textBox4.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();//premia
            textBox2.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();//phone
            textBox3.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();//adr
            textBox5.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();//dop
            label11.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();//idd
            label12.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();//ids
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = "0";//idd
            label12.Text = "0";//ids
            textBox1.Text = "";//fio
            comboBox1.Text = "";//dolg
            textBox4.Text = "";//premia
            textBox2.Text = "";//phone
            textBox3.Text ="";//adr
            textBox5.Text = "";//dop
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="") { MessageBox.Show("Не указано ФИО"); }
            else {

                this.sotrudTableAdapter.InsertQuery(textBox1.Text, Convert.ToInt32(textBox4.Text),
                    textBox2.Text, textBox3.Text, textBox5.Text, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить запись?","Подтверждение",
        MessageBoxButtons.YesNo)== DialogResult.Yes) {
                this.sotrudTableAdapter.DeleteQuery(Convert.ToInt32(label12.Text));
                this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Не указано ФИО"); }
            else
            {
                this.sotrudTableAdapter.UpdateQuery(textBox1.Text, 
                    Convert.ToInt32(label11.Text),
                    Convert.ToInt32(textBox4.Text),
                    textBox2.Text, textBox3.Text, textBox5.Text, Convert.ToInt32(label12.Text));
                this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dolgTableAdapter.InsertQuery(textBox6.Text,  Convert.ToInt32(comboBox2.SelectedValue.ToString()),"");
            this.dolgTableAdapter.Fill(this.kadrDataSet.dolg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить запись?", "Подтверждение",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.dolgTableAdapter.DeleteQuery(Convert.ToInt32(label13.Text));
                this.dolgTableAdapter.Fill(this.kadrDataSet.dolg);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            label13.Text= dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();//
            comboBox2.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();//
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // записать сумму ставки новую
            if (MessageBox.Show("Вы хотите обновить ставку 1 разряда?", "Подтверждение",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.stavkaTableAdapter.InsertQuery(Convert.ToInt32(textBox9.Text), dateTimePicker1.Value.Date, "");
                textBox8.Text = Convert.ToString((float)stavkaTableAdapter.StavkaQuery());
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFind findForm = new FormFind();
            findForm.Show();
        }
    }
}

