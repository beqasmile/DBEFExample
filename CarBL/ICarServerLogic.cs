using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    public interface ICarServerLogic
    {
        bool ValidateCar(Car updateCar);
        void UpdateCar(Car car);

        void DeleteCar(Car car);

        List<Car> SelectCars();
    }
}
