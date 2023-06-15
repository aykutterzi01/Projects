namespace Hamburger_Project
{
    partial class AddExtraMaterial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxExtraIngredientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrcUdPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSaveExtraIngredient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUdPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveExtraIngredient);
            this.groupBox1.Controls.Add(this.nmrcUdPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxExtraIngredientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXTRA INGREDIENT INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra Ingredient Name:";
            // 
            // txtBoxExtraIngredientName
            // 
            this.txtBoxExtraIngredientName.Location = new System.Drawing.Point(188, 31);
            this.txtBoxExtraIngredientName.Name = "txtBoxExtraIngredientName";
            this.txtBoxExtraIngredientName.Size = new System.Drawing.Size(213, 22);
            this.txtBoxExtraIngredientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // nmrcUdPrice
            // 
            this.nmrcUdPrice.Location = new System.Drawing.Point(188, 69);
            this.nmrcUdPrice.Name = "nmrcUdPrice";
            this.nmrcUdPrice.Size = new System.Drawing.Size(213, 22);
            this.nmrcUdPrice.TabIndex = 3;
            // 
            // btnSaveExtraIngredient
            // 
            this.btnSaveExtraIngredient.Location = new System.Drawing.Point(188, 112);
            this.btnSaveExtraIngredient.Name = "btnSaveExtraIngredient";
            this.btnSaveExtraIngredient.Size = new System.Drawing.Size(213, 61);
            this.btnSaveExtraIngredient.TabIndex = 4;
            this.btnSaveExtraIngredient.Text = "SAVE EXTRA INGREDIENT";
            this.btnSaveExtraIngredient.UseVisualStyleBackColor = true;
            this.btnSaveExtraIngredient.Click += new System.EventHandler(this.btnSaveExtraIngredient_Click);
            // 
            // AddExtraMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddExtraMaterial";
            this.Text = "AddExtraMaterial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUdPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveExtraIngredient;
        private System.Windows.Forms.NumericUpDown nmrcUdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxExtraIngredientName;
        private System.Windows.Forms.Label label1;
    }
}