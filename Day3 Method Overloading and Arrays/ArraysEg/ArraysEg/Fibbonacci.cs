using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class Fibonacci
    {
    int fib(int x)
    {
        if ((x == 1) || (x == 0))
        {
            return (x);
        }
        else
        {
            return (fib(x - 1) + fib(x - 2));
        }
    }
    int main()
    {
        int x, i = 0;
        Console.WriteLine("Enter the number of terms of series : ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("\nFibonnaci Series : ");
        while (i < x)
        {
            Console.WriteLine(fib(i)+" ");
            i++;
        }
        return 0;
    }
   
        void PrintFibSeries()
        {
            int number1;
            int number2;
            number1 = number2 = 1;
            int max = int.Parse(Console.ReadLine());
            if (max > 1)
            {
                Console.WriteLine(0);
                Console.WriteLine("{0}", number1);
            }
            else if (max == 0)
            {
                return;
            }
            else if (max == 1)
            {
                Console.WriteLine(0);
                return;
            }
            while (number2 < max)
            {
                Console.WriteLine(number2);
                number2 += number1;
                number1 = number2 - number1;
            }
        }
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            fib.main();

            Console.ReadLine();

        }
    }
}
