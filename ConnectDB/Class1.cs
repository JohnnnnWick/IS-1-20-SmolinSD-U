using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class Class1
    {
        string server = "chuc.caseum.ru";
        string port = "33333";
        string user = "st_1_20_27";
        string database = "is_1_20_st27_KURS";
        string password = "56251553";
        public string connStr;
        public string connection()
        {
            return connStr = $"хост={server};порт={port};пользовтаель={user};базаданных={database};пароль={password}";
        }
    }
}
