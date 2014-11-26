using DBAdapter.DataContext;
using DBAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAdapter.BusinessLogic
{
    public class UserHelper 
    {
        private ApplicationDBContext adb = new ApplicationDBContext();

        public void AddUser(String username, String password,string fullname,string email)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Fullname = fullname;
            user.Email = email;
            adb.Users.Add(user);
            adb.SaveChanges();
        }

    }
}
