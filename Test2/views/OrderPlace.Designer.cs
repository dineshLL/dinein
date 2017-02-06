namespace Test2
{
    partial class OrderPlace
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
            this.components = new System.ComponentModel.Container();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listFrom = new System.Windows.Forms.ListBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnOrderPlace = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comboFoodType = new MetroFramework.Controls.MetroComboBox();
            this.foodtypesDataTableBindingSource = new System.Windows.Forms.BindingSource(new System.ComponentModel.Container());
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboOrderType = new MetroFramework.Controls.MetroComboBox();
            this.listTo = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.foodtypesDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 0);
            this.lblCustomerName.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Food Type";
            // 
            // listFrom
            // 
            this.listFrom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFrom.FormattingEnabled = true;
            this.listFrom.ItemHeight = 25;
            this.listFrom.Location = new System.Drawing.Point(368, 83);
            this.listFrom.Name = "listFrom";
            this.listFrom.Size = new System.Drawing.Size(185, 354);
            this.listFrom.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(569, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(569, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOrderPlace
            // 
            this.btnOrderPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderPlace.Location = new System.Drawing.Point(110, 305);
            this.btnOrderPlace.Name = "btnOrderPlace";
            this.btnOrderPlace.Size = new System.Drawing.Size(195, 132);
            this.btnOrderPlace.TabIndex = 7;
            this.btnOrderPlace.Text = "PLACE ORDER";
            this.btnOrderPlace.Click += new System.EventHandler(this.btnOrderPlace_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(659, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Item";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(368, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Available Food Items";
            // 
            // comboFoodType
            // 
            this.comboFoodType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodtypesDataTableBindingSource, "food_type", true));
            this.comboFoodType.FormattingEnabled = true;
            this.comboFoodType.ItemHeight = 23;
            this.comboFoodType.Location = new System.Drawing.Point(110, 84);
            this.comboFoodType.Name = "comboFoodType";
            this.comboFoodType.Size = new System.Drawing.Size(195, 29);
            this.comboFoodType.TabIndex = 10;
            this.comboFoodType.SelectedIndexChanged += new System.EventHandler(this.comboFoodType_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(110, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Order Type";
            // 
            // comboOrderType
            // 
            this.comboOrderType.FormattingEnabled = true;
            this.comboOrderType.ItemHeight = 23;
            this.comboOrderType.Items.AddRange(new object[] {
            "Takeaway",
            "Delivery",
            "In house dinning"});
            this.comboOrderType.Location = new System.Drawing.Point(110, 169);
            this.comboOrderType.Name = "comboOrderType";
            this.comboOrderType.Size = new System.Drawing.Size(195, 29);
            this.comboOrderType.TabIndex = 12;
            // 
            // listTo
            // 
            this.listTo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTo.FormattingEnabled = true;
            this.listTo.ItemHeight = 25;
            this.listTo.Location = new System.Drawing.Point(659, 83);
            this.listTo.Name = "listTo";
            this.listTo.Size = new System.Drawing.Size(241, 354);
            this.listTo.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(833, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Qty";
            // 
            // OrderPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.comboOrderType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.comboFoodType);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnOrderPlace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listTo);
            this.Controls.Add(this.listFrom);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "OrderPlace";
            this.Size = new System.Drawing.Size(924, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listFrom;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnOrderPlace;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox comboFoodType;
        public System.Windows.Forms.BindingSource foodtypesDataTableBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboOrderType;
        private System.Windows.Forms.ListBox listTo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}
