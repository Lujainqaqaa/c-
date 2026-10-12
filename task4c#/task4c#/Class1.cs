using System;

namespace SchoolSystem
{
    // Part 1: Create Student Class
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        // Part 5: Constructor
        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Part 2: DisplayInfo Method
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine();
        }
    }

}