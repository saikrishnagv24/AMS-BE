using AssetManagementSystemAPI.Interfaces.AddAssetInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.AddAssetServices
{
    public class AddAssetService : IAddAssetInterface
    {
        private readonly AmsDBContext context;
        public AddAssetService(AmsDBContext _context)
        {
            context = _context;
        }
        public void PostAddAsset(AddAsset reg)
        {
            reg.Status = true;
            reg.CreatedDate = DateTime.Now;
            context.AddAsset.Add(reg);
            context.SaveChanges();
        }

        public List<AddAsset> GetAddAssetData()
        {
            var data = from AddAsset in context.AddAsset
                       select new AddAsset
                       {
                           Id = AddAsset.Id,
                           AssetId = AddAsset.AssetId,
                           AssetTypeId=AddAsset.AssetTypeId,
                           CpuId=AddAsset.CpuId,
                           RamId=AddAsset.RamId,
                           HddId=AddAsset.HddId,
                           AssetPurchaseDate=AddAsset.AssetPurchaseDate,
                           AssetCost=AddAsset.AssetCost,
                           Remark=AddAsset.Remark
                       };
            return data.ToList();


        }
    }
}
