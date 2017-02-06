using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.models;
using Test2.data.daos;

namespace Test2
{
    public partial class PendingItem : UserControl
    {
        private Order order;
        public PendingItem(Order order)
        {
            InitializeComponent();
            lblCustomerName.Text = order.CustomerName;
            lblOrderId.Text = Convert.ToString(order.OrderId);
            lblOrderType.Text = order.OrderType;
            this.order = order;

            loadOrderItems();
        }

        private void PendingItem_Load(object sender, EventArgs e)
        {
            
        }

        private void loadOrderItems()
        {
            dg.DataSource = new OrderDAO().getOrderItems(order.OrderId).Tables["order_items"];
            dg.Columns[0].Width = 226;
        }
        
    }
}
