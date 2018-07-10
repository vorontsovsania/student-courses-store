using CoursesStore.Service.Contract.Students;

namespace CoursesStore.Logic.Interfaces
{
	public interface IStudentManager
	{
		StudentList GetPagedStudents(StudentListRequest request);
	}
}
