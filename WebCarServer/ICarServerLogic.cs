using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarCommon;

namespace CarBL

{
    [ServiceContract]
    public interface ICarServerLogic
    {
        [OperationContract]
        bool ValidateCar(Car updateCar);
        [OperationContract]
        void UpdateCar(Car car);
        [OperationContract]
        void DeleteCar(Car car);
        [OperationContract]
        List<Car> SelectCars();
    }
}
