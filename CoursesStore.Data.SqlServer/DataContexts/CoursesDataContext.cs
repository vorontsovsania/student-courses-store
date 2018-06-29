using CoursesStore.Data.Entities;
using CoursesStore.Data.SqlServer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CoursesStore.Data.SqlServer.DataContexts
{
	public class CoursesDataContext : DbContext
	{
		public CoursesDataContext(DbContextOptions<CoursesDataContext> options)
			: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<CourseDirection> CourseDirections { get; set; }
		public DbSet<Course> Courses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new StudentConfiguration());
			modelBuilder.ApplyConfiguration(new CourseDirectionConfiguration());
			modelBuilder.ApplyConfiguration(new CourseConfiguration());
		}
	}
}
