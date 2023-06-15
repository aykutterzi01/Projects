namespace Hamburger_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxMenu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnLarge = new System.Windows.Forms.RadioButton();
            this.rdBtnMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnSmall = new System.Windows.Forms.RadioButton();
            this.Number = new System.Windows.Forms.Label();
            this.nmrcUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxOrders = new System.Windows.Forms.ListBox();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlIngredient = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHOOSE YOUR MENU";
            // 
            // cmBoxMenu
            // 
            this.cmBoxMenu.FormattingEnabled = true;
            this.cmBoxMenu.Location = new System.Drawing.Point(15, 189);
            this.cmBoxMenu.Name = "cmBoxMenu";
            this.cmBoxMenu.Size = new System.Drawing.Size(292, 24);
            this.cmBoxMenu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnLarge);
            this.groupBox1.Controls.Add(this.rdBtnMedium);
            this.groupBox1.Controls.Add(this.rdBtnSmall);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE THE SIZE";
            // 
            // rdBtnLarge
            // 
            this.rdBtnLarge.AutoSize = true;
            this.rdBtnLarge.Location = new System.Drawing.Point(203, 21);
            this.rdBtnLarge.Name = "rdBtnLarge";
            this.rdBtnLarge.Size = new System.Drawing.Size(68, 20);
            this.rdBtnLarge.TabIndex = 5;
            this.rdBtnLarge.TabStop = true;
            this.rdBtnLarge.Text = "Large";
            this.rdBtnLarge.UseVisualStyleBackColor = true;
            // 
            // rdBtnMedium
            // 
            this.rdBtnMedium.AutoSize = true;
            this.rdBtnMedium.Location = new System.Drawing.Point(104, 22);
            this.rdBtnMedium.Name = "rdBtnMedium";
            this.rdBtnMedium.Size = new System.Drawing.Size(82, 20);
            this.rdBtnMedium.TabIndex = 4;
            this.rdBtnMedium.TabStop = true;
            this.rdBtnMedium.Text = "Medium";
            this.rdBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdBtnSmall
            // 
            this.rdBtnSmall.AutoSize = true;
            this.rdBtnSmall.Location = new System.Drawing.Point(7, 22);
            this.rdBtnSmall.Name = "rdBtnSmall";
            this.rdBtnSmall.Size = new System.Drawing.Size(67, 20);
            this.rdBtnSmall.TabIndex = 0;
            this.rdBtnSmall.TabStop = true;
            this.rdBtnSmall.Text = "Small";
            this.rdBtnSmall.UseVisualStyleBackColor = true;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Number.Location = new System.Drawing.Point(13, 425);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(72, 16);
            this.Number.TabIndex = 5;
            this.Number.Text = "NUMBER";
            // 
            // nmrcUpDownNumber
            // 
            this.nmrcUpDownNumber.Location = new System.Drawing.Point(109, 425);
            this.nmrcUpDownNumber.Name = "nmrcUpDownNumber";
            this.nmrcUpDownNumber.Size = new System.Drawing.Size(198, 22);
            this.nmrcUpDownNumber.TabIndex = 6;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrder.Location = new System.Drawing.Point(16, 501);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(291, 44);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "ADD ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(363, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL AMOUNT:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(529, 515);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(35, 16);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(498, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "₺";
            // 
            // lstBoxOrders
            // 
            this.lstBoxOrders.FormattingEnabled = true;
            this.lstBoxOrders.ItemHeight = 16;
            this.lstBoxOrders.Location = new System.Drawing.Point(330, 13);
            this.lstBoxOrders.Name = "lstBoxOrders";
            this.lstBoxOrders.Size = new System.Drawing.Size(557, 468);
            this.lstBoxOrders.TabIndex = 11;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinishOrder.Location = new System.Drawing.Point(632, 501);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(255, 44);
            this.btnFinishOrder.TabIndex = 12;
            this.btnFinishOrder.Text = "FINISH ORDER";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "CHOOSE INGREDIENT";
            // 
            // pnlIngredient
            // 
            this.pnlIngredient.AutoScroll = true;
            this.pnlIngredient.Location = new System.Drawing.Point(15, 316);
            this.pnlIngredient.Name = "pnlIngredient";
            this.pnlIngredient.Size = new System.Drawing.Size(292, 100);
            this.pnlIngredient.TabIndex = 14;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(899, 560);
            this.Controls.Add(this.pnlIngredient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.lstBoxOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.nmrcUpDownNumber);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmBoxMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnMedium;
        private System.Windows.Forms.RadioButton rdBtnSmall;
        private System.Windows.Forms.RadioButton rdBtnLarge;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.NumericUpDown nmrcUpDownNumber;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxOrders;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlIngredient;
    }
}