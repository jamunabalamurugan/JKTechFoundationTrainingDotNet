using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
 
    class Employee
    {
        //private int EmpId;

        //public int Id
        //{
        //    get { return EmpId; }
        //    set { EmpId = value; }
        //}
        public int EmployeeId { get; set; }//This is called an auto implemented property
        public string Name
        {
            set
            {
                if (value == null) { Console.WriteLine("Invalid Name"); }

            }
        

        }
    }

     class MY
    {
        public const int MAX = 15;
        public const double PI = 3.14;
        int i = 5;

    }
    class Age
    {

        public const int MAXAGE = 150;
        public readonly int year=21;
        int month = 1;
        char[] phoneno = new char[MY.MAX];
        public Age(int year)
        {
            this.year = year;
        }
        void ChangeYear()
        {
            //this.year = 1967; // Compile error if uncommented.
        }
        public static void Trial()
        {
            char[] phoneno1 = new char[MY.MAX];

              const int MAX1 = 15;
        //this.year = 2025;

    }
    }

    class UseEmployee
        {

            public static void Main()
            {
                Employee e1 = new Employee();
                e1.Name = "Jamuna";
               // string s1 = e1.Name;
                //Console.WriteLine(s1);
                Employee e2 = new Employee();
                e2.Name = null;
                
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words where word.EndsWith("e") select word;//LINQ
            var result = words.Contains("g");//LINQ
            Console.WriteLine(wordQuery);
            int[] scores = new int[Age.MAXAGE];//a constant variable can be acceses directly with class name
            Age age = new Age(25);
            int yy = age.year;
            int y = age.year;//a readonly variable cannot be accessed without an object of a class 
            int mm = Age.MAXAGE;
            foreach (var item in scores)
            {

            }
            Age sage = new Age(25);
                Console.ReadKey();
            }
        }
    

}
