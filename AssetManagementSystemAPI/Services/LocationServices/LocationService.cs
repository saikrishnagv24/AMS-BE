using AssetManagementSystemAPI.Interfaces.LocationInterface;
using AssetManagementSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Services.LocationServices
{
    public class LocationService : ILocationInterface
    {
        private readonly AmsDBContext context;
        public LocationService(AmsDBContext _context)
        {
            context = _context;
        }

        public void postLocation(Location location)
        {
            location.status = true;
            location.CreateDate = DateTime.Now;
            context.Location.Add(location);
            context.SaveChanges();
        }

        public List<Location> getLocation()
        {
            var data = from loc in context.Location
                       select new Location
                       {
                           Id = loc.Id,
                           LocationName = loc.LocationName
                       };
            return data.ToList();
        }

        public void putLocation(int id)
        {
            var data = context.AssetType.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {

            }
        }


        public void deleteLocation(int id)
        {
            var data = context.Location.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                context.Location.Remove(context.Location.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
        }

        public Location getEditLocation(int id)
        {
            var data = from at in context.Location
                       where at.Id == id
                       select new Location
                       {
                           Id = at.Id,
                           LocationName = at.LocationName
                       };
            return data.FirstOrDefault();
        }

        public void putLocationEdited(Location loc)
        {

            var data = context.Location.Where(x => x.Id == loc.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = loc.Id;
                data.LocationName = loc.LocationName;
                context.SaveChanges();
            }
        }


    }
}
