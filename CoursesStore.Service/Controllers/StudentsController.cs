using CoursesStore.Logic.Interfaces;
using CoursesStore.Service.Contract.Students;
using Microsoft.AspNetCore.Mvc;

namespace CoursesStore.Service.Controllers
{
	[Route("students")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IStudentManager _studentManager;

		public StudentsController(IStudentManager studentManager)
		{
			_studentManager = studentManager;
		}

		[HttpPut]
		[Route("")]
		public IActionResult GetStudents([FromBody] StudentListRequest reguest)
		{
			//todo add model validation, exception handling, logging
			var students = _studentManager.GetPagedStudents(reguest);
			return Ok(students);
		}
	}
}