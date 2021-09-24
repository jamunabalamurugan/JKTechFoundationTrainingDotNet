using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem;
namespace Aug11
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        private Course[] CourseArr = new Course[10];
        private Student[] StudentArr = new Student[10];
        private Enroll[] EnrollArr = new Enroll[10];
       // private Enroll[][] Enrollments = new Enroll[5][];

        //public void JaggedArray()
        //{
        //    Enrollments[0][] = { new Enroll(student, course, enrollmentDate),new Enroll(student, course, enrollmentDate)};
        //}
        public Enroll()
        { }
        Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
       
        public void introduce(Course course)
        {
            //int inx = CourseArr.GetLength(10);
            int inx = CourseArr.Length;
            CourseArr[0] = course;
        }

        public Course[] listOfCourses()
        {
            
            return CourseArr;
        }

        public void register(Student student)
        {
            int inx = StudentArr.GetLength(10);
            StudentArr[inx] = student;
        }

        public Student[] listOfStudents()
        {
            return StudentArr;
        }

        public void enroll(Student student, Course course)
        {
            int inx = EnrollArr.GetLength(10);
            EnrollArr[inx] = new Enroll(student,course, enrollmentDate);
        }

        public Enroll[] listOfEnrollments()
        {
            return EnrollArr;
        }

    }

}
