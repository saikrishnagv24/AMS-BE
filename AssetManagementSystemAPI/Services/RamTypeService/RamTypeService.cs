using AssetManagementSystemAPI.Interfaces.RamTypeInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.RamTypeService
{
    public class RamTypeService : IRamTypeInterface
    {
        private readonly AmsDBContext context;
        public RamTypeService(AmsDBContext _context)
        {
            context = _context;
        }
        public void PostRamType(RamType reg)
        {
            reg.status = true;
            reg.CreateDate = DateTime.Now;
            context.RamType.Add(reg);
            context.SaveChanges();
        }

        public List<RamType> getRamType()
        {
            var data = from at in context.RamType
                       select new RamType
                       {
                           Id = at.Id,
                           RamTypeName = at.RamTypeName
                       };
            return data.ToList();
        }

        public void putRamType(int id)
        {
            var data = context.RamType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {

            }
        }


        public void deleteRamType(int id)
        {
            var data = context.RamType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                context.RamType.Remove(context.RamType.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
        }

        public RamType getEditRamType(int id)
        {
            var data = from at in context.RamType
                       where at.Id == id
                       select new RamType
                       {
                           Id = at.Id,
                           RamTypeName = at.RamTypeName
                       };
            return data.FirstOrDefault();
        }

        public void putRamTypeEdited(RamType reg)
        {

            var data = context.RamType.Where(x => x.Id == reg.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = reg.Id;
                data.RamTypeName = reg.RamTypeName;
                context.SaveChanges();
            }
        }
    }
}
