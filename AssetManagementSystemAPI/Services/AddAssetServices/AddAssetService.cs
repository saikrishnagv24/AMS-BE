using AssetManagementSystemAPI.DTO;
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

        public List<AddAssetDTO> GetAddAssetData()
        {
            var data = (from AddAsset in context.AddAsset
                        join assetType in context.AssetType on AddAsset.AssetTypeId equals assetType.Id
                        join cpyType in context.CpuType on AddAsset.CpuId equals cpyType.Id into leftCpu
                        from cpu in leftCpu.DefaultIfEmpty()
                        join hddType in context.HarddiscType on AddAsset.HddId equals hddType.Id into leftHdd
                        from hdd in leftHdd.DefaultIfEmpty()
                        join ramType in context.RamType on AddAsset.RamId equals ramType.Id into leftRam
                        from ram in leftRam.DefaultIfEmpty()
                        where AddAsset.Status != false
                        select new AddAssetDTO
                        {
                            Id = AddAsset.Id,
                            AssetId = AddAsset.AssetId,
                            AssetTypeId = AddAsset.AssetTypeId,
                            AssetName = assetType.AssetTypeName,
                            CpuId = AddAsset.CpuId,
                            CpuType = cpu.CpuTypeName == null ? "N/A" : cpu.CpuTypeName,
                            RamId = AddAsset.RamId,
                            RamType = ram.RamTypeName == null ? "N/A" : ram.RamTypeName,
                            HddId = AddAsset.HddId,
                            HddType = hdd.HarddiscTypeName == null ? "N/A" : hdd.HarddiscTypeName,
                            AssetPurchaseDate = AddAsset.AssetPurchaseDate,
                            AssetCost = AddAsset.AssetCost,
                            Remark = AddAsset.Remark
                        }).ToList();
            return data.ToList();
        }

        public void deleteAsset(int id)
        {

            var data = context.AddAsset.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                data.Status = false;
                context.SaveChanges();
            }
        }

        public AddAsset GetEditAsset(int id)
        {
            var data = context.AddAsset.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        public void editAddAssetForm(AddAsset data)
        {
            var AddAssetData = context.AddAsset.Where(x => x.Id == data.Id).FirstOrDefault();
            if (AddAssetData != null)
            {
                AddAssetData.AssetId = data.AssetId;
                AddAssetData.AssetCost = data.AssetCost;
                AddAssetData.AssetPurchaseDate = data.AssetPurchaseDate;
                AddAssetData.AssetTypeId = data.AssetTypeId;
                AddAssetData.CpuId = data.CpuId;
                AddAssetData.HddId = data.HddId;
                AddAssetData.RamId = data.RamId;
                AddAssetData.Remark = data.Remark;
                AddAssetData.ModifiedDate = DateTime.Now;
                context.SaveChanges();
            }
        }


}
}
