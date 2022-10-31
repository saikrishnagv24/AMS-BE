using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> b8b047e (HarddiscType completed)
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class HarddiscType
    {
<<<<<<< HEAD
        public HarddiscType()
        {
            AddAssets = new HashSet<AddAsset>();

        }
=======
>>>>>>> b8b047e (HarddiscType completed)
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string HarddiscTypeName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }
<<<<<<< HEAD

        [InverseProperty(nameof(AddAsset.HarddiscTypes))]
        public virtual ICollection<AddAsset> AddAssets { get; set; }
=======
>>>>>>> b8b047e (HarddiscType completed)
    }
}
