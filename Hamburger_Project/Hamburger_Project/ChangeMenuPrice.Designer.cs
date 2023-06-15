namespace Hamburger_Project
{
    partial class ChangeMenuPrice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.nmrcUdNewPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActualPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxMenuPriceChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUdNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSavePrice);
            this.groupBox1.Controls.Add(this.nmrcUdNewPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblActualPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBoxMenuPriceChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHANGE MENU PRICE";
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.Location = new System.Drawing.Point(10, 181);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(348, 53);
            this.btnSavePrice.TabIndex = 15;
            this.btnSavePrice.Text = "SAVE THE PRICE";
            this.btnSavePrice.UseVisualStyleBackColor = true;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // nmrcUdNewPrice
            // 
            this.nmrcUdNewPrice.Location = new System.Drawing.Point(143, 133);
            this.nmrcUdNewPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrcUdNewPrice.Name = "nmrcUdNewPrice";
            this.nmrcUdNewPrice.Size = new System.Drawing.Size(215, 22);
            this.nmrcUdNewPrice.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "₺";
            // 
            // lblActualPrice
            // 
            this.lblActualPrice.AutoSize = true;
            this.lblActualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActualPrice.ForeColor = System.Drawing.Color.Red;
            this.lblActualPrice.Location = new System.Drawing.Point(140, 105);
            this.lblActualPrice.Name = "lblActualPrice";
            this.lblActualPrice.Size = new System.Drawing.Size(35, 16);
            this.lblActualPrice.TabIndex = 11;
            this.lblActualPrice.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actual Price:";
            // 
            // cmbBoxMenuPriceChange
            // 
            this.cmbBoxMenuPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMenuPriceChange.FormattingEnabled = true;
            this.cmbBoxMenuPriceChange.Location = new System.Drawing.Point(10, 65);
            this.cmbBoxMenuPriceChange.Name = "cmbBoxMenuPriceChange";
            this.cmbBoxMenuPriceChange.Size = new System.Drawing.Size(348, 24);
            this.cmbBoxMenuPriceChange.TabIndex = 1;
            this.cmbBoxMenuPriceChange.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMenuPriceChange_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE THE MENU";
            // 
            // ChangeMenuPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ChangeMenuPrice";
            this.Text = "ChangeMenuPrice";
            this.Load += new System.EventHandler(this.ChangeMenuPrice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUdNewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxMenuPriceChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.NumericUpDown nmrcUdNewPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActualPrice;
    }
}