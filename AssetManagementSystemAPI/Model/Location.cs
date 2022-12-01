using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class Location
    {
        public Location()
        {
            employees = new HashSet<Employees>();

        }
        [Key]
        public int Id { get; set; }

        [StringLength(220)]
        public string LocationName { get; set; }

        public bool status { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        [InverseProperty(nameof(Employees.Locations))]
        public virtual ICollection<Employees> employees { get; set; }
    }
}
