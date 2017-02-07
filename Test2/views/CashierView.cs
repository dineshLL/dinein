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
    public partial class CashierView : UserControl
    {
        public CashierView()
        {
            InitializeComponent();
            listPendingOrders.ValueMember = "orderName";
            foreach(Order order in new OrderDAO().getOrdersInState("CA_PENDING"))
            {
                order.OrderName = "Order " + order.OrderId + "\t             " + order.CustomerName;
                listPendingOrders.Items.Add(order);
            }
        }
    }
}
