using AssetManagementSystemAPI.DTO;
using AssetManagementSystemAPI.Interfaces.LoginInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.LoginServices
{
    public class LoginService : IloginInterface
    {
        private readonly AmsDBContext context;
        public LoginService(AmsDBContext _context)
        {
            context = _context;
        }

        public LoginDTO Login(LoginDTO login)
        {
            try { 
            LoginDTO logDto = new LoginDTO();
            var loginDetails = (from reg in context.Register
                               where reg.Name == login.Name && reg.Password == login.Password
                               select new LoginDTO
                               {
                                   Id = reg.Id,
                                   Name = login.Name,
                                   Password = login.Password,
                                   Status = reg.Status
                               }).FirstOrDefault();
            if(loginDetails!= null && loginDetails.Status != false)
            {
                return loginDetails;
                //var loginData = context.Register.Where(x => x.Name == login.Name && x.Password == login.Password).Select(x=> x.Name, x.Password)
            }
            else
            {
                return null;
            }
            }
            catch(Exception ex)
            {
               throw ex;
            }
        }
    }
}
