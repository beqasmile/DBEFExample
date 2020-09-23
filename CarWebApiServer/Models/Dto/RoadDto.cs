using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWebApiServer.Models.Dto
{
    public class RoadDto
    {
        public int Id { get; set; }
        public string RoadName { get; set; }
        public int MaxSpeed { get; set; }
        public Nullable<int> NumLanes { get; set; }
        public string RoadDesc { get; set; }
        public short RoadNum { get; set; }
    }
}