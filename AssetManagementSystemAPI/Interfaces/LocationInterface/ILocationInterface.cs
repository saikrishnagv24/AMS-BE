using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Interfaces.LocationInterface
{
    public interface ILocationInterface
    {
        public void postLocation(Location location);

        public List<Location> getLocation();

        public void putLocation(int id);

        public void deleteLocation(int id);

        public Location getEditLocation(int id);

        public void putLocationEdited(Location loc);
    }
}
