using System.Collections.Generic;
using System.Linq;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Interfaces;
using CoursesStore.Data.SqlServer.DataContexts;

namespace CoursesStore.Data.SqlServer.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly CoursesDataContext _dbContext;

		public StudentRepository(CoursesDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<Student> GetStudents()
		{
			return _dbContext.Students.AsEnumerable();
		}

		public Student GetStudent(int studentId)
		{
			return _dbContext.Students
				.FirstOrDefault(x => x.StudentId == studentId);
		}

		public int AddStudent(Student student)
		{
			_dbContext.Students.Add(student);
			_dbContext.SaveChanges();
			return student.StudentId;
		}
	}
}
