using System.Collections.Generic;
using System.Linq;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Filters;
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

		public IEnumerable<Student> GetPagedStudents(PageFilter<StudentsListFilter> pagerFilter, out int totalSize)
		{
			var filtered = _dbContext.Students
				.Where(x => (string.IsNullOrEmpty(pagerFilter.Filter.FirstName) || x.FirstName.Contains(pagerFilter.Filter.FirstName))
					&& (string.IsNullOrEmpty(pagerFilter.Filter.LastName) || x.LastName.Contains(pagerFilter.Filter.LastName))
					&& (!pagerFilter.Filter.BirthDate.HasValue || x.BirthDate == pagerFilter.Filter.BirthDate)
				);

			totalSize = filtered.Count();

			return pagerFilter.Pager.SkipAndTake(filtered);
			//return filtered
			//	.Skip((pagerFilter.Pager.PageNumber - 1) * pagerFilter.Pager.PageSize)
			//	.Take(pagerFilter.Pager.PageSize);
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
