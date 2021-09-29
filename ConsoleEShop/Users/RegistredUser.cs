using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    public class RegistredUser:Guest,IUser
    {
      
        public string Login { get; set; }
        public string Password { get; set; }
        public RegistredUser(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public void MakeNewOrder()
        {
           // Order order = new Order();
        }
        public void OrderingOrCancellation()
        {

        }
        public void StoryOfOrders() 
        {

        }
        public void SetStatusReceived()
        {

        }
    }
}
