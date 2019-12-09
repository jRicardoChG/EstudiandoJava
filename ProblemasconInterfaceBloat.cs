// se analñiza un problema tipico del crecimiento de interfaces
// en este caso Itaxi tubo que definirse para no generar ruido en la interface Ivehicule, dado uqe motocicleta ni caroo mecesitan taximetro o pedir dinero
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            Taxi num1 = new Taxi();
            num1.StartEngine();
            num1.Taximetro();
        }
    }

    public interface IVehicule {
        void StartEngine();
        void Brake();
        void StopEngine();
        void Accelerate();
    }

    public interface ITaxi : IVehicule {
        void Taximetro();
        void PedirDinero();
    }

    class Car : IVehicule {
        public Car()
        {
        }

        public void StartEngine() {
            Console.WriteLine("El auto prende el motor");
        }
        public void Brake() {
            Console.WriteLine("Freno activado");
        }
        public void StopEngine() {
            Console.WriteLine("Motor Apagado");
        }
        public void Accelerate() {
            Console.WriteLine("Motor acelerando");
        }
    }

    class Taxi : ITaxi {

        public void StartEngine() {
            Console.WriteLine("El auto prende el motor");
        }
        public void Brake() {
            Console.WriteLine("Freno activado");
        }
        public void StopEngine() {
            Console.WriteLine("Motor Apagado");
        }
        public void Accelerate() {
            Console.WriteLine("Motor acelerando");
        }
        public void Taximetro()
        {
            Console.WriteLine("El taximetro esta corriendo");
        }
        public void PedirDinero()
        {
             Console.WriteLine("Se pide el dinero al pasajero");
        }
    }

    public class Motocicleta : IVehicule
    {
        public void StartEngine() {
            Console.WriteLine("El auto prende el motor");
        }
        public void Brake() {
            Console.WriteLine("Freno activado");
        }
        public void StopEngine() {
            Console.WriteLine("Motor Apagado");
        }
        public void Accelerate() {
            Console.WriteLine("Motor acelerando");
        }
    } 



}