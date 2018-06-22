using System.Linq;
using CoursesStore.Data.SqlServer.DataContexts;
using CoursesStore.Data.SqlServer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;

namespace CourseStore.Data.SqlServer.IntegrationTests
{
	[TestClass]
	[TestCategory("Database_Integration")]
	public class StudentRepositoryIntergationTests :
		DbRepositoryTestBase<CoursesDataContext, StudentRepository>
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
		public void StudentsShouldBeReturnedFromDbTest()
		{
			var students = _repository.GetStudents().ToList();
			Assert.AreNotEqual(students.Count, 0);
		}
	}
}
