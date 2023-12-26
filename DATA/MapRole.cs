using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity
{
    public class MapRole
    {
        public tb_role fineRoleById(int id)
        {
            velaMaryEntities db = new velaMaryEntities();
            var role = (from item in db.tb_role
                        where item.role_id == id 
                        select item).FirstOrDefault();
            return role;
        }
        public List<tb_role> findAllRole(int id)
        {
            velaMaryEntities db = new velaMaryEntities();
            var roles = (from item in db.tb_role
                        where item.role_id == id
                        select item).ToList();
            return roles;
        }
    }
}
