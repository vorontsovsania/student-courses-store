using System.ComponentModel.DataAnnotations;

namespace CoursesStore.Service.Contract.Paging
{
    public class Pager
    {
        //todo add custom validation: Min(1)
        [Required]
        public int PageNumber { get; set; }

        [Required]
        public int PageSize { get; set; }
    }
}
