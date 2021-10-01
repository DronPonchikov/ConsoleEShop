using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    public interface IUser
    {   public string Right { get; set; }
        public void WatchGoods();
        public void SearchProductByName(string searchedItem);
    }
}
