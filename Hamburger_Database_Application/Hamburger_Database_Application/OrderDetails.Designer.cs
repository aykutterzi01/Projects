namespace Hamburger_Database_Application
{
    partial class OrderDetails
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
            label1 = new Label();
            dgvAllOrders = new DataGridView();
            Revenue = new GroupBox();
            lblRevenue = new Label();
            lblQuantity = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblExtraIngredientRevenue = new Label();
            lblTotalNumberOfProductsSold = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllOrders).BeginInit();
            Revenue.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "ALL ORDERS";
            // 
            // dgvAllOrders
            // 
            dgvAllOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllOrders.Location = new Point(26, 72);
            dgvAllOrders.Name = "dgvAllOrders";
            dgvAllOrders.RowHeadersWidth = 51;
            dgvAllOrders.RowTemplate.Height = 29;
            dgvAllOrders.Size = new Size(624, 366);
            dgvAllOrders.TabIndex = 2;
            // 
            // Revenue
            // 
            Revenue.Controls.Add(lblRevenue);
            Revenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Revenue.Location = new Point(682, 71);
            Revenue.Name = "Revenue";
            Revenue.Size = new Size(250, 76);
            Revenue.TabIndex = 3;
            Revenue.TabStop = false;
            Revenue.Text = "Revenue";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRevenue.ForeColor = Color.Red;
            lblRevenue.Location = new Point(15, 34);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(40, 20);
            lblRevenue.TabIndex = 11;
            lblRevenue.Text = "0,00";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Red;
            lblQuantity.Location = new Point(15, 34);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(40, 20);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "0,00";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(682, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 76);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Number of Orders";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblExtraIngredientRevenue);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(682, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 76);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extra Ingredient Revenue";
            // 
            // lblExtraIngredientRevenue
            // 
            lblExtraIngredientRevenue.AutoSize = true;
            lblExtraIngredientRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExtraIngredientRevenue.ForeColor = Color.Red;
            lblExtraIngredientRevenue.Location = new Point(15, 34);
            lblExtraIngredientRevenue.Name = "lblExtraIngredientRevenue";
            lblExtraIngredientRevenue.Size = new Size(40, 20);
            lblExtraIngredientRevenue.TabIndex = 11;
            lblExtraIngredientRevenue.Text = "0,00";
            // 
            // lblTotalNumberOfProductsSold
            // 
            lblTotalNumberOfProductsSold.AutoSize = true;
            lblTotalNumberOfProductsSold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalNumberOfProductsSold.ForeColor = Color.Red;
            lblTotalNumberOfProductsSold.Location = new Point(15, 34);
            lblTotalNumberOfProductsSold.Name = "lblTotalNumberOfProductsSold";
            lblTotalNumberOfProductsSold.Size = new Size(40, 20);
            lblTotalNumberOfProductsSold.TabIndex = 11;
            lblTotalNumberOfProductsSold.Text = "0,00";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalNumberOfProductsSold);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(682, 349);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 76);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total Number of Products Sold";
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Revenue);
            Controls.Add(dgvAllOrders);
            Controls.Add(label1);
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dgvAllOrders).EndInit();
            Revenue.ResumeLayout(false);
            Revenue.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAllOrders;
        private GroupBox Revenue;
        private Label lblRevenue;
        private Label lblQuantity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblExtraIngredientRevenue;
        private Label lblTotalNumberOfProductsSold;
        private GroupBox groupBox3;
    }
}