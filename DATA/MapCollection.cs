using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class MapCollection
    {
        private velaMaryEntities db = new velaMaryEntities();
        public List<tb_collection> findAllCollection()
        {
            return (from item in db.tb_collection
                    select item).ToList();
        }
    }
}
