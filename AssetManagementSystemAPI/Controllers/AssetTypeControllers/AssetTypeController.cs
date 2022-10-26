using AssetManagementSystemAPI.Interfaces.AssetTypeInterface;
using AssetManagementSystemAPI.Interfaces.RegisterInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
