using AssetManagementSystemAPI.Interfaces.RamTypeInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.RamTypeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RamTypeController : Controller
    {
        private readonly IRamTypeInterface ramTypeInterface;
        public RamTypeController(IRamTypeInterface _ramTypeInterface)
        {
            ramTypeInterface = _ramTypeInterface;
        }

        [HttpPost]
        [Route("RamTypeForm")]
        public void PostRam(RamType reg)
        {
            ramTypeInterface.PostRamType(reg);
        }

        [HttpGet]
        [Route("GetRamType")]
        public List<RamType> GetCpu()
        {
            var data = ramTypeInterface.getRamType();
            return data;
        }

        [HttpPut]
        [Route("GetRamType/{id}")]
        public void PutCpuType(int id)
        {
            ramTypeInterface.putRamType(id);
        }

        [HttpDelete]
        [Route("DeleteRAMType/{id}")]
        public void DeleteRamType(int id)
        {
            ramTypeInterface.deleteRamType(id);
        }

        [HttpGet]
        [Route("GetEditRamType/{id}")]
        public RamType GetEditCpuType(int id)
        {
            var data = ramTypeInterface.getEditRamType(id);
            return data;
        }

        [HttpPut]
        [Route("EditRamTypeForm")]
        public void PutCpuTypeEdited(RamType reg)
        {
            ramTypeInterface.putRamTypeEdited(reg);
        }

    }
}
