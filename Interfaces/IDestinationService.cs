using destination.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace destination.Interfaces
{
    public interface IDestinationService
    {
        public ActionResult<CountriesToPassDTO> getCountries(string shortName);
    }
}
