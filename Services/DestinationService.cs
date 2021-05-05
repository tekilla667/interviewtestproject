using destination.Core;
using destination.DTOs;
using destination.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace destination.Services
{
    public class DestinationService : IDestinationService
    {
        private Dictionary<string, Country> codeToCountry = new Dictionary<string, Country>();
        private void initCountries()
        {
            var USA= new Country("USA", null);
            var CAN = new Country("CAN", USA);
            var MEX = new Country("MEX", USA);
            var BLZ = new Country("BLZ", MEX);
            var GTM = new Country("GTM", MEX);
            var SLV = new Country("SLV", GTM);
            var HND = new Country("HND", GTM);
            var NIC = new Country("NIC", HND);
            var CRI = new Country("CRI", NIC);
            var PAN = new Country("PAN", CRI);
            codeToCountry.Add("USA", USA);
            codeToCountry.Add("CAN", CAN);
            codeToCountry.Add("MEX", MEX);
            codeToCountry.Add("BLZ", BLZ);
            codeToCountry.Add("GTM", GTM);
            codeToCountry.Add("SLV", SLV);
            codeToCountry.Add("HND", HND);
            codeToCountry.Add("NIC", NIC);
            codeToCountry.Add("CRI", CRI);
            codeToCountry.Add("PAN", PAN);

        }
        public DestinationService()
        {
            initCountries();
        }

        public ActionResult<CountriesToPassDTO> getCountries(string shortName)
        {
            try
            {
                Country country = codeToCountry[shortName.ToUpper()];
                List<string> countriesToPassNames = new List<string>();

                while (country.parent != null)
                {
                    countriesToPassNames.Add(country.shortName);
                    country = country.parent;
                }
                countriesToPassNames.Add("USA");
                countriesToPassNames.Reverse();
                return new CountriesToPassDTO
                {
                    destination = shortName.ToUpper(),
                    list = countriesToPassNames
                };
            }
            catch(Exception)
            {
                return new BadRequestResult();
            }
          
        }
    }
}
