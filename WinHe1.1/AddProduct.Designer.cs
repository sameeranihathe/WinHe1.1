namespace WinHe1._1
{
    partial class AddProduct
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
            this.lbl_productname = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellingprice = new System.Windows.Forms.Label();
            this.txt_purchasePrice = new System.Windows.Forms.TextBox();
            this.lbl_purchaseprice = new System.Windows.Forms.Label();
            this.txt_productDescription = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Location = new System.Drawing.Point(23, 21);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(98, 17);
            this.lbl_productname.TabIndex = 0;
            this.lbl_productname.Text = "Product Name";
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(128, 21);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(309, 22);
            this.txt_productName.TabIndex = 1;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(128, 298);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 22);
            this.txt_quantity.TabIndex = 3;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(23, 298);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(61, 17);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Location = new System.Drawing.Point(128, 237);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(100, 22);
            this.txt_sellingPrice.TabIndex = 5;
            this.txt_sellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sellingPrice_KeyPress);
            // 
            // lbl_sellingprice
            // 
            this.lbl_sellingprice.AutoSize = true;
            this.lbl_sellingprice.Location = new System.Drawing.Point(23, 237);
            this.lbl_sellingprice.Name = "lbl_sellingprice";
            this.lbl_sellingprice.Size = new System.Drawing.Size(86, 17);
            this.lbl_sellingprice.TabIndex = 4;
            this.lbl_sellingprice.Text = "Selling Price";
            this.lbl_sellingprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Location = new System.Drawing.Point(128, 184);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.Size = new System.Drawing.Size(100, 22);
            this.txt_purchasePrice.TabIndex = 7;
            this.txt_purchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_purchasePrice_KeyPress);
            // 
            // lbl_purchaseprice
            // 
            this.lbl_purchaseprice.AutoSize = true;
            this.lbl_purchaseprice.Location = new System.Drawing.Point(23, 184);
            this.lbl_purchaseprice.Name = "lbl_purchaseprice";
            this.lbl_purchaseprice.Size = new System.Drawing.Size(104, 17);
            this.lbl_purchaseprice.TabIndex = 6;
            this.lbl_purchaseprice.Text = "Purchase Price";
            // 
            // txt_productDescription
            // 
            this.txt_productDescription.Location = new System.Drawing.Point(128, 73);
            this.txt_productDescription.Multiline = true;
            this.txt_productDescription.Name = "txt_productDescription";
            this.txt_productDescription.Size = new System.Drawing.Size(309, 65);
            this.txt_productDescription.TabIndex = 9;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(23, 73);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 8;
            this.lbl_description.Text = "Description";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(583, 376);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 433);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_productDescription);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.lbl_purchaseprice);
            this.Controls.Add(this.txt_sellingPrice);
            this.Controls.Add(this.lbl_sellingprice);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.lbl_productname);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label lbl_sellingprice;
        private System.Windows.Forms.TextBox txt_purchasePrice;
        private System.Windows.Forms.Label lbl_purchaseprice;
        private System.Windows.Forms.TextBox txt_productDescription;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_insert;

    }
}