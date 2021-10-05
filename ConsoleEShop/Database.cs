using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    public class Database
    {
       public static List<string> goods = new List<string>(10) 
        {"apple", "banana", "orange", "strawberry", "kiwi", "melon", "lemon", "papaya", "blueberry", "peach" };

        public static List<IUser> users = new List<IUser>();
        public static Dictionary<RegistredUser, Order> Orders = new Dictionary<RegistredUser, Order>();
    }
}
