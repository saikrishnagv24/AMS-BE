using AssetManagementSystemAPI.Interfaces.EmployeeInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly AmsDBContext context;

        public EmployeeService(AmsDBContext _context)
        {
            context = _context;
        }

        public void addEmployee(Employees emp)
        {

        }

    }
}
