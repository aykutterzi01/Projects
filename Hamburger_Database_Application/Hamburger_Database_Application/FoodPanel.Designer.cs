namespace Hamburger_Database_Application
{
    partial class FoodPanel
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
            groupBox1 = new GroupBox();
            btnFoodDelete = new Button();
            btnFoodUpdate = new Button();
            btnFoodAdd = new Button();
            nmrcUdFoodPrice = new NumericUpDown();
            label2 = new Label();
            txtBoxFoodName = new TextBox();
            label1 = new Label();
            dgvFoods = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdFoodPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFoodDelete);
            groupBox1.Controls.Add(btnFoodUpdate);
            groupBox1.Controls.Add(btnFoodAdd);
            groupBox1.Controls.Add(nmrcUdFoodPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBoxFoodName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "FOOD INFORMATION";
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.Location = new Point(187, 142);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(88, 29);
            btnFoodDelete.TabIndex = 6;
            btnFoodDelete.Text = "DELETE";
            btnFoodDelete.UseVisualStyleBackColor = true;
            btnFoodDelete.Click += btnFoodDelete_Click;
            // 
            // btnFoodUpdate
            // 
            btnFoodUpdate.Location = new Point(83, 142);
            btnFoodUpdate.Name = "btnFoodUpdate";
            btnFoodUpdate.Size = new Size(88, 29);
            btnFoodUpdate.TabIndex = 5;
            btnFoodUpdate.Text = "UPDATE";
            btnFoodUpdate.UseVisualStyleBackColor = true;
            btnFoodUpdate.Click += btnFoodUpdate_Click;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.Location = new Point(7, 142);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(61, 29);
            btnFoodAdd.TabIndex = 4;
            btnFoodAdd.Text = "ADD";
            btnFoodAdd.UseVisualStyleBackColor = true;
            btnFoodAdd.Click += btnFoodAdd_Click;
            // 
            // nmrcUdFoodPrice
            // 
            nmrcUdFoodPrice.Location = new Point(115, 86);
            nmrcUdFoodPrice.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nmrcUdFoodPrice.Name = "nmrcUdFoodPrice";
            nmrcUdFoodPrice.Size = new Size(160, 27);
            nmrcUdFoodPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // txtBoxFoodName
            // 
            txtBoxFoodName.Location = new Point(115, 39);
            txtBoxFoodName.Name = "txtBoxFoodName";
            txtBoxFoodName.Size = new Size(160, 27);
            txtBoxFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Food Name:";
            // 
            // dgvFoods
            // 
            dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Location = new Point(315, 76);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.RowTemplate.Height = 29;
            dgvFoods.Size = new Size(726, 287);
            dgvFoods.TabIndex = 1;
            dgvFoods.CellClick += dgvFoods_CellClick;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 450);
            Controls.Add(dgvFoods);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FoodPanel";
            Text = "FoodPanel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdFoodPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nmrcUdFoodPrice;
        private Label label2;
        private TextBox txtBoxFoodName;
        private Label label1;
        private Button btnFoodDelete;
        private Button btnFoodUpdate;
        private Button btnFoodAdd;
        private DataGridView dgvFoods;
    }
}