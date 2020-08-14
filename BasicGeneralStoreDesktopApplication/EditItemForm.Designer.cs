namespace BasicGeneralStoreDesktopApplication
{
    partial class EditItemForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.nudBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbxUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edit Item";
            // 
            // nudBuyingPrice
            // 
            this.nudBuyingPrice.Location = new System.Drawing.Point(271, 147);
            this.nudBuyingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBuyingPrice.Name = "nudBuyingPrice";
            this.nudBuyingPrice.Size = new System.Drawing.Size(559, 24);
            this.nudBuyingPrice.TabIndex = 12;
            this.nudBuyingPrice.ThousandsSeparator = true;
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.Location = new System.Drawing.Point(271, 177);
            this.nudSellingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(559, 24);
            this.nudSellingPrice.TabIndex = 14;
            this.nudSellingPrice.ThousandsSeparator = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(271, 207);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(559, 24);
            this.nudQuantity.TabIndex = 16;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbxUnit
            // 
            this.cmbxUnit.FormattingEnabled = true;
            this.cmbxUnit.Items.AddRange(new object[] {
            "KG",
            "Maan",
            "Bori"});
            this.cmbxUnit.Location = new System.Drawing.Point(271, 236);
            this.cmbxUnit.Name = "cmbxUnit";
            this.cmbxUnit.Size = new System.Drawing.Size(559, 26);
            this.cmbxUnit.TabIndex = 18;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(86, 239);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(66, 18);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "Item Unit";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(747, 349);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(83, 33);
            this.btnCancle.TabIndex = 23;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Item Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item Selling Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item Buying Price";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(271, 349);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(131, 33);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(559, 24);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Item ID";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(268, 91);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(94, 18);
            this.lblItemID.TabIndex = 26;
            this.lblItemID.Text = "Item ID Value";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 503);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudBuyingPrice);
            this.Controls.Add(this.nudSellingPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cmbxUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItemForm";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBuyingPrice;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cmbxUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemID;
    }
}