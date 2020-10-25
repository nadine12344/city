﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController:ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.cities);
        }
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        { var city = CitiesDataStore.Current.cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
                return NotFound();
            else return Ok(city);
        }
    }
}
