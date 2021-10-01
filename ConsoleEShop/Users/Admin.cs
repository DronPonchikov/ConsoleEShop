using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    class Admin: RegistredUser,IUser
    {
        
        public Admin()
        {
            Login = "admin";
            Password = "admin";
            Right = "Admin";
        }
    }
}
