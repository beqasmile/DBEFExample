using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWebApiServer.Models.Dto
{
    public class CarDto
    {
        public int ID { get; set; }
        public int CarSize { get; set; }
        public string CarCompany { get; set; }
        public Nullable<int> CarColor { get; set; }
        public string Comments { get; set; }

        public string CarSize1 { get; set; }
        public Nullable<int> NumOfPassengers { get; set; }


    }
}