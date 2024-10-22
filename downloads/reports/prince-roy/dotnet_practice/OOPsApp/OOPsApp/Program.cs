using System;
using Iter.CollegeManagement.TeacherDetails;
using Iter.CollegeManagement.StudentDetails;
using Iter.CollegeManagement.SectionDetails;

namespace Iter.CollegeManagement.Implemention
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Teacher t = new Teacher("Ashish", 35);

            Student s1 = new Student("Prince Roy", 21, "B.Tech");
            Student s2 = new Student("Pritam Roy", 19, "BBA");

            List<Student> listOfStudents = new List<Student> { s1, s2 };

            Section section = new Section(t, listOfStudents);
            section.display();

            
        }
    }
}