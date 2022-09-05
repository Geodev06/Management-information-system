using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MIS_ENTREP
{
    class Database
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public void Connect()
        {
            con = new MySqlConnection("server=127.0.0.1; user = root; database=db_mis");
            con.Open();
        }
        public void Disconnect()
        {
            con.Dispose();
            con.Close();
        }
    }
}
