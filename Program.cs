<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentname = "Lujain Khalid";
            int studentAge = 26;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char StudentGender = 'F';
            bool IsStudentActive = true;


            Console.WriteLine("Name:" + studentname);
            Console.WriteLine("age:" + studentAge);
            Console.WriteLine("Grade:" + studentGrade);
            Console.WriteLine("Average:" + studentAverage);
            Console.WriteLine("Gender:" + StudentGender);
            Console.WriteLine("IsStudentActive:" + IsStudentActive);

            string[] Name = { "Lujain", "Khalid", "Ali", "Sara" };
            
            Console.WriteLine("StudentNames1:" + Name[0]);
            Console.WriteLine("StudentNames2:" + Name[1]);
            Console.WriteLine("StudentNames3:" + Name[2]);
            Console.WriteLine("StudentNames4:" + Name[3]);
            Console.WriteLine("Number of Students:" + Name.Length);

            Console.WriteLine();

            Console.WriteLine("==========before====");

            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);


            Console.WriteLine();

            Console.WriteLine("==========after====");

            Name[2] = "mohammad";
            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);





        }
    }
}






=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentname = "Lujain Khalid";
            int studentAge = 26;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char StudentGender = 'F';
            bool IsStudentActive = true;


            Console.WriteLine("Name:" + studentname);
            Console.WriteLine("age:" + studentAge);
            Console.WriteLine("Grade:" + studentGrade);
            Console.WriteLine("Average:" + studentAverage);
            Console.WriteLine("Gender:" + StudentGender);
            Console.WriteLine("IsStudentActive:" + IsStudentActive);

            string[] Name = { "Lujain", "Khalid", "Ali", "Sara" };
            
            Console.WriteLine("StudentNames1:" + Name[0]);
            Console.WriteLine("StudentNames2:" + Name[1]);
            Console.WriteLine("StudentNames3:" + Name[2]);
            Console.WriteLine("StudentNames4:" + Name[3]);
            Console.WriteLine("Number of Students:" + Name.Length);

            Console.WriteLine();

            Console.WriteLine("==========before====");

            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);


            Console.WriteLine();

            Console.WriteLine("==========after====");

            Name[2] = "mohammad";
            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);





        }
    }
}






>>>>>>> 24c2e101053dd182147f48f7a5b79baa5d2873c6
