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
    public class DriversController : ApiController
    {
        [HttpGet]
        [ActionName("GetAllDrivers")]
        public IEnumerable<DriverDto> GetAllDrivers()
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                List<Driver> sourceDrivers = dBContext.Drivers.ToList();

                IEnumerable<DriverDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Driver>, List<DriverDto>>(sourceDrivers);
                return result;
               
            }
        }

        [HttpGet]
        [ActionName("GetDriversByCityName")]
        public IEnumerable<DriverDto> GetDriversByCityName(String cityName)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {

                IEnumerable<DriverDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Driver>, List<DriverDto>>(dBContext.Drivers.Where(dri => dri.Address.Contains(cityName)).ToList());
                return result;
            }
        }

        [HttpGet]
        [ActionName("GetDriversByAgeAndType")]
        public IEnumerable<DriverDto> GetDriversByAge(int age, int driverType)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                IEnumerable<DriverDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Driver>, List<DriverDto>>(dBContext.Drivers.Where(dri => dri.Age > age && dri.DriversLessonType == driverType).ToList());
                return result;
            }
        }

        [HttpGet]
        [ActionName("GetDriversByDriverType")]
        public IEnumerable<DriverDto> GetDriversByDriverType(string driverType)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                var driversByType = (from driver in dBContext.Drivers
                                     join driverLessonType in dBContext.DriverLessonType on driver.DriversLessonType equals driverLessonType.LessonType
                                     where driverLessonType.LessonTypeDriver == driverType
                                     select new DriverDto
                                     {
                                         ID = driver.ID,
                                         DriverName = driver.DriverName,
                                         DriversLessonType = driver.DriversLessonType,
                                         Address = driver.Address,
                                         DriversLessonTypeValue = driverLessonType.LessonTypeDriver
                                     });

                return driversByType.ToList();



            }
        }

        [HttpPost]
        [ActionName("AddDriver")]
        public IHttpActionResult AddDriver(DriverDto myDriver)

        {
            Driver driver = new Driver();
            if (driver != null)
            {

                driver = AutoMapperConfiguration.MapperConfiguration.Map<DriverDto, Driver>(myDriver);

                //driver.DriverName = myDriver.DriverName;
                //driver.DriversLessonType = myDriver.DriversLessonType;
                //driver.Age = myDriver.Age;
                //driver.Address = myDriver.Address;
                using (CarsDBContext dBContext = new CarsDBContext())
                {
                    dBContext.Drivers.Add(driver);
                    dBContext.SaveChanges();
                    return Ok(myDriver);
                }

            }
            return Ok(myDriver);

        }





    }

}
