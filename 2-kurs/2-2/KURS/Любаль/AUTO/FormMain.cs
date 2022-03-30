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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFind findForm = new FormFind();
            findForm.ShowDialog();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormToplivo toplivoForm = new FormToplivo();
            toplivoForm.Show();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuto autoForm = new FormAuto();
            autoForm.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDolg dolgForm = new FormDolg();
            dolgForm.Show();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVoditel voditelForm = new FormVoditel();
            voditelForm.Show();
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPutevka putevkaForm = new FormPutevka();
            putevkaForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.aUTODataSet.auto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aUTODataSet.putevka". При необходимости она может быть перемещена или удалена.
            this.putevkaTableAdapter.Fill(this.aUTODataSet.putevka);

        }
    }
}
