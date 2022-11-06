using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagementSystemAPI.Model
{
    public class AssetType
    {
        public AssetType(){
            AddAssets = new HashSet<AddAsset>();

        }
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string AssetTypeName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }

        [InverseProperty(nameof(AddAsset.AssetTypes))]
        public virtual ICollection<AddAsset> AddAssets { get; set; }
    }
}
