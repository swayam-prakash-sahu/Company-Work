using System;
using Iter.CollegeManagement.PersonDetails;

namespace Iter.CollegeManagement.StudentDetails
{
    public class Student: Person
    {
        public string Name;

        public int Id { get; set; }

        public string Course {  get; set; } 

        public Student(string name, int id, string course)
        {
            this.Name = name;
            this.Id = id;
            this.Course = course;
        }

        public override void display()
        {
            Console.WriteLine($"{this.Name} {this.Id} {this.Course}");
        }
    }
}