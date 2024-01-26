using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object of student class
            Student studentObj = new Student();

            // default constructor
            Console.WriteLine("The output of Default Constructor :");
            studentObj.DisplayAllDetails();
            Console.WriteLine("\n");

            // parameterized constructor
            Student parameterizedConstructor = new Student(1001, "Aaron", "Blackford", 90.5);
            Console.WriteLine("The output of Parameterized Constructor :");
            parameterizedConstructor.DisplayAllDetails();
            Console.WriteLine("\n");

            // teacher object
            Teacher teacherObj = new Teacher(2005, "Elena", "Johnson", "English");
            Console.WriteLine("Teachers Details : ");
            teacherObj.DisplayAllDetails();
            Console.WriteLine("");
            teacherObj.Teach();

            Console.ReadKey();

        }
    }
}
