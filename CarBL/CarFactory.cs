using CarBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommon
{
    public class CarFactory
    {
        public ICarServerLogic CreateCarServerLogic()
        {
            return new CarServerLogic();
        }
        public IDriverServerLogic CreateDriverServerLogic()
        {
            return new DriverServerLogic();
        }
    }
}
