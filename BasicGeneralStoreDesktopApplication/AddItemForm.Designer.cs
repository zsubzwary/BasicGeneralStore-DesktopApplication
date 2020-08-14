namespace BasicGeneralStoreDesktopApplication
{
    partial class AddItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbxUnit = new System.Windows.Forms.ComboBox();
            this.btnAddNewUnit = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.nudBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(559, 24);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Buying Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Selling Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Quantity";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(480, 317);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 33);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Location = new System.Drawing.Point(714, 317);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(83, 33);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(53, 207);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(66, 18);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Item Unit";
            // 
            // cmbxUnit
            // 
            this.cmbxUnit.FormattingEnabled = true;
            this.cmbxUnit.Location = new System.Drawing.Point(238, 204);
            this.cmbxUnit.Name = "cmbxUnit";
            this.cmbxUnit.Size = new System.Drawing.Size(448, 26);
            this.cmbxUnit.TabIndex = 5;
            // 
            // btnAddNewUnit
            // 
            this.btnAddNewUnit.Location = new System.Drawing.Point(692, 202);
            this.btnAddNewUnit.Name = "btnAddNewUnit";
            this.btnAddNewUnit.Size = new System.Drawing.Size(105, 28);
            this.btnAddNewUnit.TabIndex = 6;
            this.btnAddNewUnit.Text = "Add New Unit";
            this.btnAddNewUnit.UseVisualStyleBackColor = true;
            this.btnAddNewUnit.Click += new System.EventHandler(this.btnAddNewUnit_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(238, 175);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(559, 24);
            this.nudQuantity.TabIndex = 4;
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.Location = new System.Drawing.Point(238, 145);
            this.nudSellingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(559, 24);
            this.nudSellingPrice.TabIndex = 3;
            // 
            // nudBuyingPrice
            // 
            this.nudBuyingPrice.Location = new System.Drawing.Point(238, 115);
            this.nudBuyingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBuyingPrice.Name = "nudBuyingPrice";
            this.nudBuyingPrice.Size = new System.Drawing.Size(559, 24);
            this.nudBuyingPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add New Item";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudBuyingPrice);
            this.Controls.Add(this.nudSellingPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddNewUnit);
            this.Controls.Add(this.cmbxUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbxUnit;
        private System.Windows.Forms.Button btnAddNewUnit;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
        private System.Windows.Forms.NumericUpDown nudBuyingPrice;
        private System.Windows.Forms.Label label5;
    }
}