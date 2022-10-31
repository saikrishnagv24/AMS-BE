using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.RamTypeInterface
{
    public interface IRamTypeInterface
    {
        public void PostRamType(RamType reg);

        public List<RamType> getRamType();

        public void putRamType(int id);

        public void deleteRamType(int id);

        public RamType getEditRamType(int id);

        public void putRamTypeEdited(RamType reg);
    }
}
