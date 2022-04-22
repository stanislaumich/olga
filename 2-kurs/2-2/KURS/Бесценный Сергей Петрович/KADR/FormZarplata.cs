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
            this.zarplataTableAdapter.Fill(this.kadrDataSet.zarplata);
            this.sotrudTableAdapter.Fill(this.kadrDataSet.sotrud);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double stavka= (float)stavkaTableAdapter.StavkaQuery();
           double idstavka = (float)stavkaTableAdapter.IdStavkaQuery();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = dataGridView1.RowCount;
            progressBar1.Step = 1;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int id_sotrud = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());

                double oklad = (float)stavkaTableAdapter.KoeffQuery(id_sotrud) * stavka;
                double premia = oklad/100*Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                double itogo = oklad+premia;

                this.zarplataTableAdapter.InsertQuery(dateTimePicker1.Value,id_sotrud, (int?)oklad, (int?)premia,
                    (int?)itogo, (int?)idstavka);
                progressBar1.PerformStep();
            }
            MessageBox.Show("Завершено!");
        }
    }
}
