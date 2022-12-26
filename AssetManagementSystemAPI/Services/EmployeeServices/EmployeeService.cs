using AssetManagementSystemAPI.DTO;
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
            emp.status = true;
            emp.CrteatedDate = DateTime.Now;
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public List<EmployeeDTO> getEmployeeDetailsList()
        {
            var EmployeeList = (from emp in context.Employees
                               join dpt in context.Department on emp.DepartmentId equals dpt.id
                               join loc in context.Location on emp.LocationId equals loc.Id
                               where emp.status != false
                               select new EmployeeDTO
                               {
                                   Id=emp.Id,
                                   EmployeeId = emp.EmployeeId,
                                   Name=emp.Name,
                                   PhoneNumber=emp.PhoneNumber,
                                   Location=loc.LocationName,
                                   Department=dpt.DepartmentName,
                                   CrteatedDate=emp.CrteatedDate   
                               }).ToList();
            return EmployeeList;
        }

        public void deleteEmployee(int id)
        {

            var data = context.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                data.status = false;
                context.SaveChanges();
            }
        }

        public Employees GetEditEmployee(int id)
        {
            var data = context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        public void EditEmployeeForm(Employees data)
        {
            var Employeedata = context.Employees.Where(x => x.Id == data.Id).FirstOrDefault();
            if (Employeedata != null)
            {
                Employeedata.EmployeeId = data.EmployeeId ;
                Employeedata.Name = data.Name;
                Employeedata.LocationId = data.LocationId;
                Employeedata.DepartmentId = data.DepartmentId;
                Employeedata.ModifiedDate = DateTime.Now;
                Employeedata.PhoneNumber = data.PhoneNumber;
                context.SaveChanges();
            }
        }

    }
}
