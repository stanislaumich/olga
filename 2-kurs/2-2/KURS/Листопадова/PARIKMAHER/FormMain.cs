using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.rasp". При необходимости она может быть перемещена или удалена.
            this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.lISTDataSet.tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.prich". При необходимости она может быть перемещена или удалена.
            this.prichTableAdapter.Fill(this.lISTDataSet.prich);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.phone". При необходимости она может быть перемещена или удалена.
            this.phoneTableAdapter.Fill(this.lISTDataSet.phone);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lISTDataSet.fio". При необходимости она может быть перемещена или удалена.
            this.fioTableAdapter.Fill(this.lISTDataSet.fio);

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox9.Text= dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            textBox1.Text = dataGridView2[3, dataGridView2.CurrentRow.Index].Value.ToString();
            label16.Text = dataGridView2[4, dataGridView2.CurrentRow.Index].Value.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
//nonono
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            textBox7.Text = dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString();
            textBox8.Text = dataGridView4[1, dataGridView4.CurrentRow.Index].Value.ToString();
            textBox10.Text = dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString();
            label15.Text= dataGridView4[2, dataGridView4.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView4[1, dataGridView4.CurrentRow.Index].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label15.Text=="") { MessageBox.Show("Укажите запись!"); }
            else { 
                this.prichTableAdapter.DeleteQuery(Convert.ToInt32(label15.Text));
                this.prichTableAdapter.Fill(this.lISTDataSet.prich);
                MessageBox.Show("Запись удалена!"); 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox7.Text == ""))
            {
                MessageBox.Show("Нельзя вставить пустую запись!");
            }
            else
            {
                this.prichTableAdapter.InsertQuery(textBox7.Text, 
                    Convert.ToInt32(textBox8.Text));
                this.prichTableAdapter.Fill(this.lISTDataSet.prich);
                MessageBox.Show("Запись вставлена!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox9.Text == ""))
            {
                MessageBox.Show("Нельзя вставить пустую запись!");
            }
            else
            {
                switch (comboBox2.Text) {
                    case "М":
                this.fioTableAdapter.InsertQuery(textBox9.Text, true,
                    Convert.ToInt32(textBox2.Text), textBox1.Text);
                        break;
                    case "Ж":
                        this.fioTableAdapter.InsertQuery(textBox9.Text,false,
                Convert.ToInt32(textBox2.Text), textBox1.Text);
                        break;

                }
                this.fioTableAdapter.Fill(this.lISTDataSet.fio);
                MessageBox.Show("Запись вставлена!");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBox4.Text != "") {
                this.phoneTableAdapter.InsertQuery(Convert.ToInt32(label16.Text), 
                  Convert.ToInt32(comboBox5.SelectedValue), textBox4.Text);
                i += 1;
            }
            if (textBox5.Text != "")
            {
                this.phoneTableAdapter.InsertQuery(Convert.ToInt32(label16.Text),
                  Convert.ToInt32(comboBox6.SelectedValue), textBox5.Text);
                i += 1;
            }
            if (textBox6.Text != "")
            {
                this.phoneTableAdapter.InsertQuery(Convert.ToInt32(label16.Text),
                  Convert.ToInt32(comboBox7.SelectedValue), textBox6.Text);
                i += 1;
            }


            this.phoneTableAdapter.Fill(this.lISTDataSet.phone);
            if (i > 0) { 
                MessageBox.Show("Телефоны вставлены!"); 
            }
            else
            {
                MessageBox.Show("Телефоны не вставлены!");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label16.Text == "") { MessageBox.Show("Укажите запись!"); }
            else
            {
                this.fioTableAdapter.DeleteQuery(Convert.ToInt32(label16.Text));
                this.fioTableAdapter.Fill(this.lISTDataSet.fio);
                MessageBox.Show("Запись удалена!");
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport reportForm = new FormReport();
            reportForm.Show();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "PARIKMAHER.chm";
            p.StartInfo.Arguments = ""; //чтобы программно нажать enter
            p.Start();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox9.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox4.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            textBox10.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            label17.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label17.Text == "") { MessageBox.Show("Укажите запись!"); }
            else
            {
                this.raspTableAdapter.DeleteQuery(Convert.ToInt32(label17.Text));
                this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
                MessageBox.Show("Запись удалена!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTimeFormatInfo usDtfi = new CultureInfo("ru-RU", false).DateTimeFormat;
            if (textBox9.Text == "") { MessageBox.Show("Не указано ФИО!"); }
            else
            {
                this.raspTableAdapter.InsertQuery(Convert.ToInt32(label15.Text),//prich
                   Convert.ToInt32(textBox3.Text), //price
                   Convert.ToInt32(comboBox4.Text),//hour
                   Convert.ToDateTime(dateTimePicker1.Value, usDtfi),// date
                   Convert.ToInt32(label16.Text)  //idfio
                    );
                this.raspTableAdapter.Fill(this.lISTDataSet.rasp);
                MessageBox.Show("Запись добавлена!");
            }
        }
    }
}
