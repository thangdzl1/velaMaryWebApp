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
            try
            {
                //Add User vào database
                var newUser = new tb_user()
                {
                    fullname = user.fullname,
                    email = user.email,
                    password = user.password,
                    role_id = user.role_id,
                };
                using(db)
                {
                    db.tb_user.Add(newUser);
                    db.SaveChanges();
                }
                return true;
            }catch

            {
                return false;
            }
        }
    }
}
