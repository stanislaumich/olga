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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.PEOPLE". При необходимости она может быть перемещена или удалена.
            this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.BANK". При необходимости она может быть перемещена или удалена.
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
               // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.DOLG". При необходимости она может быть перемещена или удалена.
            //this.dOLGTableAdapter.Fill(this.z1DataSet.DOLG);
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

        /*
         * 
         * 
         * 
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




         */

        private void button2_Click(object sender, EventArgs e)
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
            /*   внести в комбобокс   */
            //comboBox2.DataBindings.

            /*      */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {// записать банк
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Z1.mdb";
            try
            {
                conn.Open();
                String my_querry = "INSERT INTO BANK (nazv,adr, schet, filial,dop) VALUES ('" + textBox5.Text + "','" + textBox8.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "');";
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
            object dt = dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // записать сотрудника
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Z1.mdb";
            try
            {
                conn.Open();
                String my_querry = "INSERT INTO PEOPLE (fio,phone, adr, id_dolg, id_kontr) VALUES ('" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + comboBox2.SelectedValue + "','" + comboBox6.SelectedValue + "')";
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

        private void button12_Click(object sender, EventArgs e)
        {
            // записать договор
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Z1.mdb";
            try
            {
                conn.Open();
                String my_querry = "INSERT INTO DOGOVOR (nomer,phone, adr, id_dolg, id_kontr) VALUES ('" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + comboBox2.SelectedValue + "','" + comboBox6.SelectedValue + "')";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            // bANKKONTRBindingSource.DataSource.up
            //
            //
            dataGridView1.Update();
            dataGridView1.Refresh();

            }
    }
}
