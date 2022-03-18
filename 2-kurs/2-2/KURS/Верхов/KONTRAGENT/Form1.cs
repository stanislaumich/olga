using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KONTRAGENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.DOLG". При необходимости она может быть перемещена или удалена.
            this.dOLGTableAdapter.Fill(this.z1DataSet1.DOLG);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.PEOPLE". При необходимости она может быть перемещена или удалена.
            this.pEOPLETableAdapter.Fill(this.z1DataSet1.PEOPLE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.SKLAD". При необходимости она может быть перемещена или удалена.
            //this.sKLADTableAdapter.Fill(this.z1DataSet1.SKLAD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.SKLAD". При необходимости она может быть перемещена или удалена.
            this.sKLADTableAdapter.Fill(this.z1DataSet1.SKLAD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.BANK". При необходимости она может быть перемещена или удалена.
            this.bANKTableAdapter.Fill(this.z1DataSet1.BANK);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet1.KONTR);
            /*// TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet1.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet1.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            */
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            //this.kONTRTableAdapter.Fill(this.z1DataSet1.KONTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.SKLAD". При необходимости она может быть перемещена или удалена.
            //this.sKLADTableAdapter.Fill(this.z1DataSet1.SKLAD);
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.BANK". При необходимости она может быть перемещена или удалена.
            //this.bANKTableAdapter.Fill(this.z1DataSet1.BANK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }
        /*

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    string nameRups = listBox1.SelectedItem.ToString();
    using (SqlConnection con = new SqlConnection(conString))
    {
        SqlCommand com = new SqlCommand();
        string sql = "select name_rups, name_podrazd, phone from spr_rups where name_rups = @name_rups";
        com.Parameters.AddWithValue("@name_rups", nameRups);
        com.CommandText = sql;
        SqlDataAdapter adap = new SqlDataAdapter(com);
        DataTable table = new DataTable();
        adap.Fill(table);
        dataGridView1.DataSource = table;
    }
}

        */
        private void button2_Click(object sender, EventArgs e)
        {
           // kONTRTableAdapter.Update(z1DataSet);
           // bANKTableAdapter.Update(z1DataSet);
           // sKLADTableAdapter.Update(z1DataSet);
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          /*  using (SqlConnection con = new SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Z1.mdb"))
            {
                SqlCommand com = new SqlCommand();
                string sql = "select * from BANK where id = @idd";
                string nameRups = (string)dataGridView2.CurrentCell.Value;
                com.Parameters.AddWithValue("@idd", nameRups);
                com.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                dataGridView1.DataSource = table;
            }
          */
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bANKTableAdapter.FillBy(this.z1DataSet1.BANK);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
