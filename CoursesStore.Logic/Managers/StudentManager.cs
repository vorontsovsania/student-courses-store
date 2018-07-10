using System.Linq;
using CoursesStore.Common.Paging;
using CoursesStore.Data.Entities;
using CoursesStore.Data.Filters;
using CoursesStore.Data.Interfaces;
using CoursesStore.Logic.Interfaces;
using CoursesStore.Service.Contract.Students;

namespace CoursesStore.Logic.Managers
{
	public class StudentManager : IStudentManager
	{
		private readonly IStudentRepository _studentRepository;

		public StudentManager(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public StudentList GetPagedStudents(StudentListRequest request)
		{
			PageFilter<StudentsListFilter> filter = CreateFilter(request);

			int total;
			var dbStudents = _studentRepository.GetPagedStudents(filter, out total);

			StudentList students = new StudentList
			{
				Students = dbStudents.Select(MapStudentListItem),
				Total = total
			};
			return students;
		}

		private StudentListItem MapStudentListItem(Student dbStudent)
		{
			return new StudentListItem
			{
				StudentId = dbStudent.StudentId,
				FirstName = dbStudent.FirstName,
				LastName = dbStudent.LastName,
				BirthDate = dbStudent.BirthDate
			};
		}

		private PageFilter<StudentsListFilter> CreateFilter(StudentListRequest request)
		{
			var filter = new PageFilter<StudentsListFilter>();
			filter.Filter = new StudentsListFilter
			{
				FirstName = request.Filter?.FirstName,
				LastName = request.Filter?.LastName,
				BirthDate = request.Filter?.BirthDate
			};
			filter.Pager = new Pager
			{
				PageNumber = request.Pager.PageNumber,
				PageSize = request.Pager.PageSize
			};
			return filter;
		}
	}
}
