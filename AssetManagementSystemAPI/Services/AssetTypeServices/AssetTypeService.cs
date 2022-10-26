using AssetManagementSystemAPI.Interfaces.AssetTypeInterface;
using AssetManagementSystemAPI.Model;
using System;

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
    }
}
