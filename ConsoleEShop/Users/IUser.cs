using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    public interface IUser
    {
        public void WatchGoods();
        public void SearchProductByName(string searchedItem);
    }
}
