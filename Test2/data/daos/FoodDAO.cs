using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.models;

namespace Test2.data.daos
{
    class FoodDAO
    {
        public List<String> getFoodTypes()
        {
            String query = "SELECT type FROM food_types";
            List<String> data = new List<string>();
            MySqlConnection dbConn = null;

            try
            {
                dbConn = ConnectionManager.getConnection();
                dbConn.Open();
                MySqlDataReader rs = new MySqlCommand(query, dbConn).ExecuteReader();

                while(rs.Read())
                {
                    data.Add(rs.GetString(0));
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                dbConn.Close();
            }

            return data;
        }

        public List<Food> getFoodsOfType(string type)
        {
            string query = "SELECT `food_id`, `type`, `name`, `price` FROM foods WHERE type = (SELECT type_id FROM food_types WHERE type = @type)";
            MySqlConnection dbConn = null;
            List<Food> foods = new List<Food>();

            try
            {
                dbConn = ConnectionManager.getConnection();
                dbConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@type", type);

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Food food = new Food();
                    food.FoodId = reader.GetInt16(0);
                    food.Type = reader.GetInt16(1);
                    food.Name = reader.GetString(2);
                    food.Price = reader.GetDouble(3);

                    foods.Add(food);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                dbConn.Close();
            }

            return foods;
        }
    }
}
