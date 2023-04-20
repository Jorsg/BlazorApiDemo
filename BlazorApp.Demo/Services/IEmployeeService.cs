using DemoModels.Models;

namespace BlazorApp.Demo.Services
{
	public interface IEmployeeService
	{
		Task<List<Employee>> GetEmployees();
	}
}
