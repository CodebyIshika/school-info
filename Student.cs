using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_01
{
    public class Student
    {
        // student information
        private int studentID;
        private string firstName;
        protected string lastName; // Protected to allow access in child class - teacher
        private double grade;

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade
        {
            get { return grade; }

            set
            {
                // validating the grades
                if( value >= 0 && value <= 100 )
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Error: Grade can be only between 0 and 100.");
                }
            }
        }

        /// <summary>
        /// this is a default constructor
        /// </summary>
        public Student()
        {
            studentID = 0;
            firstName = null;
            lastName = null;
            grade = 0;
        }

        /// <summary>
        /// paramerized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="grade"></param>
        public Student(int id, string firstName, string lastName, double grade)
        {
            this.studentID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        // student details are displayed
        public virtual void DisplayAllDetails()
        {
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
