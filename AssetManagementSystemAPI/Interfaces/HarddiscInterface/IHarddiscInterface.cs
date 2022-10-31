
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.HarddiscInterface
{
   public  interface IHarddiscInterface
    {
        public void PostHarddiscType(HarddiscType reg);

        public List<HarddiscType> getHarddiscType();

        public void putHarddiscType(int id);

        public void deleteHarddiscType(int id);

        public HarddiscType getEditHarddiscType(int id);


        public void putHarddiscTypeEdited(HarddiscType reg);
    }
}
