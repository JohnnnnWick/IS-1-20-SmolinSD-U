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
    public partial class Task3 : Form
    {
        MySqlConnection conn;
        Class1 connect;
        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            connect = new Class1();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT is_reception, doctor, id_doctor, fio_doctor FROM Reception INNER JOIN Doctors ON is_reception = id_doctor";
                dataGridView1.Columns.Add("is_reception", "ид Клиента");
                dataGridView1.Columns["is_reception"].Width = 100;

                dataGridView1.Columns.Add("doctor", "Доктор");
                dataGridView1.Columns["doctor"].Width = 100;

                dataGridView1.Columns.Add("id_doctor", "ид Доктора");
                dataGridView1.Columns["id_doctor"].Width = 100;

                dataGridView1.Columns.Add("fio_doctor", "фио доктора");
                dataGridView1.Columns["fio_doctor"].Width = 100;

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["is_reception"].ToString(), reader["doctor"].ToString(), reader["id_doctor"].ToString(), reader["fio_doctor"].ToString());
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
