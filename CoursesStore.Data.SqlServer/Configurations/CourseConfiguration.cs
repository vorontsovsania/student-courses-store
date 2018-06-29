using CoursesStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesStore.Data.SqlServer.Configurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(s => s.CourseId);
			builder.Property(t => t.Title)
				.IsRequired()
				.HasMaxLength(100);
			builder.Property(t => t.CourseDirectionId)
				.IsRequired();

			builder.HasOne(t => t.CourseDirection);

			builder.ToTable("Courses");
		}
	}
}
