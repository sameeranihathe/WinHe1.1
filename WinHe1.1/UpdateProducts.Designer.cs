namespace WinHe1._1
{
    partial class UpdateProducts
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
            this.lbl_productId = new System.Windows.Forms.Label();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_purchasePrice = new System.Windows.Forms.TextBox();
            this.lbl_purchasePrice = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellingPrice = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(13, 26);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(74, 17);
            this.lbl_productId.TabIndex = 0;
            this.lbl_productId.Text = "Product ID";
            // 
            // txt_productId
            // 
            this.txt_productId.Location = new System.Drawing.Point(127, 26);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(100, 22);
            this.txt_productId.TabIndex = 1;
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(127, 79);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(252, 22);
            this.txt_productName.TabIndex = 3;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(13, 79);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(98, 17);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "Product Name";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(127, 137);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(252, 84);
            this.txt_description.TabIndex = 5;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(13, 137);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Location = new System.Drawing.Point(126, 257);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.Size = new System.Drawing.Size(100, 22);
            this.txt_purchasePrice.TabIndex = 7;
            // 
            // lbl_purchasePrice
            // 
            this.lbl_purchasePrice.AutoSize = true;
            this.lbl_purchasePrice.Location = new System.Drawing.Point(12, 257);
            this.lbl_purchasePrice.Name = "lbl_purchasePrice";
            this.lbl_purchasePrice.Size = new System.Drawing.Size(104, 17);
            this.lbl_purchasePrice.TabIndex = 6;
            this.lbl_purchasePrice.Text = "Purchase Price";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Location = new System.Drawing.Point(127, 313);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(100, 22);
            this.txt_sellingPrice.TabIndex = 9;
            // 
            // lbl_sellingPrice
            // 
            this.lbl_sellingPrice.AutoSize = true;
            this.lbl_sellingPrice.Location = new System.Drawing.Point(13, 313);
            this.lbl_sellingPrice.Name = "lbl_sellingPrice";
            this.lbl_sellingPrice.Size = new System.Drawing.Size(86, 17);
            this.lbl_sellingPrice.TabIndex = 8;
            this.lbl_sellingPrice.Text = "Selling Price";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(126, 372);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 22);
            this.txt_quantity.TabIndex = 11;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(12, 372);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(61, 17);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Quantity";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(304, 455);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 515);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_sellingPrice);
            this.Controls.Add(this.lbl_sellingPrice);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.lbl_purchasePrice);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.txt_productId);
            this.Controls.Add(this.lbl_productId);
            this.Name = "UpdateProducts";
            this.Text = "b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_purchasePrice;
        private System.Windows.Forms.Label lbl_purchasePrice;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label lbl_sellingPrice;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_edit;
    }
}