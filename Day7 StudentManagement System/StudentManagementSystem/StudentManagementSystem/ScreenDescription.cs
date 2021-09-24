using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem;
namespace Aug11
{
    class ScreenDescription : UserInterface
    {
        //Presentation Layer
        Info info = new Info();
        Enroll en = new Enroll();

        public void showAdminScreen()
        {
            Console.WriteLine("You are in admin screen");
            Console.WriteLine("---Welcome to Admin Dashboard---");
            Console.WriteLine("\nEnter your choice:\n1.Show all Student Details\n2.Show all current Student Enrollments\n" +
                "3.Introduce new course\n4.Show all courses\n5.Display Student Details by ID\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    showAllStudentsScreen();
                    break;
                case 2:
                    //showAllEnrollments();
                    break;
                case 3:
                    introduceNewCourseScreen();
                    break;
                case 4:
                    showAllCoursesScreen();
                    break;
                case 5:
                    //showStudentDetails();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
        }

        public void showStudentScreen()
        {
            Console.WriteLine("You are in student screen");
            Console.WriteLine("\nEnter your choice:\n1.Register for a Course\n2.Show all Student Enrollments\n3.Show all Student Details\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    //showAllEnrollments();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }

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
            foreach (Course course in en.listOfCourses())
            {
                
                info.display(course);
            }
        }

        public void introduceNewCourseScreen()
        {
            Console.WriteLine("You are in introduce new course screen");
            Console.WriteLine("---Add a new Course---");
            Console.WriteLine("Enter the course details to be added:");
            Console.WriteLine("Course ID:");
            string CourseId = Console.ReadLine();
            Console.WriteLine("Course Name:");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Course Duration:");
            string CourseDuration = Console.ReadLine();
            Console.WriteLine("Course Fees:");
            float CourseFees = float.Parse(Console.ReadLine());
            en.introduce(new Course(CourseId, CourseName, CourseDuration, CourseFees));
           
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
