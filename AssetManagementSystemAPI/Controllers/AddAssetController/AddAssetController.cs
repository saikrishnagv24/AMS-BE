using AssetManagementSystemAPI.Interfaces.AddAssetInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.AddAssetController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddAssetController : ControllerBase
    {
        private readonly IAddAssetInterface addAssetInterface;
        public AddAssetController(IAddAssetInterface _addAssetInterface)
        {
            addAssetInterface = _addAssetInterface;
        }

        [HttpPost]
        [Route("AddAssetForm")]
        public void PostAddAsset(AddAsset reg)
        {
            addAssetInterface.PostAddAsset(reg);
        }

        [HttpGet]
        [Route("GetAddAsset")]
        public List<AddAsset> getAddAsset()
        {
           var data = addAssetInterface.GetAddAssetData();
           return data;
        }
    }
}
