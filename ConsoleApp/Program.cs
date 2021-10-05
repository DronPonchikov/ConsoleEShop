using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEShop;
namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Guest ivan = new Guest();
            ivan.Registration("111", "111");
            ivan.SearchProductByName("apple");
            ivan.WatchGoods();
            Console.WriteLine(ivan.Right + " " + Database.users);
            Console.ReadLine();
        }
    }
}
