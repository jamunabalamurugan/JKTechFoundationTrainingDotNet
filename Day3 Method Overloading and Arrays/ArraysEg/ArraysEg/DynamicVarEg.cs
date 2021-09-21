﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class DynamicVarEg
    {
        static int Add(int a,int b)
        {
            return a + b;
        }
        static float Add(float a,float b)
        {
            return a + b;
        }
        public static void Main()
        {

            var studentid = 11;//The data type is assigned according to the value assigned at the time of declarion itself
            var studentname = "Kavin";
            var dob = "06/01/2011";
            var marks = 99.6;//Implicitly typed
            double fees = 20000;//Exlicitly typed
            var age = 23f;
            //age = "twenty three"; The var datatype cannot be changed....only value can changed
            studentid = 45;
            var aggregatemarks = 89.45d;
            var age1 = 25.3f;
            //dynamic age = null; Error as null expression cannot be assigned to dynamic type
           /* dynamic type:
▪ The dynamic type indicates that use of the variable and references to its members bypass compiletime type checking.
▪ Instead, these operations are resolved at run time.
▪ Type dynamic behaves like type object in most circumstances. 
▪ Any non-null expression can be converted to the dynamic type. 
▪ The dynamic type differs from object in that operations that contain expressions of type dynamic are
not resolved or type checked by the compiler.
▪ The compiler packages together information about the operation, and that information is later used
to evaluate the operation at run time.
▪ As part of the process, variables of type dynamic are compiled into variables of type object.
Therefore, type dynamic exists only at compile time, not at run time.*/



            dynamic city;//it is not type specific
            Console.WriteLine("Enter the City");
            city = DateTime.Parse(Console.ReadLine());
            var city1 = Console.ReadLine();
            if(city.Contains("D"))
                Console.WriteLine("Dynamic City");

            if(city1.Contains("C"))
                Console.WriteLine("Welcome");

            city = 1;
            city = 34.4f;
            var result = Add(12, 15);//it is type specific
            var result1 = Add(12.3f, 15.1f);

            Console.WriteLine(result+","+result1);
            Console.ReadKey();
        }
    }
}
