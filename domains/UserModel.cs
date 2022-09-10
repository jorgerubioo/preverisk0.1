using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common1.Cache;

namespace Domain
{
    public class UserModel
    {
         UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass) {
            return userDao.Login(user,pass);
         }

     public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting); 
        }

        
    }
}







