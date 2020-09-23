using CarWebApiServer.App_Start;
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
        public IEnumerable<CarDto> GetCars()
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                IEnumerable<CarDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Car>,List< CarDto >> (dBContext.Car.ToList());
                return result;
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
                car= AutoMapperConfiguration.MapperConfiguration.Map<CarDto, Car>(mycar);

                //car.CarColor = mycar.CarColor;
                //car.CarCompany = mycar.CarCompany;
                //car.CarSize = mycar.CarSize;
                //car.Comments = mycar.Comments;
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

                    //IEnumerableCarDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Car>, List<CarDto>>(dBContext.carss.Where(dri => dri.Age > age && dri.DriversLessonType == driverType).ToList());

                    car = AutoMapperConfiguration.MapperConfiguration.Map<CarDto, Car>(myCar);

                //    car.CarColor = myCar.CarColor;
                //    car.CarCompany = myCar.CarCompany;
                //    car.CarSize = myCar.CarSize;
                //    car.Comments = myCar.Comments;
                }

               
                dBContext.SaveChanges();
                return Ok(myCar);
            }


        }
    }
}
