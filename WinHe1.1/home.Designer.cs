namespace WinHe1._1
{
    partial class home
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
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_invoices = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(51, 180);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(95, 46);
            this.btn_products.TabIndex = 0;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.Location = new System.Drawing.Point(389, 180);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(95, 46);
            this.btn_invoices.TabIndex = 1;
            this.btn_invoices.Text = "Invoices";
            this.btn_invoices.UseVisualStyleBackColor = true;
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(215, 180);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(95, 46);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 460);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_products);
            this.Name = "home";
            this.Text = "WinHe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_invoices;
        private System.Windows.Forms.Button btn_customers;
    }
}

