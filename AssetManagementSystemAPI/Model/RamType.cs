using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class RamType
    {
        public RamType()
        {
            AddAssets = new HashSet<AddAsset>();

        }
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string RamTypeName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }

        [InverseProperty(nameof(AddAsset.RamTypes))]
        public virtual ICollection<AddAsset> AddAssets { get; set; }
    }
}
