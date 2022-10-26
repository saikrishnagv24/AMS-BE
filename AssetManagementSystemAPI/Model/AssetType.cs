using System;
using System.ComponentModel.DataAnnotations;

namespace AssetManagementSystemAPI.Model
{
    public class AssetType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string AssetTypeName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
