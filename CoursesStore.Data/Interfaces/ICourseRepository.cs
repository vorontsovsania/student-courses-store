using System.Collections.Generic;
using CoursesStore.Data.Entities;

namespace CoursesStore.Data.Interfaces
{
	public interface ICourseRepository
	{
		IEnumerable<Course> GetCourses();
	}
}
