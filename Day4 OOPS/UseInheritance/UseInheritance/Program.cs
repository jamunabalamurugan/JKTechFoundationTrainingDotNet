using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjOOPSConcepts;
namespace UseInheritance
{
    class Consultant:Employee
    {
        public void PrintAge()
        {
            Console.WriteLine(id+" "+name+" "+age);//can access the protected and protected internal member of the class from a new assembly
           // Console.WriteLine("Salary is " + salary);//cannot access a private protected member from another assembly
        }
    }
    class Program
    {
        public void Recruit()
        {
            Employee e1;
            Console.WriteLine("Enter the type of Employee 1.Full Type  2.Part Time");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                e1 = new Employee();
                
                e1.PrintEmployeeData();
                Console.WriteLine(e1.id + " " +e1.name + " " +e1.age);
            }
            else
            {
                e1 = new PartTimeEmployee("E001", "Kavin", 11, 120000, 4000);
                e1.PrintEmployeeData();//calls the Print method of Employee class only as the  method is bound at compile time
                                       // PartTimeEmployee pte = new PartTimeEmployee("E001", "Kavin", 11, 120000, 4000);
                                       // pte.PrintEmployeeData();
            }
        }

        public static void Main()
        {
            new UseEmployee().Recruit();//creating an anonymous object 

            GC.Collect();

            Console.ReadKey();
            //PartTimeEmployee pt = new Employee(); Only parent class object can be used to create object of its derived class

        }
    }
}
