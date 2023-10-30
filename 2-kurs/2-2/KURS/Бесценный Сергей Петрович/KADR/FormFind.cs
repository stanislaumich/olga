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
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }

        private void FormFind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.kadrDataSet.zarplata);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sotrudTableAdapter.FillBy(this.kadrDataSet.sotrud,"%"+textBox1.Text+"%");
            if (dataGridView2.RowCount > 0)
            {
                label2.Text = dataGridView2[4, 1].Value.ToString();
                //dataGridView2.CellClick(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
            textBox1.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.zarplataTableAdapter.FillByIdSotr(this.kadrDataSet.zarplata,Convert.ToInt32(dataGridView2[4, dataGridView2.CurrentRow.Index].Value.ToString()));
        }
    }
}
