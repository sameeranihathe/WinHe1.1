using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;

namespace BusinessLogic
{
    public class ProductBusinessLogic
    {
        ProductData productdata = new ProductData();
        //INsert to Db
        public void Insert(ProductModel ProductModel){
            productdata.Insert(ProductModel);
        }
    }
}
