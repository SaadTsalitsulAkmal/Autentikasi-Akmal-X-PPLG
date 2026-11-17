using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSql()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}
