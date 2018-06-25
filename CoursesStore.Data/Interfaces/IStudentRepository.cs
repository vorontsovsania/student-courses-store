using System.Collections.Generic;
using CoursesStore.Data.Entities;

namespace CoursesStore.Data.Interfaces
{
	public interface IStudentRepository
	{
		IEnumerable<Student> GetStudents();

		Student GetStudent(int studentId);

		int AddStudent(Student student);
	}
}
