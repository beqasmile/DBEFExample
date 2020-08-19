using System;
using CarCommon;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarWebServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarDriverService" in both code and config file together.
    [ServiceContract]
    public interface ICarDriverService
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
