/*using System;
using System.Collections.Generic;
namespace Practice_task_20
{
    class student : IComparable
    {
        public int Number;
        public string Nameofthestudent;


        public student(int number, string nameofthestudent)
        {
            Number = number;
            Nameofthestudent = nameofthestudent;
        }
        public int CompareTo(object object1)
        {
            student object2 = object1 as student;

            return this.Number.CompareTo(object2.Number);
        }


    }

    class class2
    {
        public static void Main(String[] args)
        {
            student[] students = new student[]
            {
        new student(1, "rakesh"),
        new student(5, "arun"),
        new student(3, "mani"),
        new student(2, "Mohit"),
        new student(4, "maesh")

            };

            Console.Write("before using icomparable");
            foreach (var stu in students)
            {
                Console.WriteLine("ID - {0}, student name - {1}",
                                  stu.Number, stu.Nameofthestudent);
            }

            Array.Sort(students);
            Console.WriteLine("after using icomparable");
            foreach (var stu in students)
            {
                Console.WriteLine("ID - {0}, student name - {1}",
                                  stu.Number, stu.Nameofthestudent);
            }
        }
    }
}*/