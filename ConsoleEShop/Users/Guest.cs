using System;


namespace ConsoleEShop
{
    public class Guest:IUser
    {   public string Right { get { return Right; } set { Right = "Guest"; } }

        public void WatchGoods()
        {
            foreach (var item in Database.goods)
            {
                Console.WriteLine(item);
            }
        }

        public void SearchProductByName(string searchedItem)
        {
            Console.WriteLine("Which product you wanna find?");
            searchedItem = Console.ReadLine();
            if (searchedItem==null)
            {
                throw new ArgumentNullException(nameof(searchedItem), "You didn't choose the good");
            }
            for (int i = 0; i < Database.goods.Count; i++)
            {
                if (searchedItem == Database.goods[i])
                {
                    Console.WriteLine( $"{searchedItem} is available now and its number in order is {i}" );
                }
            }
        }
        public void Registration(string login, string password)
        {

            RegistredUser registredUser = new RegistredUser(login, password);
            Database.users.Add(registredUser);
        }
        public void SingIn(string login, string password)
        {
            foreach (RegistredUser user in Database.users)
            {
                if (login==user.Login && password==user.Password)
                {
                    Console.WriteLine($"Welcome {login}");
                    break;
                    
                }
                else if (login == user.Login && password != user.Password)
                {
                    Console.WriteLine("Wrong login or password");
                }
                else
                {
                    Console.WriteLine("Such user is not registred.");
                    break;
                }
            }
        }
    }
}
