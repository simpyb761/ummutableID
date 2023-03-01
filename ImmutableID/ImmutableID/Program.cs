using System;
using static System.Console;

namespace immutableID
{
    class Program
    {
         static void Main(string[] args)
        {
            Student firstStudent = new Student(10);
            firstStudent.FirstName = "Luxanna";
            firstStudent.LastName = "Crownguard";
            Student secondStudent = new Student(20, "Garen", "Crownguard");
            WriteLine($"Student {firstStudent.Id}: {firstStudent.FirstName} {firstStudent.LastName}");
            WriteLine($"Student {secondStudent.Id}: {secondStudent.FirstName} {secondStudent.LastName}");
        }
    }
    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        public Student(int i)
        {
            Id = i;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

    }
}