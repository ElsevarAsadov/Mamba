using Business.Services.Interfaces;
using Core.Models;
using Core.Repositories.Interfaces;
using Data.DAL;
using Data.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.implementations
{
    public class EmployeerService : IEmployeerService
    {
        public IEmployeeRepository EmployeeRepo { get; }
        public EmployeerService(IEmployeeRepository employeeRepo)
        {
            EmployeeRepo = employeeRepo;
        }


        public async Task<List<Employeer>> GetAllEmployees()
        {
            return await EmployeeRepo.GetAllAsync(includedTables: new string[] {"Position", "SocialMediaAccounts"});
        }

        public async Task CreateNewEmployee(Employeer newEmp)
        {
            await EmployeeRepo.Create(newEmp);
        }
    }
}
