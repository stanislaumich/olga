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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Disk
{
    enum rowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
            CreateColumns();
            refreshDG(dataGridView1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshDG(dataGridView1);
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Descr", "Descr");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), rowState.ModifiedNew);
        }
        private void refreshDG(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [Group]";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f_add = new Form2();
            f_add.ShowDialog();
            refreshDG(dataGridView1);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataGridView dwg = dataGridView1;
            dwg.Rows.Clear();
            string querystr = $" select * from [Group] Where concat(Name,Descr) like '%" + textBox4.Text + "%'";
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
            string querystr = $" select * from [Group] Where Name = 'Ласковый май'";
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
            refreshDG(dataGridView1);
        }
    }

    class DataBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LZ42NOTE\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");

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
