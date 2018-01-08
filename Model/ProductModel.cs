using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public Nullable<decimal> purchase_price { get; set; }
        public Nullable<decimal> selling_price { get; set; }
        public Nullable<int> quantity { get; set; }
    }
}
