using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.models;

namespace Test2
{
    public partial class QuantityModel : MetroFramework.Forms.MetroForm
    {
        private Food food = null;

        public QuantityModel(Food food)
        {
            InitializeComponent();
            this.food = food;
            txtQuantity.Text = "1";
        }

        private void QuantityModel_Load(object sender, EventArgs e)
        {
            this.Text = food.Name;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.food.Qty = Convert.ToInt16(txtQuantity.Text);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid amount...!!!");
            }
        }
    }
}
