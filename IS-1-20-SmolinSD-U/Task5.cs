using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_SmolinSD_U
{
    public partial class Task5 : Form
    {

        public Task5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_27;database=is_1_20_st27_KURS;password=56251553;";
        MySqlConnection conn;

        private void Task5_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command = new MySqlCommand($"INSERT INTO t_Uchebka_Smolin (`fioStud`, `datetimeStud`) VALUES (@fio, @datetime);", conn);

                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = Text;
                command.Parameters.Add("@datetime", MySqlDbType.VarChar).Value = Text;

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
