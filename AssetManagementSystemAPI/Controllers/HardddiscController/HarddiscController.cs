using AssetManagementSystemAPI.Interfaces.HarddiscInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystemAPI.Controllers.HardddiscController
{

    [Route("api/[controller]")]
    [ApiController]
    public class HarddiscController
    {
        
        private readonly IHarddiscInterface harddiscInterface;
        public HarddiscController(IHarddiscInterface _harddiscInterface)
        {
            harddiscInterface = _harddiscInterface;
        }

        [HttpPost]
        [Route("HarddiscTypeForm")]
        public void PostHarddisc(HarddiscType reg)
        {
            harddiscInterface.PostHarddiscType(reg);
        }


        [HttpGet]
        [Route("GetHarddiscType")]
        public List<HarddiscType> GetHarddisc()
        {
            var data = harddiscInterface.getHarddiscType();
            return data;
        }


        [HttpPut]
        [Route("GetHarddiscType/{id}")]
        public void PutHarddiscType(int id)
        {
            harddiscInterface.putHarddiscType(id);
        }

        [HttpDelete]
        [Route("DeleteHarddiscType/{id}")]
        public void DeleteHarddiscType(int id)
        {
            harddiscInterface.deleteHarddiscType(id);
        }

        [HttpGet]
        [Route("GetEditHarddiscType/{id}")]
        public HarddiscType GetEditHarddiscType(int id)
        {
            var data = harddiscInterface.getEditHarddiscType(id);
            return data;
        }

        [HttpPut]
        [Route("EditHarddiscTypeForm")]
        public void PutHarddiscTypeEdited(HarddiscType reg)
        {
            harddiscInterface.putHarddiscTypeEdited(reg);
        }

    }
}
