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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
