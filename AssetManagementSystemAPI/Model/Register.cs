using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [StringLength(220)]
        public string Name { get; set; }

        public long PhoneNumber { get; set; }
        [StringLength(220)]
        public string Email { get; set; }
        [StringLength(220)]
        public string Password { get; set; }
        [StringLength(220)]
        public string ConfirmPassword { get; set; }

        public bool Status { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
