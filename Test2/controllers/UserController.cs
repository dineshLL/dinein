using Dinein.data.daos;
using Dinein.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinein.controllers
{
    class UserController
    {
        public static User isUserAuthorized(string username, string password)
        {
            User dbUser = new UserDAO().getUser(username);

            if (dbUser == null) return null;

            if(!password.Equals(dbUser.Password))
            {
                return null;
            }
            else
            {
                return dbUser;
            }
        }
    }
}
