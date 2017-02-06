namespace Test2
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rootContainer = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // rootContainer
            // 
            this.rootContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rootContainer.HorizontalScrollbarBarColor = true;
            this.rootContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.rootContainer.HorizontalScrollbarSize = 10;
            this.rootContainer.Location = new System.Drawing.Point(23, 63);
            this.rootContainer.Name = "rootContainer";
            this.rootContainer.Size = new System.Drawing.Size(924, 494);
            this.rootContainer.TabIndex = 2;
            this.rootContainer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rootContainer.VerticalScrollbarBarColor = true;
            this.rootContainer.VerticalScrollbarHighlightOnWheel = false;
            this.rootContainer.VerticalScrollbarSize = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(970, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rootContainer);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Resizable = false;
            this.Text = "      WELCOME TO DINEIN";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel rootContainer;
        private MetroFramework.Controls.MetroLink btnBack;
    }
}

