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
using Model;

namespace WinHe1._1
{
    public partial class UpdateProducts : Form
    {
        public UpdateProducts()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ProductModel pm = new ProductModel();

            pm.product_name = txt_productName.Text;
            pm.product_description = txt_description.Text;
            pm.purchase_price = Convert.ToDecimal(txt_purchasePrice.Text);
            pm.selling_price = Convert.ToDecimal(txt_sellingPrice.Text);
            pm.quantity = Convert.ToInt16(txt_quantity.Text);
        }
    }
}
