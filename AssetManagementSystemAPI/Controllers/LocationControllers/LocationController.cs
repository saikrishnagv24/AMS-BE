using AssetManagementSystemAPI.Interfaces.LocationInterface;
using AssetManagementSystemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Controllers.LocationControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationInterface locationInterface;
        public LocationController(ILocationInterface _locationInterface)
        {
            locationInterface = _locationInterface;
        }

        [HttpPost]
        [Route("AddLoctionForm")]
        public void PostLocation(Location location)
        {
            locationInterface.postLocation(location);
        }

        [HttpGet]
        [Route("GetLoation")]
        public List<Location> GetLocation()
        {
            var data = locationInterface.getLocation();
            return data;
        }

        [HttpPut]
        [Route("GetLocation/{id}")]
        public void PutLocation(int id)
        {
            locationInterface.putLocation(id);
        }

        [HttpDelete]
        [Route("DeleteLocation/{id}")]
        public void DeleteLocation(int id)
        {
            locationInterface.deleteLocation(id);
        }

        [HttpGet]
        [Route("GetEditLocation/{id}")]
        public Location GetEditLocation(int id)
        {
            var data = locationInterface.getEditLocation(id);
            return data;
        }

        [HttpPut]
        [Route("EditLocationForm")]
        public void PutLocationEdited(Location location)
        {
            locationInterface.putLocationEdited(location);
        }
    }
}
