using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoursesStore.Service.Filters.Actions
{
	public class ValidateModelStateAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (!context.ModelState.IsValid)
			{
				//todo add logging
				context.Result = new BadRequestObjectResult(context.ModelState);
			}
		}
	}
}
