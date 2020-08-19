using CarCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    public class CarServerLogic : ICarServerLogic
    {
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
            if (updateCar.Id>0)
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
            if (updateCar.Size>0)
            {
                return false;
            }


            return true;
        }

      
    }
}
