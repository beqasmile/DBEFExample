using System;
using CarCommon;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarBL;

namespace CarWebServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarDriverService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CarDriverService.svc or CarDriverService.svc.cs at the Solution Explorer and start debugging.
    public class CarDriverService : ICarDriverService
    {
        public void DoWork()
        {

        }

        public void DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> SelectCars()
        {
            CarDAL carDAL = new CarDAL();
            return carDAL.SelectCars();
        }

        public void UpdateCar(Car car)
        {
            if (ValidateCar(car))
            {
                CarDAL carDAL = new CarDAL();
                carDAL.InsertCar(car);
            }

        }

        public bool ValidateCar(Car updateCar)
        {
            if (updateCar.Id > 0)
            {
                return false;
            }
            if (String.IsNullOrEmpty(updateCar.Company))
            {
                return false;
            }
            if (String.IsNullOrEmpty(updateCar.Comments))
            {
                return false;
            }
            if (updateCar.Size > 0)
            {
                return false;
            }


            return true;
        }
    }
}

