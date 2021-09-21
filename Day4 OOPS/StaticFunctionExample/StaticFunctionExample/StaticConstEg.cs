using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStaticProject
{
    class Program
    {
        //instance member
        int num1;
        //static member
        static int num2;

        const int num3 = 1000;
        void m1()
        {
            //instance member in instance context
            num1 = 100;
            //static member in instance context
            num2 = 200;
            //constant member cannot be changed
            //num3 = 2000;
        }

        void addOne()
        {
            Console.WriteLine("The value of num1 - instance initially is " + num1);
            Console.WriteLine("The value of num2 - static initially is " + num2);
            num1++;// num1=num1+1;
            num2++;
            Console.WriteLine("The value of num1 - instance after increment is " + num1);//1,1,1,1
            Console.WriteLine("The value of num2 - static after increment is " + num2); // 1,2,3
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();  //Num1 H##1 0+1      Num2  N100 1
            Program p3 = new Program(); //Num1 H##2  0+1        Num2  N100 2
            Program p2 = new Program(); //Num1 H##2  0+1      Num2  N100 3

            p1.num1 = 10;
            // p1.num2 = 5; --Error as num2 is a static variable
            Program.num2 = 5; //Refer a static variable
                              //p1.num3 = 1001;--Error cannot change values for a const variable

            p1.addOne();
            p2.addOne();
            p3.addOne();

            Console.ReadKey();
        }
    }
}
