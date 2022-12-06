using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_SmolinSD_U
{
    class СonnectionSQL // Класс
    {
        string server = "chuc.caseum.ru";
        //string server = "10.90.12.110";
        string port = "33333";
        string user = "st_1_20_27";
        string database = "is_1_20_st27_KURS";
        string password = "56251553";
        public string connStr;
        public string Connectreturn()
        {
            return connStr = $"host={server};port={port};user={user};database={database};password={password}";
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
