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
        public IEnumerable<Driver> GetAllDrivers()
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                return dBContext.Drivers.ToList();
            }
        }

        [HttpGet]
        [ActionName("GetDriversByCityName")]
        public IEnumerable<Driver> GetDriversByCityName(String cityName)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                return dBContext.Drivers.Where(dri => dri.Address.Contains(cityName)).ToList();
            }
        }

        [HttpGet]
        [ActionName("GetDriversByAgeAndType")]
        public IEnumerable<Driver> GetDriversByAge(int age, int driverType)
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                return dBContext.Drivers.Where(dri => dri.Age>age && dri.DriversLessonType==driverType).ToList();
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

    }

}
