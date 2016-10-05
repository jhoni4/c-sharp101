using System;
using TackelWareHouse;

namespace TackelWareHouse
{
    public class Program
    {
        public static void Main(string[] args) //this is a method called main, it is called when the program starts//
        {
            // var name = args[0];
            DateTime purchaseDate = Convert.ToDateTime(args[1]);
            int numberPurchased = Convert.ToInt16(args[2]);
            int purchasePrice = Convert.ToInt16(args[3]);

            Customer customer=new Customer();
            customer.firstname=args[0];
            string greeting = customer.CustomerGreeting(purchaseDate, numberPurchased, purchasePrice);
            // Console.WriteLine(CustomerGreeting(name, purchaseDate, numberPurchased, purchasePrice));

            string discountMessage=customer.ApplyDiscount(customer.firstname.ToLower());
            Console.WriteLine(greeting + "" + discountMessage);

        }

    }
}
