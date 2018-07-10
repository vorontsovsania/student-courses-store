using System;

namespace CoursesStore.Service.Contract.Students
{
	public class StudentListRequestFilter
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? BirthDate { get; set; }
	}
}
