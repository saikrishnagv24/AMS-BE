using AssetManagementSystemAPI.Interfaces.RegisterInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.RegisterController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterInterface registerInterface;
        public RegisterController(IRegisterInterface _registerInterface)
        {
            registerInterface = _registerInterface;
        }

        [HttpPost]
        [Route("RegiseterForm")]
        public void Post(Register reg)
        {
            registerInterface.PostReg(reg);
        }
    }
}
