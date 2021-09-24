using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug11
{   

    class Student
    {
        string id;
        string name;
        DateTime dateOfBirth;
       

        public Student(string id, string name, DateTime dateOfBirth)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public string Id
        {
          get {return id;}
          set {id = value;}
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
            return "\"ID:{0}\tName:{1}\tDate of Birth:{2}\",id,name,dateOfBirth";
        }
    }
    
}
