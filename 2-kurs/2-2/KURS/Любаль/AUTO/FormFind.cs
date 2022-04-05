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
            if (dataGridView1.Visible == true)
            {
                this.putevkaTableAdapter.FillBy(this.aUTODataSet.putevka,textBox1.Text);
            }

        }

        private void FormFind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.putevka". При необходимости она может быть перемещена или удалена.
            this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dataGridView1.Visible = true;
            }
                
        }
    }
}
