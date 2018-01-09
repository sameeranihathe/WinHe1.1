using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLogic
{
   public class ProductData
    {
       

       public void Insert(ProductModel productmodel)
       {
           using (WinHeEntities db = new WinHeEntities())
           {
               tbl_products tbl =new tbl_products();

               try
               {
                   tbl.product_description = productmodel.product_description;
                   tbl.product_id = productmodel.product_id;
                   tbl.product_name = productmodel.product_name;
                   tbl.purchase_price = productmodel.purchase_price;
                   tbl.selling_price = productmodel.selling_price;
                   tbl.quantity = productmodel.quantity;
                   db.tbl_products.Add(tbl);
                   db.SaveChanges();
               }
               catch (Exception)
               {
                   
                   throw;
               }


             
           }
       }

       public void Update(ProductModel productmodel)
       {
           using (WinHeEntities db = new WinHeEntities())
           {
              tbl_products tbl  = (from recode in db.tbl_products where(recode.product_id == productmodel.product_id) select recode).FirstOrDefault();
               //tbl_products tbl = db.tbl_products.Where(x => x.product_id == productmodel.product_id).FirstOrDefault();

              tbl.product_description = productmodel.product_description;
              tbl.product_name = productmodel.product_name;
              tbl.purchase_price = productmodel.purchase_price;
              tbl.selling_price = productmodel.selling_price;
              tbl.quantity = productmodel.quantity;

              db.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
              db.SaveChanges();

           }

           

       }
    }
}
