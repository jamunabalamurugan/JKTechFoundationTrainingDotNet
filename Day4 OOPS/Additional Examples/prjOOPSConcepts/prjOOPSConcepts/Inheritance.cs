using System;


namespace prjOverloadingExample
{
    class Employee
    {
        private string name, id;
        protected int? age;
        private float? salary;

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

        internal void GetEmployeeData()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Console.ReadLine();
            Console.WriteLine("Please enter the employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee Salary");
            salary = float.Parse(Console.ReadLine());

        }
        internal virtual void PrintEmployeeData()
        {
            string strEmployee = "Employee with ID " + id
                                    + " Name :" + name
                                    + " who is " + age + " old "
                                    + " earns salary " + salary;
            Console.WriteLine(strEmployee);
        }
        public virtual void GiveDailyReport()
        {

        }


    }
class PartTimeEmployee : Employee//inheriting from Base class
    {
        float dailyPerks;
        public PartTimeEmployee()//derived class default contructor
        {
            Console.WriteLine("Inside Default Constructor of PartTimeEmployee");
            dailyPerks = 0;
        }
        internal PartTimeEmployee(string id, string name, int age,float salary, float perk) : base(id, name, age, salary)
        //call the default constructor of the base class
        //if  you want to call the overloaded constrcutor use the base keyword and call the overloaded constructor explicitly

        {
            Console.WriteLine("Inside Overloaded Constructor of PTEmployee");
            
            dailyPerks = perk;
            //this.dailyPerks=dailyPerks;
        }

      public sealed override void GiveDailyReport()
        {
            age = 20;//Age cannot be accesed if it is declared private

            base.PrintEmployeeData();
            Console.WriteLine("this is a daily report " + dailyPerks);
        }
        internal override void PrintEmployeeData()
        {
            base.PrintEmployeeData();
            Console.WriteLine("Printing PartTimeEmployees Perk Amount " + dailyPerks);
        }
        ~PartTimeEmployee()
        {
            dailyPerks = 0;
            Console.WriteLine("Destructor of PTE called");
        }
    }
    class Company
    {
        void Recruit()
        {
            Employee e1 = new Employee();//default Constructor
           // e1.GetEmployeeData();
          //  e1.PrintEmployeeData();

            Console.WriteLine("------------"); //Next line calling overloaded constructor
            Employee e2 = new Employee("E002", "Kanav", 22, 123456.33f);
            e2.PrintEmployeeData();

            e1 = new PartTimeEmployee("P001", "Ramu", 18, 4000, 200);
            e2 = new PartTimeEmployee("P002", "Somu", 16, 3000, 100);
            e1.PrintEmployeeData();
            e2.PrintEmployeeData();


        }
        static void Main(string[] s)
        {
            Company at2 = new Company();
            at2.Recruit();

            GC.Collect();
            Console.ReadKey();
        }
    }
}
