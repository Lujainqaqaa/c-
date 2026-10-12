using SchoolSystem;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Part 3 & 4: Create Three Objects
        Student student1 = new Student("Ahmad", 20, 85);
        Student student2 = new Student("Sara", 21, 92);
        Student student3 = new Student("Omar", 19, 78);

        // Display Students Information
        Console.WriteLine("===== Student Information =====");
        Console.WriteLine();

        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

        Console.ReadKey();
    }
}
