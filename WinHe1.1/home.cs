﻿using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            products products = new products();
            this.Hide();
            products.Show();
        }
    }
}
