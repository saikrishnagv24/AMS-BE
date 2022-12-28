using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class AddAsset
    {
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string AssetId { get; set; }

        public int? AssetTypeId { get; set; }

        public int? CpuId { get; set; }

        public int? RamId { get; set; }

        public int? HddId { get; set; }

        public DateTime? AssetPurchaseDate { get; set; }

        public int? AssetCost { get; set; }

        [StringLength(440)]
        public string Remark { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }


        [ForeignKey(nameof(AssetTypeId))]
        [InverseProperty(nameof(AssetType.AddAssets))]
        public virtual AssetType AssetTypes { get; set; }

        [ForeignKey(nameof(CpuId))]
        [InverseProperty(nameof(CpuType.AddAssets))]
        public virtual CpuType CpuTypes { get; set; }

        [ForeignKey(nameof(RamId))]
        [InverseProperty(nameof(RamType.AddAssets))]
        public virtual RamType RamTypes { get; set; }

        [ForeignKey(nameof(HddId))]
        [InverseProperty(nameof(HarddiscType.AddAssets))]
        public virtual HarddiscType HarddiscTypes  { get; set; }
    }
}
