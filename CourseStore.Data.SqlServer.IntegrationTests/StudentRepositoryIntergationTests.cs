using System;
using System.Linq;
using CoursesStore.Data.Entities;
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

		[TestMethod]
		public void AddingStudentShouldBeSuccessfullyTest()
		{
			UseNonCommittedTransaction(() =>
			{
				Student student = new Student
				{
					FirstName = "First Name",
					LastName = "Last Name",
					BirthDate = DateTime.Now.AddYears(-23)
				};

				int studentId = _repository.AddStudent(student);
				Student dbStudent = _repository.GetStudent(studentId);

				Assert.AreNotEqual(studentId, 0);
				Assert.AreEqual(student.FirstName, dbStudent.FirstName);
				Assert.AreEqual(student.LastName, dbStudent.LastName);
			});
		}
	}
}
