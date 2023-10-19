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
            refreshDG2(dataGridView2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshDG(dataGridView1);
            refreshDG2(dataGridView2);
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Descr", "Descr");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns.Add("ID", "ID");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Len", "Len");
            dataGridView2.Columns.Add("IDDisk", "IDDisk");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), rowState.ModifiedNew);
        }
        private void ReadSinglRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), rowState.ModifiedNew);
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
        private void refreshDG2(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [Song]";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow2(dgw, reader);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 f_add = new Form2();
            f_add.ShowDialog();
            refreshDG(dataGridView1);

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
            string querystr = $" select * from [Group] Where Name = 'Сектор газа'";
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
            string querystr = $" select * from [Group] Where Name = 'Шуфутинский'";
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
            string querystr = $" select * from [Group] Where Name = 'Metallica'";
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
            //dataBase.openConnection();
            var addQuery = $"delete from [Group] where ID={textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG(dataGridView1);
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataBase.openConnection();
            var addQuery = $"update [Group] set Name='{textBox2.Text}' , Descr =  '{textBox3.Text}' where ID = {textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG(dataGridView1);
            //this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.databaseDataSet.Group);

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
                comboBox1.Text = row.Cells[3].Value.ToString();
            }
        }
    }

    class DataBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PROG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");

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
