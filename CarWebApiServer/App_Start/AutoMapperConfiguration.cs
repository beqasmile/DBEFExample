using AutoMapper;
using CarWebApiServer.Models;
using CarWebApiServer.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWebApiServer.App_Start
{
    public class AutoMapperConfiguration
    {
        public static IMapper MapperConfiguration;
        public static void CreateConfiguration()
        {
            var MapperConfiguration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Driver, DriverDto>();
                cfg.CreateMap<DriverDto, Driver>();
                cfg.CreateMap<CarDto, Car>();
                cfg.CreateMap<Car, CarDto>();
                cfg.CreateMap<RoadDto, Road>();
                cfg.CreateMap<Road, RoadDto>();
            });

            AutoMapperConfiguration.MapperConfiguration = MapperConfiguration.CreateMapper();

        }
    }
}