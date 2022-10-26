using System;
using System.ComponentModel.DataAnnotations;

namespace AssetManagementSystemAPI.Model
{
    public class Department
    {
        [Key]

        public int id { get; set; }

        [StringLength(220)]
        public string DepartmentName { get; set; }

        [StringLength(220)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public bool DeleteStatus { get; set; }



    }
}
