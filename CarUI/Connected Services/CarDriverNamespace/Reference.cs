﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarUI.CarDriverNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarDriverNamespace.ICarDriverService")]
    public interface ICarDriverService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/ValidateCar", ReplyAction="http://tempuri.org/ICarDriverService/ValidateCarResponse")]
        bool ValidateCar(CarCommon.Car updateCar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/ValidateCar", ReplyAction="http://tempuri.org/ICarDriverService/ValidateCarResponse")]
        System.Threading.Tasks.Task<bool> ValidateCarAsync(CarCommon.Car updateCar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/UpdateCar", ReplyAction="http://tempuri.org/ICarDriverService/UpdateCarResponse")]
        void UpdateCar(CarCommon.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/UpdateCar", ReplyAction="http://tempuri.org/ICarDriverService/UpdateCarResponse")]
        System.Threading.Tasks.Task UpdateCarAsync(CarCommon.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/DeleteCar", ReplyAction="http://tempuri.org/ICarDriverService/DeleteCarResponse")]
        void DeleteCar(CarCommon.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/DeleteCar", ReplyAction="http://tempuri.org/ICarDriverService/DeleteCarResponse")]
        System.Threading.Tasks.Task DeleteCarAsync(CarCommon.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/SelectCars", ReplyAction="http://tempuri.org/ICarDriverService/SelectCarsResponse")]
        CarCommon.Car[] SelectCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarDriverService/SelectCars", ReplyAction="http://tempuri.org/ICarDriverService/SelectCarsResponse")]
        System.Threading.Tasks.Task<CarCommon.Car[]> SelectCarsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarDriverServiceChannel : CarUI.CarDriverNamespace.ICarDriverService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarDriverServiceClient : System.ServiceModel.ClientBase<CarUI.CarDriverNamespace.ICarDriverService>, CarUI.CarDriverNamespace.ICarDriverService {
        
        public CarDriverServiceClient() {
        }
        
        public CarDriverServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarDriverServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarDriverServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarDriverServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateCar(CarCommon.Car updateCar) {
            return base.Channel.ValidateCar(updateCar);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateCarAsync(CarCommon.Car updateCar) {
            return base.Channel.ValidateCarAsync(updateCar);
        }
        
        public void UpdateCar(CarCommon.Car car) {
            base.Channel.UpdateCar(car);
        }
        
        public System.Threading.Tasks.Task UpdateCarAsync(CarCommon.Car car) {
            return base.Channel.UpdateCarAsync(car);
        }
        
        public void DeleteCar(CarCommon.Car car) {
            base.Channel.DeleteCar(car);
        }
        
        public System.Threading.Tasks.Task DeleteCarAsync(CarCommon.Car car) {
            return base.Channel.DeleteCarAsync(car);
        }
        
        public CarCommon.Car[] SelectCars() {
            return base.Channel.SelectCars();
        }
        
        public System.Threading.Tasks.Task<CarCommon.Car[]> SelectCarsAsync() {
            return base.Channel.SelectCarsAsync();
        }
    }
}
