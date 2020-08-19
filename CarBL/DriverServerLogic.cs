using CarCommon.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    public class DriverServerLogic : IDriverServerLogic
    {
        public void DeleteDriver(Driver driver)
        {
            DriversDal driverDAL = new DriversDal();
            driverDAL.DeleteDriver(driver);
        }

        public List<Driver> SelectDrivers()
        {
            DriversDal driverDAL = new DriversDal();
            return driverDAL.SelectDrivers();
        }

        public void UpdateDriver(Driver driver)
        {
            if (ValidateDriver(driver))
            {
                DriversDal driverDAL = new DriversDal();
                // check if the car exists
                if (driverDAL.CheckDriverExists(driver))
                {
                    driverDAL.UpdateDriver(driver);
                }
                else
                {
                    driverDAL.InsertDriver(driver);
                }
            }
        }

        public bool ValidateDriver(Driver driver)
        {
            return true;
        }
    }
}
