using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_SmolinSD_U
{
    public partial class Task2 : Form
    {
        //Создание класса Сonnection
        class Сonnection
        {
            //Создаем MySqlConnection, для подключения к БД
            public MySqlConnection conn()
            {
                string host = "10.90.12.110";
                string port = "33333";
                string user = "uchebka";
                string dd = "uchebka";
                string password = "uchebka";
                string connStr = $"server={host};port={port};user={user};database={dd};password={password};";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }
        public Task2()
        {
            InitializeComponent();
        }
        private void Task2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Создание экземпляра класса
            Сonnection con = new Сonnection();
            try
            {
                con.conn().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибочка");
            }
            finally
            {
                MessageBox.Show("а ну а ну давай");
                con.conn().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
