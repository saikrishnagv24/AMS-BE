using AssetManagementSystemAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.LoginInterface
{
    public interface IloginInterface
    {
        public LoginDTO Login(LoginDTO login);
    }
}
