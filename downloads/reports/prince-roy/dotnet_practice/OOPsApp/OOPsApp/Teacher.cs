using System;
using Iter.CollegeManagement.PersonDetails;

namespace Iter.CollegeManagement.TeacherDetails
{

    public class Teacher : Person
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Teacher(string name, int id)
        {
            this.Name = name;
            this.Id= id;
        }

        public override void display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Id);
        }

    }
}