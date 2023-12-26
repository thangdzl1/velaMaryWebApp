using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class MapCart
    {
        
        public int getTotalEarned()
        {
            velaMaryEntities db = new velaMaryEntities();
            //Tính tổng tiền earned
            return (from item in db.tb_cart
                    where item.status_id == 1
                    select item.price).Sum();
        }

        public int getPendingOrder()
        {
            velaMaryEntities db = new velaMaryEntities();
            //Tính pending order
            return (from item in db.tb_cart
                    where item.status_id == 2
                    select item).Count();
        }
    }
}
