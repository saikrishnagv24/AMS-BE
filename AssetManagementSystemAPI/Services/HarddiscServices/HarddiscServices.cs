using AssetManagementSystemAPI.Interfaces.HarddiscInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.HarddiscServices
{
    public class HarddiscServices : IHarddiscInterface
    {
        private readonly AmsDBContext context;
        public HarddiscServices(AmsDBContext _context)
        {
            context = _context;
        }

        public void PostHarddiscType(HarddiscType reg)
        {
            reg.status = true;
            reg.CreateDate = DateTime.Now;
            context.HarddiscType.Add(reg);
            context.SaveChanges();
        }

        public List<HarddiscType> getHarddiscType()
        {
            var data = from at in context.HarddiscType
                       select new HarddiscType
                       {
                           Id = at.Id,
                           HarddiscTypeName = at.HarddiscTypeName
                       };
            return data.ToList();
        }

        public void putHarddiscType(int id)
        {
            var data = context.HarddiscType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {

            }
        }

        public void deleteHarddiscType(int id)
        {
            var data = context.HarddiscType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                context.HarddiscType.Remove(context.HarddiscType.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
        }

        public HarddiscType getEditHarddiscType(int id)
        {
            var data = from at in context.HarddiscType
                       where at.Id == id
                       select new HarddiscType
                       {
                           Id = at.Id,
                           HarddiscTypeName = at.HarddiscTypeName
                       };
            return data.FirstOrDefault();
        }

        public void putHarddiscTypeEdited(HarddiscType reg)
        {

            var data = context.HarddiscType.Where(x => x.Id == reg.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = reg.Id;
                data.HarddiscTypeName = reg.HarddiscTypeName;
                context.SaveChanges();
            }
        }
    }
}
