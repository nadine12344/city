using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CityDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points
        {
            get
            {
                return PonitsOfInterest.Count();
            }
        }
        public ICollection<PonitsOfInterestDto> PonitsOfInterest = new List<PonitsOfInterestDto>();
    }
}
