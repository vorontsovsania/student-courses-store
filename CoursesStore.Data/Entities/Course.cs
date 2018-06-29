namespace CoursesStore.Data.Entities
{
	public class Course
	{
		public int CourseId { get; set; }
		public string Title { get; set; }
		public int CourseDirectionId { get; set; }
		public CourseDirection CourseDirection { get; set; }
	}
}
