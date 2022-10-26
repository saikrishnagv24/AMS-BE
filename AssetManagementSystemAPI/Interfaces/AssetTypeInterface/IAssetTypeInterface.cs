using AssetManagementSystemAPI.Model;
using System.Collections.Generic;

namespace AssetManagementSystemAPI.Interfaces.AssetTypeInterface
{
    public interface IAssetTypeInterface
    {
        public void PostAssetType(AssetType reg);

        public List<AssetType> getAssetType();

        public void putAssetType(int id);

        public void deleteAssetType(int id);

        public AssetType getEditAssetType(int id);

        public void putAssetTypeEdited(AssetType reg);
    }

}
