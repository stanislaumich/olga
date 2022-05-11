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
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://www.cyberforum.ru/ado-net/thread326319.html
            // http://skillcoding.com/Default.aspx?id=151
            if (textBox1.Text == "") {
                MessageBox.Show("Не указана строка для поиска", "ОШИБКА!");
            }
            else
            {
                if (dataGridView1.Visible == true)
                {
                    this.putevkaTableAdapter.FillBy(this.aUTODataSet.putevka, "%"+textBox1.Text+"%");
                }
                if (dataGridView2.Visible == true)
                {
                    this.voditelTableAdapter.FillBy(this.aUTODataSet.voditel, "%" + textBox1.Text + "%");
                }
                if (dataGridView3.Visible == true)
                {
                    this.autoTableAdapter.FillBy(this.aUTODataSet.auto, "%" + textBox1.Text + "%");
                }
            }
        }

        private void FormFind_Load(object sender, EventArgs e)
        {
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            this.voditelTableAdapter.Fill(this.aUTODataSet.voditel);
            this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dataGridView2.Visible = false;                
                dataGridView3.Visible = false;
                dataGridView1.Visible = true;
            }
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;            
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
        }
    }
    }
    
    

