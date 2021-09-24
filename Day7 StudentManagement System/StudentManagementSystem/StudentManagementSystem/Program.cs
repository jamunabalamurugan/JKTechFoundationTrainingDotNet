using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("S001", "Kavin", DateTime.Parse("06/01/2011"));
            Student s2 = new Student(null, null, DateTime.Parse("06/01/2011"));
            Console.WriteLine(s2);
            Info info = new Info();
            string str = student.ToString();
            Console.WriteLine(str);

            Console.WriteLine(student); //This prints the data type of student object....to change this we need to override the toString method
            info.display(student);
            Console.ReadKey();

        }
    }
}
