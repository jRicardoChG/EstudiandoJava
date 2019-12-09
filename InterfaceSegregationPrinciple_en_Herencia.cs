// e smejor acer la ISP atraves de herencia es mas legible y sostenible

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {


        }
    }

    public interface IFuelContainer
    {
        void IncreaseFuel();
        void DecreaseFuel();
    }   

    public interface IEngineDevice : IFuelContainer
    {
        void StartEngine();
        void StopEngine();   
    }
    public interface IVehicule : IEngineDevice
    {
        void Drive();
        void Brake();
        void EmergencyBrake();
    } 

    public class GasCan : IFuelContainer
    {
        public void IncreaseFuel(){}
        public void Decreasefuel(){}
    }
    public class LawnMower : IFuelContainer
    {
        public void IncreaseFuel(){}
        public void Decreasefuel(){}
        public void StartEngine(){}
        public void StopEngine(){}
    }
    public class Car : IVehicule
    {
        public void IncreaseFuel(){}
        public void Decreasefuel(){}
        public void StartEngine(){}
        public void StopEngine(){}
        public void Drive(){}
        public void Brake(){}
        public void EmergencyBrake(){}
    }

}
