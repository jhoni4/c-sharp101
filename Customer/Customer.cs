using System;
using System.Text;


namespace TackelWareHouse
{
    public class Customer
    {
        public string firstname{get;set;}
         public string CustomerGreeting(DateTime purchaseDate, int numberPurchased, int purchasePrice)
            {
                string greeting=string.Empty;
                var finalPrice = numberPurchased * purchasePrice;
                StringBuilder sb = new StringBuilder();
                sb.Append("Hello");
                sb.Append(this.firstname + "!" + " you purchased a vinyl record on ");
                sb.Append(purchaseDate.ToString());
                sb.Append(" Final price +" + finalPrice);
                // string customerGreeting=sb.ToString();
                greeting= sb.ToString();
                // Console.WriteLine("Hello World" + name + "!" + "you purchased a vinyl record on " + purchaseDate.ToString() + "finalPrice +");

                return greeting;
            }

            public string ApplyDiscount(string name)
            {
                string success= string.Empty;
                if(name=="billy")
                {
                    success="Discount Applied";
                }
                else
                {
                    success="sorry no discount for you";
                }

                return success;
            }

    }

}   