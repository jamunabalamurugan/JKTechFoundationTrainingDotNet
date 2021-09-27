﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    class Program
    {
      public  int num1 = 10, num2;
        string[] str = new string[] { "one", "two" };
        void GetData()
        {
            Console.WriteLine("Enter the value to divide");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        void Calculate()
        {
            try
            {
                num1 = num1 / num2;

                Console.WriteLine("Array of index 3:{0}", str[1]);
                num1 = num1 * num1;
                Console.WriteLine("value of num1 is {0}", num1);
            }
        
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Cannot have a number zero for dividing");
                Console.WriteLine("Exception Occured is{0}", exception.Message);

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Try to use a smaller index for your array");
                Console.WriteLine("Exception Occured is{0}", exception.Message);

            }

            catch (Exception exception)
            {
                Console.WriteLine("Sorry....Unexpected error ...pls try again!!!");
                Console.WriteLine("Exception Occured is{0}", exception);
            }
            finally
            {
                int Temp = num1 + num2;
                Console.WriteLine("I am a Finally Block and Temp is {0}", Temp);
            }

        }
        
        static void Main(string[] args)
        {

            Program program = new Program();
            program.GetData();
            program.Calculate();
            Console.Read();
        }
    }
}
