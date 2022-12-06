using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1_20_SmolinSD_U
{
    public class Class1
    {
        string server = "chuc.caseum.ru";
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
}
