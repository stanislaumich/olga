using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TESTKURS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // закрываем соединение с БД
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "SELECT nazv FROM bank";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос и выводим результат в textBox1
            textBox1.Text = command.ExecuteScalar().ToString();
        }
    }
}
