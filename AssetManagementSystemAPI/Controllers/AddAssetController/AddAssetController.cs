using AssetManagementSystemAPI.DTO;
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
        public List<AddAssetDTO> getAddAsset()
        {
           var data = addAssetInterface.GetAddAssetData();
           return data;
        }

        [HttpPut]
        [Route("DeleteAddAsset/{id}")]
        public void DeleteEmployee(int id)
        {
            addAssetInterface.deleteAsset(id);
        }


        [HttpGet]
        [Route("GetEditAsset/{id}")]
        public AddAsset GetEditEmployees(int id)
        {
            var editEmployee = addAssetInterface.GetEditAsset(id);
            return editEmployee;
        }


        [HttpPut]
        [Route("EditAddAssetForm")]
        public void EditAddAssetForm(AddAsset data)
        {
            addAssetInterface.editAddAssetForm(data);
        }
    }
}
