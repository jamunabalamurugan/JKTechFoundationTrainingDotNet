using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    enum BookType
    {
        fiction=101,magazine=102,story=103
    }
    struct Coordinates
    {

    }
    class Books
    {
        public string BookName; 
        public double BookPrice;
        public BookType interest;
        public static string PublisherName;
        public void Display()
        {
            interest = BookType.fiction;
            Console.WriteLine(BookName + BookPrice+interest);
        }
        public static void Hello()
        {
            Console.WriteLine("Hello!!!welcome to static methods session");
        }
    }



    class MethodOverloading
    {
        static float fNum1=99.5f, fNum2=98.4f;
        static double total;

        //Methods have same name but are also having different signature
        //Method Signature will be varying based on the no of arguments,type and order in which it is passed
        static double  Add()
        {
            return fNum1 + fNum2;
        }
         void Add(int iNum1)
        {
            Console.WriteLine("Add method with 0 Arguments and 0 return type"+iNum1);
        }
        static double  Add(double dNum1)
        {
            return total+dNum1;
        }
        static double Add(float i,float j)
        {
            if(i==0)
            {
                i = 95.3f;
            }
            return i + j;
        }
        static double Add(float i, int j)
        {
            if (i == 0)
            {
                i = 95.3f;
            }
            return i + j;
        }
        static int Add(int i,int j)
        {
            return i + j;
        }
        static float Add(float i)
        {
            return ++i;
        }

        public static void Main()
        {
            Console.WriteLine("main method without argument");
            MethodOverloading obj = new MethodOverloading();

            obj.Add(10);

            var total = 100+ 12.3f+125.45;
            var vsum = 100 ;
           // vsum = 100f;//Error ....cannot change the datatype for var once it is assigned
            dynamic dsum;
            float fNum1;
            fNum1 = 13.4f;
            dsum = 100 + 23.3f;
            dsum = "Hundred and ten";


            //obj.Add(10.5f, 78.2f);
            //obj.Add(10, 10);
            //obj.Add(10f, 10);
            //obj.Add(10);
            Console.ReadKey();
        }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Main method with string argument");
        //    MethodOverloading obj = new MethodOverloading();

        //    Add();
        //    double sum = Add(10.5f, 78.2f);
        //    Console.WriteLine(sum);
        //    Add(10, 10);
        //    Add(10);
        //    Console.WriteLine(Add(10f, 10));
        //    Console.WriteLine(Add(100.34));
        //    Console.WriteLine();

        //    Books b1 = new Books();
        //    b1.BookName = "Seven Habbits of Highly influential People";
        //    b1.BookPrice = 600;
        //    Books.PublisherName = "Geethanjali Publishers";
        //    b1.Display();


        //    Books b2;//declaring an object of a class
        //    b2 = new Books();//b2 is an instance of the class Books....we are instantiating b2...allocating memory using new keyword
        //    b2.BookName = "Rich Dad and Poor Dad";
        //    b2.BookPrice = 450;
        //    Books.PublisherName = "Kavin Publishers";
        //    b2.Display();
        //    Books.Hello();//calling a static method with class name.....no need to use the instance of the class

        //    Console.ReadKey();
        //}
    }


}
