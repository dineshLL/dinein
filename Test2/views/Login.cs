using Dinein.controllers;
using Dinein.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!txtUserName.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                User user = UserController.isUserAuthorized(txtUserName.Text, txtPassword.Text);
                if (user != null)
                {
                    switch (user.Role)
                    {
                        case "KM":
                            {
                                if (!Home.Instance.Controls.ContainsKey("KitchenUserView"))
                                {
                                    KitchenUserView view = new KitchenUserView();
                                    view.Dock = DockStyle.Fill;
                                    Home.Instance.RootContainer.Controls.Add(view);
                                }

                                Home.Instance.RootContainer.Controls["KitchenUserView"].BringToFront();
                                Home.Instance.BtnBack.Visible = true;
                                this.Close();
                                break;
                            }
                        case "CA":
                            {
                                if (!Home.Instance.Controls.ContainsKey("CashierView"))
                                {
                                    CashierView view = new CashierView();
                                    view.Dock = DockStyle.Fill;
                                    Home.Instance.RootContainer.Controls.Add(view);
                                }

                                Home.Instance.RootContainer.Controls["CashierView"].BringToFront();
                                Home.Instance.BtnBack.Visible = true;
                                this.Close();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("NOT A VALID USER. PLEASE TRY AGAIN!!!");
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("SYSTEM CAN NOT AUTHENTICATE YOU!! PLEASE RE-CHECK YOUR DETAILS");
                }

            }
            else
            {
                MessageBox.Show("PLEASE ENTER REQUIRED DETAILS...!");
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine(e.KeyChar);
        }
    }
}
