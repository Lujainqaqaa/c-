using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student Name :");
            string studentName = Console.ReadLine();

            Console.Write("Enter student Age :");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student Grade :");
            string studentGrade = Console.ReadLine();

            Console.Write("Student Average :");
            double studentAverage = Convert.ToDouble(Console.ReadLine());


            Console.Write("student Gender :");
            char studentGender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===== Student Report =====");
            Console.WriteLine("Welcome" + "sami" + "Ali!");



            Console.WriteLine($"Welcome {studentName}!");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade} ");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");




            Console.WriteLine();
            Console.WriteLine("===== Name Information =====");
            Console.WriteLine($"original Name: {studentName}");
            Console.WriteLine($"Uppercase Name: {studentName.ToUpper()}");
            Console.WriteLine($"Lowercase Name: {studentName.ToLower()}");
            Console.WriteLine($"First character: {studentName[0]}");


            double bonusMarks = 5;
            double newAverage = studentAverage + bonusMarks;

            Console.WriteLine($"original Average:{studentAverage}");
            Console.WriteLine($"Bonus Marks: {bonusMarks}");
            Console.WriteLine($"New Average: {newAverage}");



            bool passed = newAverage >= 50;
            bool adult = studentAge >= 18;

            Console.WriteLine("\n===== Student Status =====");

            Console.WriteLine($"New Average: {newAverage}");
            Console.WriteLine($"Passed: {passed}");
            Console.WriteLine($"Adult: {adult}");







            Console.WriteLine("\n================================");
            Console.WriteLine("        STUDENT SUMMARY");
            Console.WriteLine("================================");

            Console.WriteLine($"Welcome {studentName.ToUpper()}!");

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");











        }
    }
}

