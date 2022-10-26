using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.RegisterInterface
{
    public interface IRegisterInterface
    {
        public void PostReg(Register reg);
    }
}
