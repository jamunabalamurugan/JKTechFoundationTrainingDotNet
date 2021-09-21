using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCreditCardDLL;
namespace prjCrediCardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CardValidation cv = new CardValidation();
            if(cv.AcceptCard("5425051305058125"))
                Console.WriteLine("Thanks for giving  valid Card Details");
            else
                Console.WriteLine("Invalid Card No...Pls try again...");
            Console.ReadKey();
            
        }
    }
}
