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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet1.razr". При необходимости она может быть перемещена или удалена.
            this.razrTableAdapter.Fill(this.kadrDataSet1.razr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet1.dolg". При необходимости она может быть перемещена или удалена.
            this.dolgTableAdapter.Fill(this.kadrDataSet1.dolg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);

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
    }
}
