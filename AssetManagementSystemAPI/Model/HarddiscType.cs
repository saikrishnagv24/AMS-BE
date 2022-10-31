using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class HarddiscType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string HarddiscTypeName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
