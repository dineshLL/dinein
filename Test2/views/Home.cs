using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        static Home instance;

        public static Home Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Home();
                }
                return instance;
            }
        }

        public MetroFramework.Controls.MetroPanel RootContainer
        {
            get { return this.rootContainer; }
            set { this.rootContainer = value; }
        }

        public MetroFramework.Controls.MetroLink BtnBack
        {
            get { return this.btnBack; }
            set { this.btnBack = value; }
        }

        public Home()
        {
            InitializeComponent();
            try
            {
                btnBack.Image = Dinein.Properties.Resources.backBtnImage;
                btnBack.ImageAlign = ContentAlignment.MiddleCenter;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        /**
         * 
         * Home panel load event
         * */
        private void Home_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            instance = this;
            MainMenu menu = new MainMenu();
            menu.Dock = DockStyle.Fill;
            rootContainer.Controls.Add(menu);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.rootContainer.Controls["MainMenu"].BringToFront();
            this.btnBack.Visible = false;
        }
    }
}
