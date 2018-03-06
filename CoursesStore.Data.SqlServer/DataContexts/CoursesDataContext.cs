using System;
using System.Collections.Generic;
using System.Text;
using CoursesStore.Data.Entities;
using CoursesStore.Data.SqlServer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CoursesStore.Data.SqlServer.DataContexts
{
	public class CoursesDataContext : DbContext
	{
		public CoursesDataContext(DbContextOptions options)
			: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new StudentConfiguration());
		}
	}
}
