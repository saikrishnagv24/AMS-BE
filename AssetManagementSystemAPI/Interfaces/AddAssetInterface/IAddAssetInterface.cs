using AssetManagementSystemAPI.DTO;
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

        public List<AddAssetDTO> GetAddAssetData();

        public void deleteAsset(int id);

        public AddAsset GetEditAsset(int id);

        public void editAddAssetForm(AddAsset data);
    }
}
