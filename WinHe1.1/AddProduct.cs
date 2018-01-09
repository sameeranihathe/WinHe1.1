using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace WinHe1._1
{
    public partial class AddProduct : Form
    {
        ProductBusinessLogic ProductBusinessLogic = new ProductBusinessLogic();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProduct AddProduct = new AddProduct();
            this.Close();
            AddProduct.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
           
            ProductModel ProductModel = new ProductModel();

            ProductModel.product_name = txt_productName.Text;
            ProductModel.product_description = txt_productDescription.Text;
            ProductModel.purchase_price =Convert.ToDecimal(txt_purchasePrice.Text);
            ProductModel.selling_price = Convert.ToDecimal(txt_sellingPrice.Text);
            ProductModel.quantity = int.Parse(txt_quantity.Text);

            ProductModel.product_id = "sameera";
            ProductBusinessLogic.Insert(ProductModel);
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch !=8 && ch !=46)
            {
                e.Handled = true;
            }
        }

        private void txt_sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_purchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }
       
    }
}
