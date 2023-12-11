using Business.Services.Interfaces;
using Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.implementations
{
    public class EmployeePositionService : IEmployeePositionService
    {
        public IEmployeePositionRepository EmployeePositionRepo { get; }

        public EmployeePositionService(IEmployeePositionRepository employeePositionRepo)
        {
            EmployeePositionRepo = employeePositionRepo;
        }
    }
}
