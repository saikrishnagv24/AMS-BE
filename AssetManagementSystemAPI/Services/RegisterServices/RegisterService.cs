using AssetManagementSystemAPI.Interfaces.RegisterInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.RegisterServices
{
    public class RegisterService : IRegisterInterface
    {
        private readonly AmsDBContext context;
        public RegisterService(AmsDBContext _context)
        {
            context = _context;
        }

        public void PostReg(Register reg)
        {
            context.Register.Add(reg);
            context.SaveChanges();
        }
    }

}
