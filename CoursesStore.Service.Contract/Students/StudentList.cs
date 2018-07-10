using System.Collections.Generic;

namespace CoursesStore.Service.Contract.Students
{
	public class StudentList
	{
		public IEnumerable<StudentListItem> Students { get; set; }

		public int Total { get; set; }
	}
}
