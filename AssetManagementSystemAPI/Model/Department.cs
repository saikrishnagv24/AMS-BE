using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagementSystemAPI.Model
{
    public class Department
    {
        public Department()
        {
            employees = new HashSet<Employees>();
        }
        [Key]

        public int id { get; set; }

        [StringLength(220)]
        public string DepartmentName { get; set; }

        [StringLength(220)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public bool DeleteStatus { get; set; }

        [InverseProperty(nameof(Employees.Departments))]
        public virtual ICollection<Employees> employees { get; set; }

    }
}
