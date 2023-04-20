using DemoModels.Models;

namespace BlazorApp.Demo.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly HttpClient _httpClient;

		public EmployeeService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<Employee>> GetEmployees()
		{
			var result = await _httpClient.GetFromJsonAsync<List<Employee>>("/api/Employee/GetEmployees");
			return result.ToList();
		}
	}
}
