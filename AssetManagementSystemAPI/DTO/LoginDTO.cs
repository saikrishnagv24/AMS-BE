using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.DTO
{
    public class LoginDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public bool Status { get; set; }
    }
}
