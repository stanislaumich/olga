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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.SotrZarplRep". При необходимости она может быть перемещена или удалена.
            this.SotrZarplRepTableAdapter.Fill(this.kadrDataSet.SotrZarplRep);

            this.reportViewer1.RefreshReport();
        }
    }
}
