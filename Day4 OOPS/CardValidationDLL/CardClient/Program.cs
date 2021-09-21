using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardValidationDLL;
namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc = new CreditCard();
            Console.WriteLine("Welcome to the Card Application");
            Console.WriteLine("Please enter the card No");
            string str = Console.ReadLine();
            if(cc.ValidateCreditCard(str))
            {
                Console.WriteLine("Valid Card No");
            }
            else
                Console.WriteLine("Invalid Card No...Pls try again!!!");

            Console.ReadKey();
        }
    }
}
