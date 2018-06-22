using CoursesStore.Data.SqlServer.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Tests.Common
{
	public static class DbContextHelper
	{
		public static CoursesDataContext CreateCoursesDbContext()
		{
			var configuration = ConfigurationHelper.GetConfiguration();
			var builder = new DbContextOptionsBuilder<CoursesDataContext>();
			builder.UseSqlServer(configuration.GetConnectionString("StudentCourseStoreDb"));
			return new CoursesDataContext(builder.Options);
		}
	}
}
