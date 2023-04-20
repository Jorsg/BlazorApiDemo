using DemoModels.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
		}

		[HttpGet]
		[Route("GetEmployees")]
		public async Task<IActionResult> GetEmployee()
		{
			return Ok( await _employeeService.GetEmployees());
		}
	}
}
