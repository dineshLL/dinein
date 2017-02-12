using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class MainMenu : MetroFramework.Controls.MetroUserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text == "")
            {
                MessageBox.Show("Can you please enter your name...!!");
            } else
            {
                if(!Home.Instance.RootContainer.Controls.ContainsKey("OrderPlace"))
                            {   
                                OrderPlace op = new OrderPlace(txtCustomerName.Text);
                                op.Dock = DockStyle.Fill;
                                Home.Instance.RootContainer.Controls.Add(op);
                            }

                            Home.Instance.RootContainer.Controls["OrderPlace"].BringToFront();
                            Home.Instance.BtnBack.Visible = true;
            }
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }
    }
}
