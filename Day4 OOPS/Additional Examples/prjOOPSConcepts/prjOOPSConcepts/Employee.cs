using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPSConcepts
{
    public class Employee
    {
        protected string name, id;
        protected internal int? age;
        private protected float? salary;

        ~Employee()
        {
            name = null;
            id = null;
            age = null;
            salary = null;
            Console.WriteLine("The Destructor of Employee Called");
        }

        public Employee()
        {
            Console.WriteLine("Inside Constructor of Employee");
            id = "E000";
            name = "no name";
            age = 18;
            salary = 0.0f;

        }

        public Employee(string eid, string ename, int eage, float esalary)
        {
            id = eid;//this.id = eid;
            this.name = ename;
            this.age = eage;
            this.salary = esalary;
            Console.WriteLine("Inside Overloaded Constructor of Employee");
        }
        public virtual void PrintEmployeeData()
        {
            string strEmployee = "Employee with ID " + id
                                    + " Name :" + name
                                    + " who is " + age + " old "
                                    + " earns salary " + salary;
            Console.WriteLine(strEmployee);
        }
    }

    public class PartTimeEmployee : Employee//inheriting from Base class
    {
        float dailyPerks;
        public PartTimeEmployee()//derived class default contructor
        {
            Console.WriteLine("Inside Default Constructor of PartTimeEmployee");
            dailyPerks = 0;
        }
        public PartTimeEmployee(string id, string name, int age, float salary, float perk) : base(id, name, age, salary)
        //call the default constructor of the base class if we dont give :base()
        //if  you want to call the overloaded constrcutor use the base keyword and call the overloaded constructor explicitly

        {
            Console.WriteLine("Inside Overloaded Constructor of PTEmployee");

            dailyPerks = perk;
            //this.dailyPerks=dailyPerks;
        }
        public override void PrintEmployeeData()//Method overriding 
        {
            base.PrintEmployeeData();
            Console.WriteLine("Salary is "+salary);
            Console.WriteLine("Printing PartTimeEmployees Perk Amount " + dailyPerks);
        }
        ~PartTimeEmployee()
        {
            dailyPerks = 0;
            Console.WriteLine("Destructor of PTE called");
        }
    }

    public class UseEmployee
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
               // Console.WriteLine(e1.id + " " + e1.name + " " + e1.age);
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
