using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug11
{
    class ScreenDescription : UserInterface
    {

        public void showAdminScreen()
        {
            Console.WriteLine("You are in admin screen");
        }

        public void showStudentScreen()
        {
            Console.WriteLine("You are in student screen");
        }

        public void showAllStudentsScreen()
        {
            Console.WriteLine("You are in all students screen");
        }

        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("You are in student registration screen");
        }

        public void showAllCoursesScreen()
        {
            Console.WriteLine("You are in all courses screen");
        }

        public void introduceNewCourseScreen()
        {
            Console.WriteLine("You are in introduce new course screen");
        }


        public void showFirstScreen()
        {
            
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");

            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
            }
        }
    }
}
