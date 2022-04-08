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
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "LISTDataSet.rasp". При необходимости она может быть перемещена или удалена.
            this.raspTableAdapter.FillByData(this.LISTDataSet.rasp);

            this.reportViewer1.RefreshReport();
        }
    }
}
