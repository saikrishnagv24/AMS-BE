using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class Employees
    {

        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string Name { get; set; }

        public long PhoneNumber { get; set; }

        public int? LocationId { get; set; }

        public int DepartmentId { get; set; }

        public bool status { get; set; }
        public DateTime CrteatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty(nameof(Location.employees))]
        public virtual Location Locations { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Department.employees))]
        public virtual Department Departments { get; set; }

    }
}
