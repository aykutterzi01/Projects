namespace Hamburger_Project
{
    partial class ChangeExtraMaterialPrice
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
            this.cmbBoxMaterials = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.nmrcUdNewPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActualPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBoxMaterials);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHANGE EXTRA MATERIAL PRICE";
            // 
            // cmbBoxMaterials
            // 
            this.cmbBoxMaterials.FormattingEnabled = true;
            this.cmbBoxMaterials.Location = new System.Drawing.Point(6, 54);
            this.cmbBoxMaterials.Name = "cmbBoxMaterials";
            this.cmbBoxMaterials.Size = new System.Drawing.Size(362, 24);
            this.cmbBoxMaterials.TabIndex = 0;
            this.cmbBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMaterials_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHOOSE THE MATERIAL";
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.Location = new System.Drawing.Point(10, 170);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(358, 53);
            this.btnSavePrice.TabIndex = 22;
            this.btnSavePrice.Text = "SAVE THE PRICE";
            this.btnSavePrice.UseVisualStyleBackColor = true;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // nmrcUdNewPrice
            // 
            this.nmrcUdNewPrice.Location = new System.Drawing.Point(143, 122);
            this.nmrcUdNewPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrcUdNewPrice.Name = "nmrcUdNewPrice";
            this.nmrcUdNewPrice.Size = new System.Drawing.Size(215, 22);
            this.nmrcUdNewPrice.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "New Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "₺";
            // 
            // lblActualPrice
            // 
            this.lblActualPrice.AutoSize = true;
            this.lblActualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActualPrice.ForeColor = System.Drawing.Color.Red;
            this.lblActualPrice.Location = new System.Drawing.Point(140, 94);
            this.lblActualPrice.Name = "lblActualPrice";
            this.lblActualPrice.Size = new System.Drawing.Size(35, 16);
            this.lblActualPrice.TabIndex = 18;
            this.lblActualPrice.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Actual Price:";
            // 
            // ChangeExtraMaterialPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeExtraMaterialPrice";
            this.Text = "ChangeExtraMaterialPrice";
            this.Load += new System.EventHandler(this.ChangeExtraMaterialPrice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUdNewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.NumericUpDown nmrcUdNewPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActualPrice;
        private System.Windows.Forms.Label label2;
    }
}