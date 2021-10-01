using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShop
{
    public class RegistredUser:Guest,IEnumerable,IUser
    {
      
        public string Login { get; set; }
        public string Password { get; set; }
       
        public RegistredUser()
        {
            Right = "RegistredUser";
        }
        public RegistredUser(string login, string password)
        {
            Login = login;
            Password = password;
            Right = "RegistredUser";
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

        public IEnumerator GetEnumerator()
        {
            foreach (RegistredUser user in Database.users)
            {
                yield return user;
            }
        }
    }
}
