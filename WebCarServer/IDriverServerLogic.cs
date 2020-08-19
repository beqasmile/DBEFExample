using CarCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    [ServiceContract]
    public interface IDriverServerLogic
    {
        [OperationContract]
        bool ValidateDriver(Driver driver);
        [OperationContract]
        void UpdateDriver(Driver driver);
        [OperationContract]
        void DeleteDriver(Driver driver);
        [OperationContract]
        List<Driver> SelectDrivers();
    }
}
