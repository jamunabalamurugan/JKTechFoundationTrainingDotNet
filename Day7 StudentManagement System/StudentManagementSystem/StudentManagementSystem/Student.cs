using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student
    {
        string id;
        string name;
        DateTime dateOfBirth;


        public Student(string id, string name, DateTime? dateOfBirth)
        {
            id=id ?? "S000";
            this.id = id;
            name = name ?? "JK0";
            this.name = name;
            dateOfBirth=dateOfBirth ?? DateTime.Today;
            this.dateOfBirth =(DateTime)dateOfBirth;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DOB
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public override string ToString()
        {
            //Object o;
            //return "\"ID:{0}\tName:{1}\tDate of Birth:{2}\",id,name,dateOfBirth";

            // return id + "\t" + name + "\t" + dateOfBirth;

            return $"ID:{id}\tName:{name}\tDate of Birth:{dateOfBirth}";
        }
    }
}
