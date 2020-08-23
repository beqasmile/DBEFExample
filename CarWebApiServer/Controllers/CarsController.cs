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

        [HttpPost]
        [ActionName("AddCar")]
        public void AddCar(CarDto mycar)
        {
            Car car = new Car();
            if (mycar!=null)
            {
                car.CarColor = mycar.CarColor;
                car.CarCompany = mycar.CarCompany;
                car.CarSize = mycar.CarSize;
                car.Comments = mycar.Comments;
                using (CarsDBContext dBContext = new CarsDBContext())
                {
                    dBContext.Car.Add(car);
                    dBContext.SaveChanges();
                }
                
            }
           
        }


        [HttpPost]
        [ActionName("UpdateCar")]
        public IHttpActionResult UpdateCar(CarDto myCar)
        {

            using (CarsDBContext dBContext = new CarsDBContext())
            {
                Car car = dBContext.Car.Where(c => c.ID == myCar.ID).FirstOrDefault();
                if (car!=null)
                {
                    car.CarColor = myCar.CarColor;
                    car.CarCompany = myCar.CarCompany;
                    car.CarSize = myCar.CarSize;
                    car.Comments = myCar.Comments;
                }

               
                dBContext.SaveChanges();
                return Ok(myCar);
            }


        }
    }
}
