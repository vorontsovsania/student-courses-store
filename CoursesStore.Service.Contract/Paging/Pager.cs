using System.ComponentModel.DataAnnotations;

namespace CoursesStore.Service.Contract.Paging
{
	public class Pager
	{
		[Required]
		public int PageNumber { get; set; }

		[Required]
		public int PageSize { get; set; }
	}
}
