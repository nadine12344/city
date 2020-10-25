using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsOfInterest")]
    public class PointsOfInterestController:ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var City = CitiesDataStore.Current.cities.FirstOrDefault(c => c.Id == cityId);
            if (City == null)
                return NotFound();
            else
                return Ok(City.PonitsOfInterest);


        }
        [HttpGet("{id}")]
        public IActionResult GetPointOfInterest(int cityId,int id)
        {
            var City = CitiesDataStore.Current.cities.FirstOrDefault(c => c.Id == cityId);
            if (City == null)
                return NotFound();
            
             var point = City.PonitsOfInterest.FirstOrDefault(p => p.Id == id);
                if (point == null)
                    return NotFound();
               
                return Ok(point);
            }


        
    }
}
