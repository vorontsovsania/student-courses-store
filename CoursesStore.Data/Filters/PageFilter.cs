using CoursesStore.Common.Paging;

namespace CoursesStore.Data.Filters
{
    public class PageFilter<T>
    {
	    public T Filter { get; set; }
	    public Pager Pager { get; set; }
    }
}
