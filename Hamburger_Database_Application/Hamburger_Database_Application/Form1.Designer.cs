namespace Hamburger_Database_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            createOrderToolStripMenuItem = new ToolStripMenuItem();
            orderDetailsToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            foodPanelToolStripMenuItem = new ToolStripMenuItem();
            extraPanelToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderManagementToolStripMenuItem, productManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1015, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createOrderToolStripMenuItem, orderDetailsToolStripMenuItem });
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(153, 24);
            orderManagementToolStripMenuItem.Text = "Order Management";
            // 
            // createOrderToolStripMenuItem
            // 
            createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            createOrderToolStripMenuItem.Size = new Size(180, 26);
            createOrderToolStripMenuItem.Text = "Create Order";
            createOrderToolStripMenuItem.Click += createOrderToolStripMenuItem_Click;
            // 
            // orderDetailsToolStripMenuItem
            // 
            orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            orderDetailsToolStripMenuItem.Size = new Size(180, 26);
            orderDetailsToolStripMenuItem.Text = "Order Details";
            orderDetailsToolStripMenuItem.Click += orderDetailsToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foodPanelToolStripMenuItem, extraPanelToolStripMenuItem });
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(166, 24);
            productManagementToolStripMenuItem.Text = "Product Management";
            // 
            // foodPanelToolStripMenuItem
            // 
            foodPanelToolStripMenuItem.Name = "foodPanelToolStripMenuItem";
            foodPanelToolStripMenuItem.Size = new Size(165, 26);
            foodPanelToolStripMenuItem.Text = "Food Panel";
            foodPanelToolStripMenuItem.Click += foodPanelToolStripMenuItem_Click;
            // 
            // extraPanelToolStripMenuItem
            // 
            extraPanelToolStripMenuItem.Name = "extraPanelToolStripMenuItem";
            extraPanelToolStripMenuItem.Size = new Size(165, 26);
            extraPanelToolStripMenuItem.Text = "Extra Panel";
            extraPanelToolStripMenuItem.Click += extraPanelToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 540);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private ToolStripMenuItem createOrderToolStripMenuItem;
        private ToolStripMenuItem orderDetailsToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem foodPanelToolStripMenuItem;
        private ToolStripMenuItem extraPanelToolStripMenuItem;
    }
}