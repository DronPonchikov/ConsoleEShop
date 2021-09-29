using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
   public class Order
    {
        public static int OrderID { get ;  set; }
        public string OrderStatus { get; set; }
        public RegistredUser UserOrder { get; set; }
        
        public Order(RegistredUser registredUser, string [] content)
        {
            OrderStatus = "New";
            OrderID++;
        }
        

    }
}
