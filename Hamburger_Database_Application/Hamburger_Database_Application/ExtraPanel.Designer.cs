namespace Hamburger_Database_Application
{
    partial class ExtraPanel
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
            dgvExtras = new DataGridView();
            groupBox1 = new GroupBox();
            btnExtraDelete = new Button();
            btnExtraUpdate = new Button();
            btnExtraAdd = new Button();
            nmrcUdExtraPrice = new NumericUpDown();
            label2 = new Label();
            txtBoxExtraName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdExtraPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvExtras
            // 
            dgvExtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtras.Location = new Point(306, 82);
            dgvExtras.Name = "dgvExtras";
            dgvExtras.RowHeadersWidth = 51;
            dgvExtras.RowTemplate.Height = 29;
            dgvExtras.Size = new Size(726, 287);
            dgvExtras.TabIndex = 3;
            dgvExtras.CellClick += dgvExtras_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExtraDelete);
            groupBox1.Controls.Add(btnExtraUpdate);
            groupBox1.Controls.Add(btnExtraAdd);
            groupBox1.Controls.Add(nmrcUdExtraPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBoxExtraName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 188);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "EXTRA INFORMATION";
            // 
            // btnExtraDelete
            // 
            btnExtraDelete.Location = new Point(187, 142);
            btnExtraDelete.Name = "btnExtraDelete";
            btnExtraDelete.Size = new Size(88, 29);
            btnExtraDelete.TabIndex = 6;
            btnExtraDelete.Text = "DELETE";
            btnExtraDelete.UseVisualStyleBackColor = true;
            btnExtraDelete.Click += btnExtraDelete_Click;
            // 
            // btnExtraUpdate
            // 
            btnExtraUpdate.Location = new Point(83, 142);
            btnExtraUpdate.Name = "btnExtraUpdate";
            btnExtraUpdate.Size = new Size(88, 29);
            btnExtraUpdate.TabIndex = 5;
            btnExtraUpdate.Text = "UPDATE";
            btnExtraUpdate.UseVisualStyleBackColor = true;
            btnExtraUpdate.Click += btnExtraUpdate_Click;
            // 
            // btnExtraAdd
            // 
            btnExtraAdd.Location = new Point(7, 142);
            btnExtraAdd.Name = "btnExtraAdd";
            btnExtraAdd.Size = new Size(61, 29);
            btnExtraAdd.TabIndex = 4;
            btnExtraAdd.Text = "ADD";
            btnExtraAdd.UseVisualStyleBackColor = true;
            btnExtraAdd.Click += btnExtraAdd_Click;
            // 
            // nmrcUdExtraPrice
            // 
            nmrcUdExtraPrice.Location = new Point(115, 86);
            nmrcUdExtraPrice.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nmrcUdExtraPrice.Name = "nmrcUdExtraPrice";
            nmrcUdExtraPrice.Size = new Size(160, 27);
            nmrcUdExtraPrice.TabIndex = 3;
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
            // txtBoxExtraName
            // 
            txtBoxExtraName.Location = new Point(115, 39);
            txtBoxExtraName.Name = "txtBoxExtraName";
            txtBoxExtraName.Size = new Size(160, 27);
            txtBoxExtraName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Extra Name:";
            // 
            // ExtraPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(dgvExtras);
            Controls.Add(groupBox1);
            Name = "ExtraPanel";
            Text = "ExtraPanel";
            ((System.ComponentModel.ISupportInitialize)dgvExtras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUdExtraPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvExtras;
        private GroupBox groupBox1;
        private Button btnExtraDelete;
        private Button btnExtraUpdate;
        private Button btnExtraAdd;
        private NumericUpDown nmrcUdExtraPrice;
        private Label label2;
        private TextBox txtBoxExtraName;
        private Label label1;
    }
}