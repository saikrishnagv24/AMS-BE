using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.AddAssetInterface
{
    public interface IAddAssetInterface
    {
        public void PostAddAsset(AddAsset reg);

        public List<AddAsset> GetAddAssetData();
    }
}
