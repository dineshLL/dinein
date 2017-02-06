using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Test2.data
{
    class ConnectionManager
    {
        private static MySqlConnection connection = null;

        public static MySqlConnection getConnection()
        {
            try
            {
                if (connection == null)
                {
                    string connectionString = @"server=localhost;userid=rootpassword=;database=dinein";
                    connection = new MySqlConnection(connectionString);
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }

            return connection;
        }
    }
}
