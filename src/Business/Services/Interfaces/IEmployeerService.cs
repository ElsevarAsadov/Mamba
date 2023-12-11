using Core.Models;
using Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface IEmployeerService
    {
        public IEmployeeRepository EmployeeRepo { get; }
        public Task<List<Employeer>> GetAllEmployees();

        public Task CreateNewEmployee(Employeer newEmp);
    }
}
