using System.Collections.Generic;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Interfaces;
using CoursesStore.Data.SqlServer.DataContexts;
using Microsoft.EntityFrameworkCore;

namespace CoursesStore.Data.SqlServer.Repositories
{
    public class CourseRepository : ICourseRepository
	{
		private readonly CoursesDataContext _dbContext;

		public CourseRepository(CoursesDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<Course> GetCourses()
		{
			return _dbContext.Courses
				.Include(x => x.CourseDirection);
		}
	}
}
