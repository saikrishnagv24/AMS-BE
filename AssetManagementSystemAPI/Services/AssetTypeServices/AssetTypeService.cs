using AssetManagementSystemAPI.Interfaces.AssetTypeInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagementSystemAPI.Services.AssetTypeServices
{
    public class AssetTypeService : IAssetTypeInterface
    {
        private readonly AmsDBContext context;
        public AssetTypeService(AmsDBContext _context)
        {
            context = _context;
        }
        public void PostAssetType(AssetType reg)
        {
            reg.status = true;
            reg.CreateDate = DateTime.Now;
            context.AssetType.Add(reg);
            context.SaveChanges();
        }

        public List<AssetType> getAssetType()
        {
            var data = from at in context.AssetType
                       select new AssetType
                       {
                           Id = at.Id,
                           AssetTypeName = at.AssetTypeName
                       };
            return data.ToList();
        }

        public void putAssetType(int id)
        {
            var data = context.AssetType.Where(x => x.Id == id).FirstOrDefault();
            if(data != null)
            {

            }
        }


        public void deleteAssetType(int id)
        {
            var data = context.AssetType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                context.AssetType.Remove(context.AssetType.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
        }

        public AssetType getEditAssetType(int id)
        {
            var data = from at in context.AssetType
                       where at.Id == id
                       select new AssetType
                       {
                           Id = at.Id,
                           AssetTypeName = at.AssetTypeName
                       };
            return data.FirstOrDefault();
        }

        public void putAssetTypeEdited(AssetType reg)
        {
            
            var data = context.AssetType.Where(x=>x.Id == reg.Id).FirstOrDefault();
            if(data != null)
            {
                data.Id = reg.Id;
                data.AssetTypeName = reg.AssetTypeName;
                context.SaveChanges();
            }
        }
    }
}
