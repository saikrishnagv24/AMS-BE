using AssetManagementSystemAPI.DTO;
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

        [HttpGet]
        [Route("GetEmployeeList")]
        public List<EmployeeDTO> getEmployeeDetails()
        {
            var employeeList = IemployeeInterface.getEmployeeDetailsList();
            return employeeList;
        }

        [HttpPut]
        [Route("DeleteEmployee/{id}")]
        public void DeleteEmployee(int id)
        {
            IemployeeInterface.deleteEmployee(id);
        }

        [HttpGet]
        [Route("GetEditEmployee/{id}")]
        public Employees GetEditEmployees(int id)
        {
            var editEmployee = IemployeeInterface.GetEditEmployee(id);
            return editEmployee;
        }

        [HttpPut]
        [Route("EditEmployeeForm")]
        public void EditEmployeeForm(Employees data)
        {
            IemployeeInterface.EditEmployeeForm(data);
        }
    }
}
