using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekib_donemsonuodv.DAL
{
    class dbConnection
    {
        public MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost; Database=131730026proje; uid=bilalalptekin;pwd=123456; convert zero datetime=True;");
            connection.Open();
            return connection;


        }
    }
}
