using System.ComponentModel.DataAnnotations;
using CoursesStore.Service.Contract.Paging;

namespace CoursesStore.Service.Contract.Students
{
	public class StudentListRequest
	{
		//todo adding sorting

		public StudentListRequestFilter Filter { get; set; }

		[Required]
		public Pager Pager { get; set; }
	}
}
