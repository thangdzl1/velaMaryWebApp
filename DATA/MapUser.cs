using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class MapUser
    {
        private velaMaryEntities db = new velaMaryEntities();
        // Hàm Authen User
        public tb_user AuthenticateUser(string email, string password)
        {
            var user = (from item in db.tb_user
                        where item.email == email && item.password == password
                        select item).FirstOrDefault();

            //user khác null thì Authen thành công
            if (user != null )
            {
                return user;
            }
            //default là Authen thất bại
            return null;
        }
        public bool addUser(tb_user user)
        {
            //Add User vào database
            db.tb_user.Add(user);
            int isSucess = db.SaveChanges();
            if (isSucess > 0)
            {
                return true;
            }
            return false;
        }
    }
}
