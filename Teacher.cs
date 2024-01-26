using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_01
{
    public class Teacher : Student // inherit student class
    {
        private string subject;

        // constructor for teacher
        public Teacher(int id, string firstName, string lastName, string subject) : base(id, firstName, lastName, 0)
        {
            // initializing the subject specifically for the teacher
            this.subject = subject;
        }

        // displaying the subject that teacher teaches
        public void Teach()
        {
            Console.WriteLine($"Mr./Ms. {lastName} is teaching {subject}.");
        }

        public override void DisplayAllDetails()
        {
            Console.WriteLine($"Last Name: {lastName}");
        }
    }
}
