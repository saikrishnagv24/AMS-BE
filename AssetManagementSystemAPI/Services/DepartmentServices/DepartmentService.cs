using AssetManagementSystemAPI.Interfaces.DepartmentInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentInterface
    {
        private readonly AmsDBContext context;
        public DepartmentService(AmsDBContext _context)
        {
            context = _context;
        }
        public void PostDepartment(Department reg)
        {
            reg.DeleteStatus = true;
            reg.CreateDate = DateTime.Now;
            context.Department.Add(reg);
            context.SaveChanges();
        }

        public List<Department> getDepartment()
        {
            var data = from at in context.Department
                       select new Department
                       {
                           id = at.id,
                           DepartmentName = at.DepartmentName,
                           Description = at.Description
                       };
            return data.ToList();
        }

        public void putDepartment(int id)
        {
            var data = context.Department.Where(x => x.id == id).FirstOrDefault();
            if (data != null)
            {

            }
        }


        public void deleteDepartment(int id)
        {
            var data = context.Department.Where(x => x.id == id).FirstOrDefault();
            if (data != null)
            {
                context.Department.Remove(context.Department.FirstOrDefault(x => x.id == id));
                context.SaveChanges();
            }
        }

        public Department getEditDepartment(int id)
        {
            var data = from at in context.Department
                       where at.id == id
                       select new Department
                       {
                           id = at.id,
                           DepartmentName = at.DepartmentName,
                           Description = at.Description
                       };
            return data.FirstOrDefault();
        }

        public void putDepartmentEdited(Department reg)
        {

            var data = context.Department.Where(x => x.id == reg.id).FirstOrDefault();
            if (data != null)
            {
                data.id = reg.id;
                data.DepartmentName = reg.DepartmentName;
                data.Description = reg.Description;
                context.SaveChanges();
            }
        }
    }
}
