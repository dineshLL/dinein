using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Test2.data.daos;
using Test2.models;

namespace Test2
{
    public partial class OrderPlace : MetroFramework.Controls.MetroUserControl
    {
        private string customerName;
        public OrderPlace(String customerName)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.lblCustomerName.Text = "Hi " + customerName + ". please place the order";
            //loadFoodTypes();
            foreach(String item in new FoodDAO().getFoodTypes())
            {
                comboFoodType.Items.Add(item);
            }
            comboFoodType.SelectedIndex = 0;
            comboOrderType.SelectedIndex = 2;

            //configuring the lists
            listFrom.ValueMember = "name";
            listTo.ValueMember = "name";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listFrom.SelectedItems.Count > 0)
            {
                Food food = listFrom.SelectedItem as Food;
                QuantityModel model = new QuantityModel(food);
                model.ShowDialog();
                food.Name += "\t\t" + food.Qty;
                listTo.Items.Add(food); 
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listTo.SelectedItems.Count > 0)
            {
                listTo.Items.Remove(listTo.SelectedItem);
            }
        }

        private void btnOrderPlace_Click(object sender, EventArgs e)
        {
            Order order = new Order(comboOrderType.SelectedItem.ToString());

            order.CustomerName = this.customerName;
            foreach(Food item in listTo.Items)
            {
                order.Items.Add(item);
            }
            bool saveSuccessful = new OrderDAO().saveOrder(order);

            if (saveSuccessful) MessageBox.Show("ORDER SAVED SUCCESSFULLY...!!");
            else MessageBox.Show("ERROR OCCURED");
        }

        private void comboFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> foods = new FoodDAO().getFoodsOfType(comboFoodType.GetItemText(comboFoodType.SelectedItem));

            listFrom.Items.Clear();
            foreach(Food food in foods)
            {
                listFrom.Items.Add(food);
            }
        }

        private void loadFoodsOftype(String foodType)
        {
            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    string strSql = "SELECT food_name FROM foods WHERE food_type = '"+ foodType +"'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    listFrom.DataSource = ds.Tables[0];
                    listFrom.DisplayMember = "food_name";
                    listFrom.ValueMember = "food_name";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
