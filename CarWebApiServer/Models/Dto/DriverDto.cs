using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWebApiServer.Models.Dto
{
    public class DriverDto
    {
        public int ID { get; set; }
        public string DriverName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Address { get; set; }
        public int DriversLessonType { get; set; }
        public string DriversLessonTypeValue { get; set; }
    }
}