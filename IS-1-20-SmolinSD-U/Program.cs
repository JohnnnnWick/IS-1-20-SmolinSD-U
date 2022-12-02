using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_SmolinSD_U
{
    class Сonnection // Класс
    {
        public MySqlConnection con() // скрока поключения
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
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
