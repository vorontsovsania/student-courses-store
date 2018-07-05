using System.Linq;

namespace CoursesStore.Common.Paging
{
	public class Pager
	{
		public int PageNumber { get; set; }
		public int PageSize { get; set; }

		public IQueryable<T> SkipAndTake<T>(IQueryable<T> source)
		{
			return source
				.Skip((PageNumber - 1) * PageSize)
				.Take(PageSize);
		}
	}
}
