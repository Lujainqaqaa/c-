
using System;

namespace task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Student
            Student s1 = new Student("lujain", 25, "ajloun", 85, 10);
            Student s2 = new Student("sara", 24, "ajloun", 80, 8);

            s1.DisplayInfo();
            s1.DisplayStudentInfo();

            s2.DisplayInfo();
            s2.DisplayStudentInfo();

            Console.WriteLine("-------****--------");

            // Teacher
            Teacher t1 = new Teacher("leen", 21, "ajloun", "Science");
            t1.DisplayTeacherInfo();

            Console.WriteLine("--------****-------");

            // SchoolReport
            SchoolReport report = new SchoolReport("Final Exam Results");
            report.DisplayReportTitle();

            // Console.WriteLine(s1.SchoolName);
            // Error: SchoolName is protected.

            // Console.WriteLine(s1._internalCode);
            // Error: _internalCode is private.
        }
    }
}