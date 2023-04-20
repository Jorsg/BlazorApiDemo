using DemoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModels.Repositories
{
	public class EmployeesRepository : IEmployeeRepository
	{
		public async Task<List<Employee>> GetEmployeeAll()
		{
			List<Employee> employees = new List<Employee>();

			Employee employee = new Employee();
			employee.EmpId = 1;
			employee.Name = "Test1";
			employees.Add(employee);

			employee = new Employee();
			employee.EmpId = 2;
			employee.Name = "Test2";
			employees.Add(employee);

			return employees;
		}
	}
}
