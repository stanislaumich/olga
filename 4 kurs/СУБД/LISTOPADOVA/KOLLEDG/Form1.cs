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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kolledg
{
    
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
            CreateColumns();
            refreshDG1(dataGridView1);
            refreshDG2(dataGridView2);
            refreshDG3(dataGridView3);
            refreshDG4(dataGridView4,$"select TOP (1) '1' as Col1, '2' as col2, '3' as col3, '4' as col4 from [fak]");
        }
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshDG1(dataGridView1);
            refreshDG2(dataGridView2);
            refreshDG3(dataGridView3);
            //refreshDG4(dataGridView4,$"select '1' as Col1, '2' as col2, '3' as col3, '4' as col4 from [fak]");
        }
        */
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Номер");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Descr", "Описание");
            //dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns.Add("ID", "Номер");
            dataGridView2.Columns.Add("Name", "Название");
            dataGridView2.Columns.Add("post", "Г. Рожд.");
            dataGridView2.Columns.Add("IDgrp", "Группа");
            //dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns.Add("ID", "Номер");
            dataGridView3.Columns.Add("Name", "Название");
            dataGridView3.Columns.Add("IDfak", "Группа");
            //dataGridView3.Columns.Add("IsNew", String.Empty);
            dataGridView4.Columns.Add("C1", String.Empty);
            dataGridView4.Columns.Add("C2", String.Empty);
            dataGridView4.Columns.Add("C3", String.Empty);
            dataGridView4.Columns.Add("C4", String.Empty);
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }
        private void ReadSinglRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3));
        }
        private void ReadSinglRow3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
        }
        private void ReadSinglRow4(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }
        private void refreshDG1(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [fak]";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();
        }
        private void refreshDG2(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [uch]";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow2(dgw, reader);
            }
            reader.Close();
        }
        private void refreshDG3(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [grp]";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow3(dgw, reader);
            }
            reader.Close();
        }
        private void refreshDG4(DataGridView dgw, string s)
        {
            dgw.Rows.Clear();
            string querystr = s;
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var addQuery = $"insert into [fak] (Name,Descr) values ('{textBox1.Text}' , '{textBox2.Text}')";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            this.Close();
            refreshDG1(dataGridView1);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [fak] Where concat(Name,Descr) like '%" + textBox4.Text + "%'";
            SqlCommand com = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dwg, reader);
            }
            reader.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [fak] Where Name = 'Программное обеспечение'";
            SqlCommand com = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dwg, reader);
            }
            reader.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshDG1(dataGridView1);
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [fak] Where Name = 'Препринимательство'";
            SqlCommand com = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dwg, reader);
            }
            reader.Close();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [fak] Where Name = 'Металлургия'";
            SqlCommand com = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dwg, reader);
            }
            reader.Close();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [fak] Where Name = 'Сварочная спец.'";
            SqlCommand com = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dwg, reader);
            }
            reader.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var addQuery = $"delete from [fak] where ID={textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG1(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addQuery = $"update [fak] set Name='{textBox2.Text}' , Descr =  '{textBox3.Text}' where ID = {textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG1(dataGridView1);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                textBox5.Text = row.Cells[0].Value.ToString();
                textBox6.Text = row.Cells[1].Value.ToString();
                textBox7.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedIndex = Int32.Parse(row.Cells[3].Value.ToString())-1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var addQuery = $"insert into [uch] (Name,post, Idgrp) values ('{textBox6.Text}' , '{textBox7.Text}',{comboBox1.SelectedIndex+1})";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG2(dataGridView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var addQuery = $"delete from [uch] where ID={textBox5.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG2(dataGridView2);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
              DataGridViewRow row = dataGridView3.Rows[selectedRow];
                textBox8.Text = row.Cells[0].Value.ToString();
                textBox9.Text = row.Cells[1].Value.ToString();
                comboBox2.SelectedIndex = Int32.Parse(row.Cells[2].Value.ToString())-1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var addQuery = $"insert into [Gruop] (Name,Idfak) values ('{textBox9.Text}' ,{comboBox2.SelectedIndex + 1})";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var addQuery = $"delete from [grp] where ID={textBox8.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var addQuery = $"update [uch] set Name='{textBox6.Text}' , post =  '{textBox7.Text}', Idgrp = '{comboBox1.SelectedIndex+1}' where ID = {textBox5.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG2(dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var addQuery = $"update [grp] set Name='{textBox9.Text}' , Idfak =  '{comboBox2.SelectedIndex+1}' where ID = {textBox8.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            dataGridView4.Rows.Clear();
            string querystr = $"select s.fio as c1, s.post as c2, g.name as c3, d.name as c4 from [fak] d, [uch] s, [grp] g where g.idfak=d.id and s.idgrp=g.id";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dataGridView4, reader);
            }
            reader.Close();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            string querystr = $"select fio as col1, CAST(post AS varchar(5)) as col2, CAST(post-1000 AS varchar(5)) as col3, 'post-1000' as col4 from [uch] s";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dataGridView4, reader);
            }
            reader.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {// условие
            dataGridView4.Rows.Clear();
            string s = "OR";
            if (comboBox3.SelectedIndex == 0) {
                 s = "AND"; }
            string n = '%'+textBox10.Text+'%';
            string l = textBox11.Text;


            string querystr = $"select fio as c1, CAST(post AS varchar(5)) as c2, '' as c3, '' as c4 from [uch] s where fio like '{n}' {s} post='{l}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dataGridView4, reader);
            }
            reader.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            string n = '%'+textBox12.Text+'%';
            string querystr = $"select fio as c1, CAST(post AS varchar(5)) as c2, '' as c3, '' as c4 from [uch] s where fio like'{n}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dataGridView4, reader);
            }
            reader.Close();
        }
        /*
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void grpBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
    }

    class DataBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=kolledg;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }


}
