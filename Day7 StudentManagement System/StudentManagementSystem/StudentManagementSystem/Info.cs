using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aug11;
namespace StudentManagementSystem
{
    class Info
    {
        public void display(Student student)
        {
            //Code here to display the details of given student
            Console.WriteLine("--Student Details--\nID:{0}\nName:{1}\nDate of Birth:{2}", student.Id, student.Name, student.DOB);

        }
        public void display(Course course)
        {
            //Code here to display the details of given course
            Console.WriteLine("--Course Details--\nID:{0}\tCourse:{1}\tDuration:{2}\tFees:{3}",course.CourseId,course.CourseName,course.CourseDuration,course.Fees);
        }

    }
}
