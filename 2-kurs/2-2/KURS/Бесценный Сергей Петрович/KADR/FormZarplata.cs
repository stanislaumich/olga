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
    public partial class FormZarplata : Form
    {
        public FormZarplata()
        {
            InitializeComponent();
        }

        private void FormZarplata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.stavka". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.kadrDataSet.zarplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrDataSet.sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double stavka= (float)stavkaTableAdapter.StavkaQuery();
           double idstavka = (float)stavkaTableAdapter.IdStavkaQuery();


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int id_sotrud = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());

                double oklad = (float)stavkaTableAdapter.KoeffQuery(id_sotrud) * stavka;
                double premia = oklad/100*Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                double itogo = oklad+premia;

                this.zarplataTableAdapter.InsertQuery(dateTimePicker1.Value,id_sotrud, (int?)oklad, (int?)premia,
                    (int?)itogo, (int?)idstavka);
            }
            MessageBox.Show("Завершено!");
        }
    }
}
