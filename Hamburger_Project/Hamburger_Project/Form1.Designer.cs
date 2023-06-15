namespace Hamburger_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMenuPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeExtraMaterialPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderManagementToolStripMenuItem,
            this.productManagementToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // orderManagementToolStripMenuItem
            // 
            this.orderManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            resources.ApplyResources(this.orderManagementToolStripMenuItem, "orderManagementToolStripMenuItem");
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            resources.ApplyResources(this.createOrderToolStripMenuItem, "createOrderToolStripMenuItem");
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            resources.ApplyResources(this.orderDetailsToolStripMenuItem, "orderDetailsToolStripMenuItem");
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuToolStripMenuItem,
            this.addExtraMaterialToolStripMenuItem,
            this.changeMenuPriceToolStripMenuItem,
            this.changeExtraMaterialPriceToolStripMenuItem});
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            resources.ApplyResources(this.productManagementToolStripMenuItem, "productManagementToolStripMenuItem");
            // 
            // addMenuToolStripMenuItem
            // 
            this.addMenuToolStripMenuItem.Name = "addMenuToolStripMenuItem";
            resources.ApplyResources(this.addMenuToolStripMenuItem, "addMenuToolStripMenuItem");
            this.addMenuToolStripMenuItem.Click += new System.EventHandler(this.addMenuToolStripMenuItem_Click);
            // 
            // addExtraMaterialToolStripMenuItem
            // 
            this.addExtraMaterialToolStripMenuItem.Name = "addExtraMaterialToolStripMenuItem";
            resources.ApplyResources(this.addExtraMaterialToolStripMenuItem, "addExtraMaterialToolStripMenuItem");
            this.addExtraMaterialToolStripMenuItem.Click += new System.EventHandler(this.addExtraMaterialToolStripMenuItem_Click);
            // 
            // changeMenuPriceToolStripMenuItem
            // 
            this.changeMenuPriceToolStripMenuItem.Name = "changeMenuPriceToolStripMenuItem";
            resources.ApplyResources(this.changeMenuPriceToolStripMenuItem, "changeMenuPriceToolStripMenuItem");
            this.changeMenuPriceToolStripMenuItem.Click += new System.EventHandler(this.changeMenuPriceToolStripMenuItem_Click);
            // 
            // changeExtraMaterialPriceToolStripMenuItem
            // 
            this.changeExtraMaterialPriceToolStripMenuItem.Name = "changeExtraMaterialPriceToolStripMenuItem";
            resources.ApplyResources(this.changeExtraMaterialPriceToolStripMenuItem, "changeExtraMaterialPriceToolStripMenuItem");
            this.changeExtraMaterialPriceToolStripMenuItem.Click += new System.EventHandler(this.changeExtraMaterialPriceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMenuPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeExtraMaterialPriceToolStripMenuItem;
    }
}

