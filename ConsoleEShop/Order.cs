using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
   public class Order:IEnumerable
    {
        public static int OrderID { get ;  set; }
        public string OrderStatus { get; set; }
        public string [] Content { get; set; }

        public Order(RegistredUser registredUser)
        {
            OrderStatus = "New";
            OrderID++;
        }

        public Order(RegistredUser registredUser, string [] content)
        {
            OrderStatus = "New";
            OrderID++;
            Content = content;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var order in Database.Orders)
            {
                yield return OrderID;
                yield return OrderStatus;
                yield return Content;
              

            }
        }
    }
}
