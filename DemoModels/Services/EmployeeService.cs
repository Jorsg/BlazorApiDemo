using DemoModels.Models;
using DemoModels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModels.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepo;

		public EmployeeService(IEmployeeRepository employeeRepo)
		{
			_employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
		}

		public Task<List<Employee>> GetEmployees()
		{
			return _employeeRepo.GetEmployeeAll();
		}
	}
}
