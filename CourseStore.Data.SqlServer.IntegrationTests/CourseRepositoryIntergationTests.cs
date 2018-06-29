using System.Linq;
using CoursesStore.Data.SqlServer.DataContexts;
using CoursesStore.Data.SqlServer.Repositories;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;

namespace CourseStore.Data.SqlServer.IntegrationTests
{
	[TestClass]
	[TestCategory("Database_Integration")]
	public class CourseRepositoryIntergationTests :
		DbRepositoryTestBase<CoursesDataContext, CourseRepository>
	{
		[TestInitialize]
		public void TestInitialize()
		{
			CreateRepository();
		}

		[TestCleanup]
		public void TestCleanup()
		{
			DisposeDbContext();
		}

		[TestMethod]
		public void CoursesShouldBeReturnedFromDbTest()
		{
			var courses = _repository.GetCourses().ToList();
			Assert.AreNotEqual(courses.Count, 0);
			courses.Count.Should().BeGreaterThan(0);
		}
	}
}
