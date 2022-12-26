using AssetManagementSystemAPI.DTO;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.EmployeeInterface
{
    public interface IEmployeeInterface
    {
        public void addEmployee(Employees emp);

        public List<EmployeeDTO> getEmployeeDetailsList();

        public void deleteEmployee(int id);

        public Employees GetEditEmployee(int id);

        public void EditEmployeeForm(Employees data);
    }
}
