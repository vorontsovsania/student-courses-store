using CoursesStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesStore.Data.SqlServer.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasKey(s => s.StudentId);
			builder.Property(t => t.FirstName)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(t => t.LastName)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(t => t.BirthDate)
				.IsRequired();
			builder.ToTable("Students");
		}
	}
}
