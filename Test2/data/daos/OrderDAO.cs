using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.models;
using System.Data;

namespace Test2.data.daos
{
    class OrderDAO
    {
        public bool saveOrder(Order order)
        {
            MySqlConnection dbConn = ConnectionManager.getConnection();
            MySqlTransaction transaction = null;
            string query = "INSERT INTO `orders`(`order_type`, `customer_name`) VALUES" +
                "(@order_type, @customer_name)";
            string insertOrderItems = "INSERT INTO `order_items`(`order_id`, `food_id`, `qty`, `price`) VALUES "+
                "(@order_id, @food_id, @qty, @price)";
            bool result = false;

            try
            {
                dbConn.Open();
                transaction = dbConn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@order_type", order.OrderType);
                cmd.Parameters.AddWithValue("@customer_name", order.CustomerName);

                cmd.ExecuteNonQuery();

                long insertId = cmd.LastInsertedId;

                foreach(Food item in order.Items)
                {
                    MySqlCommand itemInsertCmd = new MySqlCommand(insertOrderItems, dbConn);
                    itemInsertCmd.Transaction = transaction;
                    itemInsertCmd.Prepare();

                    itemInsertCmd.Parameters.AddWithValue("@order_id", insertId);
                    itemInsertCmd.Parameters.AddWithValue("@food_id", item.FoodId);
                    itemInsertCmd.Parameters.AddWithValue("@qty", item.Qty);
                    itemInsertCmd.Parameters.AddWithValue("@price", item.Price);

                    itemInsertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                result = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                transaction.Rollback();
                result = false;
            }
            finally
            {
                dbConn.Close();
            }

            return result;
        }

        public List<Order> getOrdersInState(string state)
        {
            MySqlConnection dbConn = ConnectionManager.getConnection();
            List<Order> orders = new List<Order>();
            string query = "SELECT `order_id`, `order_type`, `customer_name`, `state`, `time_stamp` FROM `orders` WHERE `state` = " +
                "@state ORDER BY `time_stamp`";

            try
            {
                dbConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@state", state);

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Order order = new Order(reader.GetString(3));
                    order.OrderId = reader.GetInt16(0);
                    order.OrderType = reader.GetString(1);
                    order.CustomerName = reader.GetString(2);

                    orders.Add(order);
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

            return orders;
        }

        public DataSet getOrderItems(int orderId)
        {
            string query = "SELECT foods.name as Item, order_items.qty as Quantity FROM foods foods, order_items order_items WHERE foods.food_id = order_items.food_id AND order_items.order_id = " + orderId;
            MySqlConnection dbConn = ConnectionManager.getConnection();
            DataSet ds = new DataSet();
            
            try
            {
                dbConn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbConn);
                da.Fill(ds, "order_items");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                dbConn.Close();
            }

            return ds;
        }

        public bool changeOrderStateTo(string state, Order order)
        {
            string query = "UPDATE `orders` SET `state`= @state  WHERE `order_id` = @orderId";
            MySqlConnection dbConn = ConnectionManager.getConnection();
            bool result = false;

            try
            {
                dbConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@orderId", order.OrderId);

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
            return result;
        }
    }
}
