using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    public class InvalidAgeException :ApplicationException
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    class CustomException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                validate(age);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAgeException exception)
            {
                Console.WriteLine(exception.Message+"\t"+exception.Source+"\t"+exception.TargetSite);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknow Error");
            }

            Console.Read();
        }
    }
}
