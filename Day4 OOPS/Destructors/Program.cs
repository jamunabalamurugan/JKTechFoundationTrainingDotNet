using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WorkWithDistructors
{
    class A
    {
        public A()
        {
            Console.WriteLine("Object A is Created..");

        }
        //Destructor Declaration
        ~A()
        {
            Console.WriteLine("Object A is Destroyed..");
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A _a = new A();
            Console.WriteLine("Press any key and Enter to Destroy the object...");
            Console.ReadLine();
        }
    }
}
