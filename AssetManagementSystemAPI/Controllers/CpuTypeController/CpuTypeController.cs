using AssetManagementSystemAPI.Interfaces.CpuInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.CpuTypeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpuTypeController : Controller
    {
        private readonly ICpuTypeInterface cpuTypeInterface;
        public CpuTypeController(ICpuTypeInterface _cpuTypeInterface)
        {
            cpuTypeInterface = _cpuTypeInterface;
        }

        [HttpPost]
        [Route("CpuTypeForm")]
        public void PostCpu(CpuType reg)
        {
            cpuTypeInterface.PostCpuType(reg);
        }

        [HttpGet]
        [Route("GetCpuType")]
        public List<CpuType> GetCpu()
        {
            var data = cpuTypeInterface.getCpuType();
            return data;
        }

        [HttpPut]
        [Route("GetCpuType/{id}")]
        public void PutCpuType(int id)
        {
            cpuTypeInterface.putCpuType(id);
        }

        [HttpDelete]
        [Route("DeleteCpuType/{id}")]
        public void DeleteCpuType(int id)
        {
            cpuTypeInterface.deleteCpuType(id);
        }

        [HttpGet]
        [Route("GetEditCpuType/{id}")]
        public CpuType GetEditCpuType(int id)
        {
            var data = cpuTypeInterface.getEditCpuType(id);
            return data;
        }

        [HttpPut]
        [Route("EditCpuTypeForm")]
        public void PutCpuTypeEdited(CpuType reg)
        {
            cpuTypeInterface.putCpuTypeEdited(reg);
        }
    }
}
