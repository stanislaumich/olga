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

namespace Avto
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
            refreshDG3(dataGridView3);
            refreshDG4(dataGridView4,$"select '1' as Col1, '2' as col2, '3' as col3, '4' as col4 from [Park]");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshDG(dataGridView1);
            refreshDG2(dataGridView2);
            refreshDG3(dataGridView3);
            //refreshDG4(dataGridView4,$"select '1' as Col1, '2' as col2, '3' as col3, '4' as col4 from [Park]");
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Номер");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Adr", "Адрес");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns.Add("ID", "Номер");
            dataGridView2.Columns.Add("FIO", "ФИО");
            dataGridView2.Columns.Add("Age", "Возраст");
            dataGridView2.Columns.Add("IDAvto", "Машина");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns.Add("ID", "Номер");
            dataGridView3.Columns.Add("Name", "Название");
            dataGridView3.Columns.Add("IDPark", "Парк");
            dataGridView3.Columns.Add("IsNew", String.Empty);
            dataGridView4.Columns.Add("Col1", String.Empty);
            dataGridView4.Columns.Add("Col2", String.Empty);
            dataGridView4.Columns.Add("Col3", String.Empty);
            dataGridView4.Columns.Add("Col4", String.Empty);
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), rowState.ModifiedNew);
        }
        private void ReadSinglRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), rowState.ModifiedNew);
        }
        private void ReadSinglRow3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), rowState.ModifiedNew);
        }
        private void ReadSinglRow4(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }
        private void refreshDG(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystr = $"Select * from [Park]";
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
            string querystr = $"Select * from [Voditel]";
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
            string querystr = $"Select * from [Avto]";
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
            string querystr = $" select * from [Park] Where concat(Name,Adr) like '%" + textBox4.Text + "%'";
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
            string querystr = $" select * from [Park] Where Name = 'Автобаза №4'";
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
            string querystr = $" select * from [Park] Where Name = 'Автопарк №10'";
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
            string querystr = $" select * from [Park] Where Name = 'Городской автопарк №1'";
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
            string querystr = $" select * from [Park] Where Name = 'Автобусный парк №2'";
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
            var addQuery = $"delete from [Park] where ID={textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addQuery = $"update [Park] set Name='{textBox2.Text}' , Adr =  '{textBox3.Text}' where ID = {textBox1.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG(dataGridView1);
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
            var addQuery = $"insert into [Voditel] (Fio,Age, IdAvto) values ('{textBox6.Text}' , '{textBox7.Text}',{comboBox1.SelectedIndex+1})";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG2(dataGridView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var addQuery = $"delete from [Voditel] where ID={textBox5.Text}";
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
            var addQuery = $"insert into [Avto] (Name,IdPark) values ('{textBox9.Text}' ,{comboBox2.SelectedIndex + 1})";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var addQuery = $"delete from [Avto] where ID={textBox8.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var addQuery = $"update [Voditel] set Fio='{textBox6.Text}' , Age =  '{textBox7.Text}', IdAvto = '{comboBox1.SelectedIndex+1}' where ID = {textBox5.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG2(dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var addQuery = $"update [Avto] set Name='{textBox9.Text}' , IdPark =  '{comboBox2.SelectedIndex+1}' where ID = {textBox8.Text}";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();
            refreshDG3(dataGridView3);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            dataGridView4.Rows.Clear();
            string querystr = $"select s.name as col1, g.name as col2, d.name as col3,'' as col4\r\nfrom [Voditel] d, [Avto] s, [Park] g\r\nwhere d.idAvto=s.id and s.idPark=g.id";
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
            string querystr = $"select FIO as col1, CAST(Age AS varchar(5)) as col2, CAST(Age+20 AS varchar(5)) as col3, '' as col4 from [Voditel]";
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
            if (radioButton5.Checked) {
                 s = "AND"; }
            string n = textBox10.Text;
            string l = textBox11.Text;


            string querystr = $"select fio as col1, CAST(Age AS varchar(5)) as col2, '' as col3, '' as col4 from [Voditel] s where Fio='{n}' {s} Age='{l}'";
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
            string n = textBox12.Text;
            string querystr = $"select Fio as col1, CAST(Age AS varchar(5)) as col2, '' as col3, '' as col4 from [Voditel] s where Fio='{n}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow4(dataGridView4, reader);
            }
            reader.Close();
        }
    }

    class DataBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Avto;Integrated Security=True");

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
