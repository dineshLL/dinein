namespace Test2
{
    partial class KitchenUserView
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.btnAccecpt = new MetroFramework.Controls.MetroButton();
            this.btnReject = new MetroFramework.Controls.MetroButton();
            this.listPending = new System.Windows.Forms.ListBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "PENDING ORDERS";
            // 
            // panel
            // 
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(351, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(423, 421);
            this.panel.TabIndex = 2;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // btnAccecpt
            // 
            this.btnAccecpt.Location = new System.Drawing.Point(780, 37);
            this.btnAccecpt.Name = "btnAccecpt";
            this.btnAccecpt.Size = new System.Drawing.Size(140, 70);
            this.btnAccecpt.TabIndex = 3;
            this.btnAccecpt.Text = "ACCECPT";
            this.btnAccecpt.Click += new System.EventHandler(this.btnAccecpt_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(780, 112);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(140, 70);
            this.btnReject.Style = MetroFramework.MetroColorStyle.Red;
            this.btnReject.TabIndex = 4;
            this.btnReject.Text = "REJECT";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // listPending
            // 
            this.listPending.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPending.FormattingEnabled = true;
            this.listPending.ItemHeight = 32;
            this.listPending.Location = new System.Drawing.Point(4, 38);
            this.listPending.Name = "listPending";
            this.listPending.Size = new System.Drawing.Size(320, 420);
            this.listPending.TabIndex = 5;
            this.listPending.SelectedIndexChanged += new System.EventHandler(this.listPending_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(780, 413);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRESH ORDERS";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // KitchenUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listPending);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccecpt);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "KitchenUserView";
            this.Size = new System.Drawing.Size(924, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroButton btnAccecpt;
        private MetroFramework.Controls.MetroButton btnReject;
        private System.Windows.Forms.ListBox listPending;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}
