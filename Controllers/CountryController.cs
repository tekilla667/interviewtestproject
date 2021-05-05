using destination.DTOs;
using destination.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace destination.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly IDestinationService _destService;
        public CountryController(IDestinationService destinationService)
        {
            _destService = destinationService;
        }
        [HttpGet("{shortName}")]
        public  ActionResult<CountriesToPassDTO> returnList(string shortName)
        {
            return _destService.getCountries(shortName);
           
        }

    }
}
