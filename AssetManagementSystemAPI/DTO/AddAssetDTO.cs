using System;

namespace AssetManagementSystemAPI.DTO
{
    public class AddAssetDTO
    {
        public int Id { get; set; }

        public string AssetId { get; set; }

        public int? AssetTypeId { get; set; }

        public string AssetName { get; set; }

        public int? CpuId { get; set; }

        public string CpuType { get; set; }

        public int? RamId { get; set; }

        public string RamType { get; set; }

        public int? HddId { get; set; }

        public string HddType { get; set; }

        public DateTime? AssetPurchaseDate { get; set; }

        public int? AssetCost { get; set; }

        public string Remark { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

    }
}
