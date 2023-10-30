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
    public partial class FormReport1 : Form
    {
        public FormReport1()
        {
            InitializeComponent();
            //this.panel1.Controls.Add(this.reportViewer1);
        }

        private void FormReport1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AUTODataSet1.dolg_Запрос". При необходимости она может быть перемещена или удалена.
            this.dolg_ЗапросTableAdapter.Fill(this.AUTODataSet1.dolg_Запрос);

            this.reportViewer2.RefreshReport();
        }
    }
}
