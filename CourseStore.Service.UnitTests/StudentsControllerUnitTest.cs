using System.Collections.Generic;
using CoursesStore.Logic.Interfaces;
using CoursesStore.Service.Contract.Paging;
using CoursesStore.Service.Contract.Students;
using CoursesStore.Service.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CourseStore.Service.UnitTests
{
    [TestClass]
    [TestCategory("Service_UnitTesting")]
    public class StudentsControllerUnitTest
    {
        [TestMethod]
        public void StudentListShouldBeReturnedTest()
        {
            StudentListRequest request = CreateFilter();
            Mock<IStudentManager> manager = new Mock<IStudentManager>();
            manager.Setup(x => x.GetPagedStudents(It.IsAny<StudentListRequest>()))
                .Returns(new StudentList
                {
                    Students = new List<StudentListItem>
                    {
                        new StudentListItem
                        {
                            FirstName = "Test name"
                        }
                    },
                    Total = 7
                });

            StudentsController controller = new StudentsController(manager.Object);

            var result = controller.GetStudents(request);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var data = ((OkObjectResult)result).Value;
            Assert.IsNotNull(data);
            Assert.IsInstanceOfType(data, typeof(StudentList));
            var studentList = (StudentList)data;
            Assert.AreEqual(studentList.Total, 7);
        }

        private StudentListRequest CreateFilter()
        {
            return new StudentListRequest
            {
                Filter = new StudentListRequestFilter
                {
                    FirstName = "test"
                },
                Pager = new Pager
                {
                    PageNumber = 1,
                    PageSize = 2
                }
            };
        }
    }
}
