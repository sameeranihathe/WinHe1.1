using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHe1._1
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct AddProduct = new AddProduct();
            this.Hide();
            AddProduct.Show();
        }
    }
}
