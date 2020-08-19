using CarWebApiServer.Models;
using CarWebApiServer.Models.Dto;
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
                return dBContext.Car.ToList();
            }
        }
        [HttpGet]
        [ActionName("GetCarsByNumOfPassengers")]
        public IEnumerable<CarDto> GetCarsByNumOfPassengers(int numOfPassengers)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                var carsAndPass = from car in dBContext.Car
                                  join carSize in dBContext.CarSize on car.CarSize equals carSize.ID
                                  where carSize.NumOfPassengers > numOfPassengers
                                  select new CarDto
                                  {
                                      CarColor = car.CarColor,
                                      CarCompany = car.CarCompany,
                                      ID = car.ID,
                                      Comments = car.Comments,
                                      NumOfPassengers = carSize.NumOfPassengers,
                                      CarSize1 = carSize.CarSize1
                                  };

                return carsAndPass.ToList();
            }
        }
    }
}
