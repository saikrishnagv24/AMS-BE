using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.CpuInterface
{
    public interface ICpuTypeInterface
    {
        public void PostCpuType(CpuType reg);

        public List<CpuType> getCpuType();

        public void putCpuType(int id);

        public void deleteCpuType(int id);

        public CpuType getEditCpuType(int id);

        public void putCpuTypeEdited(CpuType reg);
    }
}
