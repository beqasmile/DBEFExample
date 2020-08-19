using CarWebApiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarWebApiServer.Controllers
{
    public class CarsController : ApiController
    {
        [HttpGet]
        [ActionName("GetAllCars")]
        public IEnumerable<Car> GetCars()
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                return dBContext.Cars.ToList();
            }
        }
    }
}
