using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.DepartmentInterface
{
    public interface IDepartmentInterface
    {
        public void PostDepartment(Department reg);

        public List<Department> getDepartment();

        public void putDepartment(int id);

        public void deleteDepartment(int id);

        public Department getEditDepartment(int id);

        public void putDepartmentEdited(Department reg);
    }
}
