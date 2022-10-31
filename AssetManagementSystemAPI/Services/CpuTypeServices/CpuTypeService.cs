using AssetManagementSystemAPI.Interfaces.CpuInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.CpuTypeServices
{
    public class CpuTypeService : ICpuTypeInterface
    {
        private readonly AmsDBContext context;
        public CpuTypeService(AmsDBContext _context)
        {
            context = _context;
        }
        public void PostCpuType(CpuType reg)
        {
            reg.status = true;
            reg.CreateDate = DateTime.Now;
            context.CpuType.Add(reg);
            context.SaveChanges();
        }

        public List<CpuType> getCpuType()
        {
            var data = from at in context.CpuType
                       select new CpuType
                       {
                           Id = at.Id,
                           CpuTypeName = at.CpuTypeName
                       };
            return data.ToList();
        }

        public void putCpuType(int id)
        {
            var data = context.CpuType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {

            }
        }


        public void deleteCpuType(int id)
        {
            var data = context.CpuType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                context.CpuType.Remove(context.CpuType.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
        }

        public CpuType getEditCpuType(int id)
        {
            var data = from at in context.CpuType
                       where at.Id == id
                       select new CpuType
                       {
                           Id = at.Id,
                           CpuTypeName = at.CpuTypeName
                       };
            return data.FirstOrDefault();
        }

        public void putCpuTypeEdited(CpuType reg)
        {

            var data = context.CpuType.Where(x => x.Id == reg.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = reg.Id;
                data.CpuTypeName = reg.CpuTypeName;
                context.SaveChanges();
            }
        }
    }
}
