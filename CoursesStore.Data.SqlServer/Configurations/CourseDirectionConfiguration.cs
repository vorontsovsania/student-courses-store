using CoursesStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesStore.Data.SqlServer.Configurations
{
	public class CourseDirectionConfiguration : IEntityTypeConfiguration<CourseDirection>
	{
		public void Configure(EntityTypeBuilder<CourseDirection> builder)
		{
			builder.HasKey(s => s.CourseDirectionId);
			builder.Property(t => t.Title)
				.IsRequired()
				.HasMaxLength(100);
			builder.ToTable("CourseDirections");
		}
	}
}
