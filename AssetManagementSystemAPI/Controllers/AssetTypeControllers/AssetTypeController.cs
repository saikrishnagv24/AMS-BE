using AssetManagementSystemAPI.Interfaces.AssetTypeInterface;
using AssetManagementSystemAPI.Interfaces.RegisterInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AssetManagementSystemAPI.Controllers.AssetTypeControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetTypeController : ControllerBase
    {
        private readonly IAssetTypeInterface assetTypeInterface;
        public AssetTypeController(IAssetTypeInterface _assetTypeInterface)
        {
            assetTypeInterface = _assetTypeInterface;
        }

        [HttpPost]
        [Route("AssetTypeForm")]
        public void PostAsset(AssetType reg)
        {
            assetTypeInterface.PostAssetType(reg);
        }

        [HttpGet]
        [Route("GetAssetType")]
        public List<AssetType> GetAsset()
        {
           var data  = assetTypeInterface.getAssetType();
           return data;
        }

        [HttpPut]
        [Route("GetAssetType/{id}")]
        public void PutAssetType(int id)
        {
           assetTypeInterface.putAssetType(id);
        }

        [HttpDelete]
        [Route("DeleteAssetType/{id}")]
        public void DeleteAssetType(int id)
        {
            assetTypeInterface.deleteAssetType(id);
        }

        [HttpGet]
        [Route("GetEditAssetType/{id}")]
        public AssetType GetEditAssetType(int id)
        {
           var data = assetTypeInterface.getEditAssetType(id);
           return data;
        }

        [HttpPut]
        [Route("EditAssetTypeForm")]
        public void PutAssetTypeEdited(AssetType reg)
        {
            assetTypeInterface.putAssetTypeEdited(reg);
        }
    }
}
