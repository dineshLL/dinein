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
using System.Diagnostics;

namespace Test2
{
    public partial class KitchenUserView : UserControl
    {
        private Order currentOrder = null;

        public KitchenUserView()
        {
            InitializeComponent();
            //PendingItem view = new PendingItem(new);
            //view.Dock = DockStyle.Fill;
            //panel.Controls.Add(view);
            //panel.Controls[0].BringToFront();

            listPending.ValueMember = "orderName";
            loadPendingOrders();
            
        }

        private void loadPendingOrders()
        {
            listPending.Items.Clear();
            foreach (Order order in new OrderDAO().getOrdersInState("KM_PENDING"))
            {
                order.OrderName = "Order " + order.OrderId;
                listPending.Items.Add(order);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPendingOrders();
        }

        private void listPending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPending.SelectedItems.Count > 0)
            {
                panel.Controls.Clear();
                PendingItem view = new PendingItem(listPending.SelectedItem as Order);
                view.Dock = DockStyle.Fill;
                panel.Controls.Add(view);
                panel.Controls[0].BringToFront();
                Home.Instance.BtnBack.Visible = true;

                this.currentOrder = listPending.SelectedItem as Order;
            }
        }

        private void btnAccecpt_Click(object sender, EventArgs e)
        {
            if(new OrderDAO().changeOrderStateTo("KM_APPROVED", this.currentOrder))
            {
                loadPendingOrders();
                MessageBox.Show("ORDER APPROVED...!!!");
            }
            else
            {
                MessageBox.Show("SOMETHIG WENT WRONG. PLEASE TRY AGAIN...!!!");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (new OrderDAO().changeOrderStateTo("KM_REJECTED", this.currentOrder))
            {
                loadPendingOrders();
                MessageBox.Show("ORDER REJECTED...!!!");
            }
            else
            {
                MessageBox.Show("SOMETHIG WENT WRONG. PLEASE TRY AGAIN...!!!");
            }
        }
    }
}
