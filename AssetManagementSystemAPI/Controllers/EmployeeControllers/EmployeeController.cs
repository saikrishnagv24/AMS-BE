using AssetManagementSystemAPI.Interfaces.EmployeeInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.EmployeeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeInterface IemployeeInterface;
        public EmployeeController(IEmployeeInterface _EmployeeInterface)
        {
            IemployeeInterface = _EmployeeInterface;
        }

        [HttpPost]
        [Route("AddEmployeeForm")]
        public void PostAsset(Employees emp)
        {
            IemployeeInterface.addEmployee(emp);
        }
    }
}
