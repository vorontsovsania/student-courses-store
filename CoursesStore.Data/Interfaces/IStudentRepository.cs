using System.Collections.Generic;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Filters;

namespace CoursesStore.Data.Interfaces
{
	public interface IStudentRepository
	{
		IEnumerable<Student> GetStudents();

		IEnumerable<Student> GetPagedStudents(PageFilter<StudentsListFilter> pagerFilter);

		Student GetStudent(int studentId);

		int AddStudent(Student student);
	}
}
