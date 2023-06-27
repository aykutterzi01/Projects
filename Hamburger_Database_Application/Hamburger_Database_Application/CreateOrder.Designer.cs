namespace Hamburger_Database_Application
{
    partial class CreateOrder
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
            label2 = new Label();
            dgvFoodList = new DataGridView();
            dgvExtraList = new DataGridView();
            groupBox1 = new GroupBox();
            rdBtnLarge = new RadioButton();
            rdBtnMedium = new RadioButton();
            rdBtnSmall = new RadioButton();
            label3 = new Label();
            nmrcUdQuantity = new NumericUpDown();
            btnAddOrder = new Button();
            dgvOrderList = new DataGridView();
            label4 = new Label();
            lblTotalAmount = new Label();
            btnFinishOrder = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtraList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(548, 13);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 1;
            label2.Text = "CHOOSE YOUR EXTRA";
            // 
            // dgvFoodList
            // 
            dgvFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodList.Location = new Point(23, 49);
            dgvFoodList.MultiSelect = false;
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.RowHeadersWidth = 51;
            dgvFoodList.RowTemplate.Height = 29;
            dgvFoodList.Size = new Size(455, 152);
            dgvFoodList.TabIndex = 2;
            dgvFoodList.CellClick += dgvFoodList_CellClick;
            // 
            // dgvExtraList
            // 
            dgvExtraList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvExtraList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtraList.Location = new Point(548, 47);
            dgvExtraList.Name = "dgvExtraList";
            dgvExtraList.RowHeadersWidth = 51;
            dgvExtraList.RowTemplate.Height = 29;
            dgvExtraList.Size = new Size(463, 154);
            dgvExtraList.TabIndex = 3;
            dgvExtraList.SelectionChanged += dgvExtraList_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdBtnLarge);
            groupBox1.Controls.Add(rdBtnMedium);
            groupBox1.Controls.Add(rdBtnSmall);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 59);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHOOSE THE SIZE";
            // 
            // rdBtnLarge
            // 
            rdBtnLarge.AutoSize = true;
            rdBtnLarge.Location = new Point(223, 26);
            rdBtnLarge.Name = "rdBtnLarge";
            rdBtnLarge.Size = new Size(69, 24);
            rdBtnLarge.TabIndex = 6;
            rdBtnLarge.TabStop = true;
            rdBtnLarge.Text = "Large";
            rdBtnLarge.UseVisualStyleBackColor = true;
            // 
            // rdBtnMedium
            // 
            rdBtnMedium.AutoSize = true;
            rdBtnMedium.Location = new Point(108, 26);
            rdBtnMedium.Name = "rdBtnMedium";
            rdBtnMedium.Size = new Size(88, 24);
            rdBtnMedium.TabIndex = 5;
            rdBtnMedium.TabStop = true;
            rdBtnMedium.Text = "Medium";
            rdBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdBtnSmall
            // 
            rdBtnSmall.AutoSize = true;
            rdBtnSmall.Location = new Point(11, 26);
            rdBtnSmall.Name = "rdBtnSmall";
            rdBtnSmall.Size = new Size(68, 24);
            rdBtnSmall.TabIndex = 0;
            rdBtnSmall.TabStop = true;
            rdBtnSmall.Text = "Small";
            rdBtnSmall.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(369, 249);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "QUANTITY:";
            // 
            // nmrcUdQuantity
            // 
            nmrcUdQuantity.Location = new Point(473, 249);
            nmrcUdQuantity.Name = "nmrcUdQuantity";
            nmrcUdQuantity.Size = new Size(150, 27);
            nmrcUdQuantity.TabIndex = 6;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddOrder.Location = new Point(709, 230);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(302, 52);
            btnAddOrder.TabIndex = 7;
            btnAddOrder.Text = "ADD ORDER";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(24, 306);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(768, 188);
            dgvOrderList.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(826, 306);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 9;
            label4.Text = "TOTAL AMOUNT:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.Location = new Point(831, 344);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(40, 20);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "0,00";
            // 
            // btnFinishOrder
            // 
            btnFinishOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishOrder.Location = new Point(826, 393);
            btnFinishOrder.Name = "btnFinishOrder";
            btnFinishOrder.Size = new Size(185, 99);
            btnFinishOrder.TabIndex = 11;
            btnFinishOrder.Text = "FINISH ORDER";
            btnFinishOrder.UseVisualStyleBackColor = true;
            btnFinishOrder.Click += btnFinishOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "CHOOSE YOUR FOOD";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 517);
            Controls.Add(btnFinishOrder);
            Controls.Add(lblTotalAmount);
            Controls.Add(label4);
            Controls.Add(dgvOrderList);
            Controls.Add(btnAddOrder);
            Controls.Add(nmrcUdQuantity);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dgvExtraList);
            Controls.Add(dgvFoodList);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateOrder";
            Text = "CreateOrder";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtraList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dgvFoodList;
        private DataGridView dgvExtraList;
        private GroupBox groupBox1;
        private RadioButton rdBtnLarge;
        private RadioButton rdBtnMedium;
        private RadioButton rdBtnSmall;
        private Label label3;
        private NumericUpDown nmrcUdQuantity;
        private Button btnAddOrder;
        private DataGridView dgvOrderList;
        private Label label4;
        private Label lblTotalAmount;
        private Button btnFinishOrder;
        private Label label1;
    }
}