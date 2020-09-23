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
    public class RoadsController : ApiController
    {
        [HttpGet]
        [ActionName("GetAllRoads")]
        public IEnumerable<RoadDto> GetAllRoads()
        {
            using (CarsDBContext dBContext = new CarsDBContext())
            {
                IEnumerable<RoadDto> result = AutoMapperConfiguration.MapperConfiguration.Map<List<Road>, List<RoadDto>>(dBContext.Roads.ToList());
                return result;
            }
        }
    }
}
