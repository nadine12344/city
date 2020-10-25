using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        //make sure we are working on the same instance as long as we do not restart the server
        public static CitiesDataStore Current=new CitiesDataStore();
        public List<CityDetails> cities;
        public CitiesDataStore()
        {
            //init dummy data
            cities = new List<CityDetails>()
            {                new CityDetails()
                {
                     Id = 1,
                     Name = "New York City",
                     Description = "The one with that big park.",
                     PonitsOfInterest = new List<PonitsOfInterestDto>()
                     {
                         new PonitsOfInterestDto() {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States." },
                          new PonitsOfInterestDto() {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan." },
                     }
                },
                new CityDetails()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PonitsOfInterest = new List<PonitsOfInterestDto>()
                     {
                         new PonitsOfInterestDto() {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                          new PonitsOfInterestDto() {
                             Id = 4,
                             Name = "Antwerp Central Station",
                             Description = "The the finest example of railway architecture in Belgium." },
                     }
                },
                new CityDetails()
                {
                    Id= 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PonitsOfInterest = new List<PonitsOfInterestDto>()
                     {
                         new PonitsOfInterestDto() {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel." },
                          new PonitsOfInterestDto() {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The world's largest museum." },
                     }
                }
            };
            
    //f

}
    }
}
