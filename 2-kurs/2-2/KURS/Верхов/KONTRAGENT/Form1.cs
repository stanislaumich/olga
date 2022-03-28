﻿using System;
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
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet2.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet2.DOGOVOR);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet1.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet1.DOGOVOR);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.STATUS". При необходимости она может быть перемещена или удалена.
            this.sTATUSTableAdapter.Fill(this.z1DataSet.STATUS);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.DOLG". При необходимости она может быть перемещена или удалена.
            this.dOLGTableAdapter.Fill(this.z1DataSet.DOLG);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.PEOPLE". При необходимости она может быть перемещена или удалена.
            this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.BANK". При необходимости она может быть перемещена или удалена.
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
               // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.DOLG". При необходимости она может быть перемещена или удалена.
            //this.dOLGTableAdapter.Fill(this.z1DataSet.DOLG);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.PEOPLE". При необходимости она может быть перемещена или удалена.
            this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.BANK". При необходимости она может быть перемещена или удалена.
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
            // TODO: данная Запись кода позволяет загрузить данные в таблицу "z1DataSet.KONTR". При необходимости она может быть перемещена или удалена.
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);

            ////
            ///
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
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
        private void Errmess()
        {
            MessageBox.Show("Пустые поля недопустимы!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void button6_Click(object sender, EventArgs e)
        {// записать должность
            if ((textBox10.Text == ""))
            {
                Errmess();
            }
            else
            {
                this.dOLGTableAdapter.InsertQuery(textBox10.Text, textBox11.Text);
                this.dOLGTableAdapter.Fill(this.z1DataSet.DOLG);
                MessageBox.Show("Запись вставлена!");
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {// записать банк
            if ((textBox5.Text=="")|| (textBox6.Text == "") || (textBox7.Text == "") || (textBox8.Text == "")) {
                Errmess(); 
            }
            else {
                this.bANKTableAdapter.InsertQuery(textBox5.Text, textBox8.Text, textBox6.Text, textBox7.Text, textBox9.Text);
                this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
                MessageBox.Show("Запись вставлена!");
            }

            
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
            if ((textBox12.Text == "") || (textBox13.Text == "") || (textBox14.Text == "") )
            {
                Errmess();
            }
            else
            {
                this.pEOPLETableAdapter.InsertQuery(textBox12.Text, textBox13.Text, textBox14.Text, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox6.SelectedValue));
                this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
                MessageBox.Show("Запись вставлена!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // записать договор
            if ((textBox16.Text == "") )
            {
                Errmess();
            }
            else
            {
                this.dOGOVORTableAdapter.InsertQuery(textBox16.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox5.SelectedValue));
                this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
                MessageBox.Show("Запись вставлена!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);

            //dataGridView1.Update();
            //dataGridView1.Refresh();

            }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString();
            textBox11.Text = dataGridView5[1, dataGridView5.CurrentRow.Index].Value.ToString();
        }
        //SubmitChanges() все изменения сохраняются.
        private void button2_Click_2(object sender, EventArgs e)
        {
            this.dOLGTableAdapter.DeleteQuery(dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString(), dataGridView5[1, dataGridView5.CurrentRow.Index].Value.ToString());
            this.dOLGTableAdapter.Fill(this.z1DataSet.DOLG);
            MessageBox.Show("Запись удалена!");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bANKTableAdapter.DeleteQuery(Convert.ToInt32(textBox17.Text));
            this.bANKTableAdapter.Fill(this.z1DataSet.BANK);
            MessageBox.Show("Запись удалена!");
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            textBox5.Text = dataGridView6[0, dataGridView6.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView6[2, dataGridView6.CurrentRow.Index].Value.ToString();
            textBox7.Text = dataGridView6[3, dataGridView6.CurrentRow.Index].Value.ToString();
            textBox8.Text = dataGridView6[1, dataGridView6.CurrentRow.Index].Value.ToString(); 
            textBox9.Text = dataGridView6[4, dataGridView6.CurrentRow.Index].Value.ToString();
            textBox17.Text = dataGridView6[5, dataGridView6.CurrentRow.Index].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            comboBox2.Text = "";
            comboBox6.Text = "";
        }

        private void dataGridView7_Click(object sender, EventArgs e)
        {
            textBox12.Text = dataGridView7[0, dataGridView7.CurrentRow.Index].Value.ToString();
            textBox13.Text = dataGridView7[1, dataGridView7.CurrentRow.Index].Value.ToString();
            textBox14.Text = dataGridView7[2, dataGridView7.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView7[3, dataGridView7.CurrentRow.Index].Value.ToString();
            comboBox6.Text = dataGridView7[2, dataGridView7.CurrentRow.Index].Value.ToString();
            textBox9.Text = dataGridView7[4, dataGridView7.CurrentRow.Index].Value.ToString();
            //textBox17.Text = dataGridView7[5, dataGridView7.CurrentRow.Index].Value.ToString();
            textBox18.Text = dataGridView7[5, dataGridView7.CurrentRow.Index].Value.ToString();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // удалить сотрудника
            this.pEOPLETableAdapter.DeleteQuery(Convert.ToInt32(textBox18.Text));
            this.pEOPLETableAdapter.Fill(this.z1DataSet.PEOPLE);
            MessageBox.Show("Запись удалена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // записать контрагента
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                Errmess();
            }
            else
            {
                this.kONTRTableAdapter.InsertQuery(textBox2.Text, textBox3.Text, Convert.ToInt32(comboBox1.SelectedValue), textBox4.Text, textBox1.Text);
                this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
                MessageBox.Show("Запись вставлена!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        { // удалить контрагента
            this.kONTRTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView8[4, dataGridView8.CurrentRow.Index].Value));
            this.kONTRTableAdapter.Fill(this.z1DataSet.KONTR);
            MessageBox.Show("Запись удалена!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // записать статус
            if ((textBox15.Text == ""))
            {
                Errmess();
            }
            else
            {
                this.sTATUSTableAdapter.InsertQuery(textBox15.Text);
                this.sTATUSTableAdapter.Fill(this.z1DataSet.STATUS);
                MessageBox.Show("Запись вставлена!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dOGOVORBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // удалить договор 19
            this.dOGOVORTableAdapter.DeleteQuery(Convert.ToInt32(textBox19.Text));
            this.dOGOVORTableAdapter.Fill(this.z1DataSet.DOGOVOR);
            MessageBox.Show("Запись удалена!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";

        }

        private void dataGridView9_Click(object sender, EventArgs e)
        {
            // заполнить поля контрагента
            textBox16.Text = dataGridView9[0, dataGridView9.CurrentRow.Index].Value.ToString();
            textBox19.Text = dataGridView9[6, dataGridView9.CurrentRow.Index].Value.ToString();
            comboBox3.Text = dataGridView9[1, dataGridView9.CurrentRow.Index].Value.ToString();
            comboBox5.Text = dataGridView9[4, dataGridView9.CurrentRow.Index].Value.ToString();
            comboBox4.Text = dataGridView9[5, dataGridView9.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView9[2, dataGridView9.CurrentRow.Index].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView9[3, dataGridView9.CurrentRow.Index].Value.ToString());
        }
    }
}
/*
 * System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
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
*/
