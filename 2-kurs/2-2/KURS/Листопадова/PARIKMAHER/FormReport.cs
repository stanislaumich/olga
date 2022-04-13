using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARIKMAHER
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
           // this.panel1.Controls.Add(this.reportViewer1);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "LISTDataSet.rasp". При необходимости она может быть перемещена или удалена.
            this.raspTableAdapter.Fill(this.LISTDataSet.rasp);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
