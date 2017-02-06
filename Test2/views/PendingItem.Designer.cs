namespace Test2
{
    partial class PendingItem
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
            this.sdfsdf = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Customer = new MetroFramework.Controls.MetroLabel();
            this.lblOrderType = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblOrderId = new MetroFramework.Controls.MetroLabel();
            this.ime = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // sdfsdf
            // 
            this.sdfsdf.AutoSize = true;
            this.sdfsdf.Location = new System.Drawing.Point(36, 17);
            this.sdfsdf.Name = "sdfsdf";
            this.sdfsdf.Size = new System.Drawing.Size(61, 19);
            this.sdfsdf.TabIndex = 0;
            this.sdfsdf.Text = "Order ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Order Type";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(36, 68);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(66, 19);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "Customer";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(130, 42);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(0, 0);
            this.lblOrderType.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(130, 67);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 0);
            this.lblCustomerName.TabIndex = 4;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(130, 17);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 0);
            this.lblOrderId.TabIndex = 5;
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(36, 94);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(38, 19);
            this.ime.TabIndex = 6;
            this.ime.Text = "Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(130, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 7;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dg.Location = new System.Drawing.Point(36, 172);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.ShowEditingIcon = false;
            this.dg.Size = new System.Drawing.Size(369, 250);
            this.dg.TabIndex = 8;
            // 
            // PendingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.sdfsdf);
            this.Name = "PendingItem";
            this.Size = new System.Drawing.Size(423, 421);
            this.Load += new System.EventHandler(this.PendingItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel sdfsdf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Customer;
        private MetroFramework.Controls.MetroLabel lblOrderType;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel lblOrderId;
        private MetroFramework.Controls.MetroLabel ime;
        private MetroFramework.Controls.MetroLabel lblTime;
        private System.Windows.Forms.DataGridView dg;
    }
}
