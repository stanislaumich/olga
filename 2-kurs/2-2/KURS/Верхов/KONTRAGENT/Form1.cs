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
using System.Configuration;


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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.PEOPLE". При необходимости она может быть перемещена или удалена.
            this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.BANK". При необходимости она может быть перемещена или удалена.
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }


    
        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Z1.mdb";
            try
            {
                conn.Open();
                String my_querry = "INSERT INTO DOLG (nazv,dop) VALUES ('123','222')";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data saved successfuly...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {// записать должность
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Z1.mdb";
            try
            {
                conn.Open();
                String my_querry = "INSERT INTO DOLG (nazv,dop) VALUES ('"+textBox10.Text+"','"+textBox11.Text+"')";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные записаны!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось записать данные" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
        }
    }
}
