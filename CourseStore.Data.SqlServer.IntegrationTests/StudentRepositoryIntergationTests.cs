using System.Linq;
using CoursesStore.Common.Paging;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Filters;
using CoursesStore.Data.SqlServer.DataContexts;
using CoursesStore.Data.SqlServer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;
using FluentAssertions;
using Tests.Common.FakeData.Database;

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

		[TestMethod]
		public void PagedStudentsShouldBeReturnedFromDbTest()
		{
			PageFilter<StudentsListFilter> filter = new PageFilter<StudentsListFilter>
			{
				Filter = new StudentsListFilter
				{
					FirstName = "a"
				},
				Pager = new Pager
				{
					PageNumber = 2,
					PageSize = 7
				}
			};
			int total;
			int dbTotalCount = 26;
			var students = _repository.GetPagedStudents(filter, out total).ToList();
			Assert.AreEqual(students.Count, filter.Pager.PageSize);
			total.Should().Be(dbTotalCount);
		}

		[TestMethod]
		public void AddingStudentShouldBeSuccessfullyTest()
		{
			UseNonCommittedTransaction(() =>
			{
				Student student = new StudentFakeBuilder(); //.Build();

				int studentId = _repository.AddStudent(student);
				Student dbStudent = _repository.GetStudent(studentId);

				Assert.AreNotEqual(studentId, 0);
				studentId.Should().NotBe(0);
				Assert.AreEqual(student.FirstName, dbStudent.FirstName);
				student.FirstName.Should().Be(dbStudent.FirstName);
				Assert.AreEqual(student.LastName, dbStudent.LastName);
			});
		}
	}
}
