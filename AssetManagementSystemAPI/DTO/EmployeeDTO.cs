using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.DTO
{
    public class EmployeeDTO
    {

        public int Id { get; set; }

        public string EmployeeId { get; set; }

        public string Name { get; set; }

        public long PhoneNumber { get; set; }

        public int? LocationId { get; set; }

        public string Location { get; set; }

        public int? DepartmentId { get; set; }

        public string Department { get; set; }

        public bool status { get; set; }
        public DateTime CrteatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }


    }
}
