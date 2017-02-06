namespace Test2
{
    partial class MainMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnLogin = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroTile1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile1.Location = new System.Drawing.Point(433, 62);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(235, 100);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Place Order";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(719, 449);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "NOT A CUSTOMER? LOGIN HERE";
            this.btnLogin.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(213, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PLEASE ENTER YOUR NAME HERE";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(66, 94);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(297, 23);
            this.txtCustomerName.TabIndex = 3;
            // 
            // metroTile2
            // 
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroTile2.Location = new System.Drawing.Point(674, 62);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(235, 100);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Call A Waiter";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile3.Location = new System.Drawing.Point(433, 169);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(235, 100);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "View  Order Queue";
            // 
            // metroTile4
            // 
            this.metroTile4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile4.Location = new System.Drawing.Point(674, 169);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(115, 100);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "Report Issues";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroTile1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(924, 475);
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}
