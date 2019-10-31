using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;


namespace EMCORWebApplication.BL
{

    using EMCORWebApplication.Models;
    public class LoginManager
    {
        private AppDbContext dbContext = new AppDbContext();
        
        public UserClass ValidateUser(string strUserName, string strPassword)
        {
            return dbContext.UserList.Where(s => s.UserName.Equals(strUserName) && s.Password.Equals(strPassword)).FirstOrDefault();

        }

    }
}