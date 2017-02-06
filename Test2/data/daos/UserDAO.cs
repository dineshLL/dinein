using Dinein.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.data;

namespace Dinein.data.daos
{
    class UserDAO
    {
        public User getUser(string username)
        {
            User user = null;
            string query = "SELECT `user_id`, `name`, `user_name`, `pwd`, `role` FROM `users` WHERE `user_name` = @username";
            MySqlConnection dbConn = ConnectionManager.getConnection();
            
            try
            {
                dbConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    user = new User();
                    user.UserId = reader.GetInt16(0);
                    user.Name = reader.GetString(1);
                    user.Username = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    user.Role = reader.GetString(4);
                }
            } 
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }

            return user;
        }
    }
}
