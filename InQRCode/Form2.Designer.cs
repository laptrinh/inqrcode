namespace InQRCode
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabView1 = new FPT.GPLX.Controls.TabView.TabView();
            this.xpPanel1 = new FPT.GPLX.Controls.XPPanel.XPPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabView1
            // 
            this.tabView1.AllowAddSameTab = true;
            this.tabView1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabView1.Location = new System.Drawing.Point(187, 1);
            this.tabView1.Name = "tabView1";
            this.tabView1.Size = new System.Drawing.Size(516, 433);
            this.tabView1.TabIndex = 0;
            this.tabView1.Text = "tabView1";
            // 
            // xpPanel1
            // 
            this.xpPanel1.AllowCollapse = true;
            this.xpPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.xpPanel1.Caption = "Caption";
            this.xpPanel1.Icon = ((System.Drawing.Image)(resources.GetObject("xpPanel1.Icon")));
            this.xpPanel1.Location = new System.Drawing.Point(12, 24);
            this.xpPanel1.Name = "xpPanel1";
            this.xpPanel1.ShowIcon = true;
            this.xpPanel1.ShowStatus = FPT.GPLX.Controls.XPPanel.XPPanel.PanelStatus.ShowPanel;
            this.xpPanel1.Size = new System.Drawing.Size(200, 100);
            this.xpPanel1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 435);
            this.Controls.Add(this.xpPanel1);
            this.Controls.Add(this.tabView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tabView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FPT.GPLX.Controls.TabView.TabView tabView1;
        private FPT.GPLX.Controls.XPPanel.XPPanel xpPanel1;
    }
}