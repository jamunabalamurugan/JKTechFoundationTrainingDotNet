﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class CalcuateEg
    {
        static int res;
        public static void addition(int a, int b)
        {
            res = a + b;
            Console.WriteLine("The sum of the two numbers entered is {0}", res);

        }
        public static void subtraction(int a, int b)
        {
            res = a - b;
            Console.WriteLine("The difference of the two numbers entered is {0}", res);
        }
        public static int multiplication(int a, int b)
        {
            res = a * b;
            return res;
            //Console.WriteLine("The product of the two numbers entered is {0}", res);
        }
        public static void division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            else
            {
                res = a / b;

                Console.WriteLine("The division of the two numbers entered gives {0}", res);
            }
        }
       

    }

    class UseCalculateEg
    {
        static void Main(string[] args)
        {
            int Num1, Num2, ch;

            string str1, str2, str3;
            Console.WriteLine("Enter the first number:");
            str1 = Console.ReadLine();
            Num1 = Convert.ToInt32(str1);

            Console.WriteLine("Enter the second number:");
            str2 = Console.ReadLine();
            Num2 = Convert.ToInt32(str2);

            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter the Operation you want to perform");
            str3 = Console.ReadLine();
            ch = Convert.ToInt32(str3);

            switch (ch)
            {
                case 1:
                    CalcuateEg.addition(Num1, Num2);
                    break;
                case 2:
                    CalcuateEg.subtraction(Num1, Num2);
                    break;
                case 3:
                    int result = CalcuateEg.multiplication(Num1, Num2);
                    Console.WriteLine("The product of the two numbers entered is {0}", result);
                    break;
                case 4:
                    CalcuateEg.division(Num1, Num2);
                    break;

            }


            Console.ReadLine();

        }
    }


}
