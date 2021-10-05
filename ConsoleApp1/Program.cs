using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEShop;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Guest ivan = new Guest();
            ivan.Registration("111", "111");
            
            Console.WriteLine(ivan.Right + Database.users); 
            Console.ReadLine();
        }
    }
}
