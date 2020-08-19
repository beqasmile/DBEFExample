using CarCommon.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    public interface IDriverServerLogic
    {

        bool ValidateDriver(Driver driver);
        void UpdateDriver(Driver driver);

        void DeleteDriver(Driver driver);

        List<Driver> SelectDrivers();
    }
}
