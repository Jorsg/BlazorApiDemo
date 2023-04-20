using DemoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModels.Repositories
{
	public interface IEmployeeRepository
	{
		Task<List<Employee>> GetEmployeeAll();
	}
}
