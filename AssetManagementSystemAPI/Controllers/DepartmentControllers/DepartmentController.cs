using AssetManagementSystemAPI.Interfaces.DepartmentInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.DepartmentControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentInterface departmentInterface;
        public DepartmentController(IDepartmentInterface _departmentInterface)
        {
            departmentInterface = _departmentInterface;
        }

        [HttpPost]
        [Route("DepartmentForm")]
        public void PostDepart(Department reg)
        {
            departmentInterface.PostDepartment(reg);
        }

        [HttpGet]
        [Route("GetDepartment")]
        public List<Department> GetDepartmet()
        {
            var data = departmentInterface.getDepartment();
            return data;
        }

        [HttpPut]
        [Route("GetDepartment/{id}")]
        public void PutDepartment(int id)
        {
            departmentInterface.putDepartment(id);
        }

        [HttpDelete]
        [Route("DeleteDepartment/{id}")]
        public void DeleteDepartment(int id)
        {
            departmentInterface.deleteDepartment(id);
        }

        [HttpGet]
        [Route("GetEditDepartment/{id}")]
        public Department GetEditDepartment(int id)
        {
            var data = departmentInterface.getEditDepartment(id);
            return data;
        }

        [HttpPut]
        [Route("EditDepartmentForm")]
        public void PutDepartmentEdited(Department reg)
        {
            departmentInterface.putDepartmentEdited(reg);
        }
    }
}
