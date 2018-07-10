using System;

namespace CoursesStore.Service.Contract.Students
{
	public class StudentListItem
	{
		public int StudentId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
	}
}
