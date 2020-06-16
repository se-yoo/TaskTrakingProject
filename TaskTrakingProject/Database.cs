using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrakingProject
{
    public class Database
    {
        private static string connection = "Server=127.0.0.1;Port=3306;Database=task_traking_project;uid=root;Pwd=1234;CharSet=utf8;";

        public static string getConnection()
        {
            return connection;
        }
    }
}
