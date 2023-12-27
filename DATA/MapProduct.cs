using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class MapProduct
    {
        private velaMaryEntities db = new velaMaryEntities();
        public List<tb_product> findAllProduct()
        {
            return (from item in db.tb_product
                    select item).ToList();
        }
        public bool saveProduct(tb_product product)
        {
            try
            {
                using (db)
                {
                    db.tb_product.Add(product);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public tb_product findProductById(int id)
        {
            tb_product product = (from item in db.tb_product
                                  where item.product_id == id
                                  select item).FirstOrDefault();
            return product;
        }
        public bool updateProduct(tb_product product)
        {
            tb_product temp = findProductById(product.product_id);
            if(temp != null)
            {
                temp.name = product.name;
                temp.price = product.price;
                temp.quantity = product.quantity;
                temp.collection_id = product.collection_id;

                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
