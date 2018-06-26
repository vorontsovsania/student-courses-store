using System;
using CoursesStore.Data.Entities;

namespace Tests.Common.FakeData.Database
{
	public class StudentFakeBuilder
	{
		private readonly Student _student;

		public StudentFakeBuilder()
		{
			_student = new Student
			{
				FirstName = "First Name",
				LastName = "Last Name",
				BirthDate = DateTime.Now.AddYears(-23)
			};
		}

		public StudentFakeBuilder WithFirstName(string firstName)
		{
			_student.FirstName = firstName;
			return this;
		}

		public StudentFakeBuilder WithLastName(string lastName)
		{
			_student.LastName = lastName;
			return this;
		}

		public StudentFakeBuilder WithBirthDate(DateTime birthDate)
		{
			_student.BirthDate = birthDate;
			return this;
		}

		public Student Build()
		{
			return _student;
		}

		public static implicit operator Student(StudentFakeBuilder builder)
		{
			return builder.Build();
		}
	}
}
