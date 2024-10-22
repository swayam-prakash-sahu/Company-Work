using System;
using System.Collections.Generic;
using Iter.CollegeManagement.TeacherDetails;
using Iter.CollegeManagement.StudentDetails;

namespace Iter.CollegeManagement.SectionDetails
{
	public class Section
	{
		public List<Teacher> TeachersName { get; set; }

		public List<Student> Students { get; set; } = new() { };

		public Section(Teacher teacherName)
		{
			this.TeachersName = new()
			{
				new(){Name = teacherName.Name, Id = teacherName.Id},
			};
		}

		public Section(Teacher teacherName, List<Student> studentName)
		{
			this.TeachersName = new() { new() { Name = teacherName.Name, Id = teacherName.Id } };
			this.Students = new() { studentName };
		}

		public void display()
		{
			Console.WriteLine("This section includes");
			Console.WriteLine(String.Join(", ", TeachersName));	
			Console.WriteLine(String.Join(", ", Students));
		}
	}
}