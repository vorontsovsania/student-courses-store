using System;

namespace CoursesStore.Data.Filters
{
	public class StudentsListFilter
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? BirthDate { get; set; }
	}
}
