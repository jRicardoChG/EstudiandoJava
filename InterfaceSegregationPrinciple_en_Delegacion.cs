// patron adaptador
// Como se conecta una clase existente que requiere una pequeña interface a una compleja implementacion o interface usando el patron adaptador
// recordar de interfaces y clases abstractas no se puedencrear contructores y por lo tanto no se pueden isntanciar objetos
// pero si se pueden crear objeto de tipo clase madre abstracta (o interface) pero instanciados en clases hijas que implmenten sus metodos
// con esto 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {


        }
    }

// interface sencilla para llenar tanque de vehiculo sencillo
    public interface IVehiculeSimpleFuel
    {
        void AddFuel(double amount);
    }

// tengo un vehivulo que al ir a una estacion de servicio no requiere medir su nivel de gasolina primero
    public class Vehicule
    {
        // esta clase usa el objeto adaptador para pdoer usar un unico metodo 
        private IVehiculeSimpleFuel _vehiculeFuel =  new VehiculeFuelAdapter();

// este vehiculo cuando llega a la estacion de servicio solo añade gasolina, usa la interface IVehiculeSimpleFuel atraves de una variable declarada
        public void StopAtServiceStation()
        {
            _vehiculeFuel.AddFuel(0.35);
        }
    } 

// creo el adaptador que usa la interface sencilla
    public class VehiculeFuelAdapter : IVehiculeSimpleFuel
    {
        // creo un objeto de tipo interface compleja pero lo instancio en la clase que implementa esta interface
        private IFuelTank _fuelTank = new ComplexFuelTank();
        // que paso? _fuelTank es un objeto de una clase (ComplexfuelTank) que ya implemento todos los metodos de la interface compleja IFuelTank
        // a Conitnuacion se define AddFuel() dado que se esta implmentando la interface simple IvehiculeSimpleFuel
        // Esta clase sencilla (VehiculeFuelAdapter) lo unico que queria era implementar el metodo IncreaseFuel de la clase compleja, pero no todos los demas metodos, asi uqe usa el objeto como adapatador
        public void AddFuel(double amount)
        {
            // Esta es la funcion que queriamos usar realmente para definir la funcion AddFuel()
            _fuelTank.IncreseFuel(amount);
        }

    }

// interface "Grande"
    public interface IFuelTank
    {
        void IncreseFuel();
        void DecreseFuel();
        double MedirNivel();
    }


// implementa toda la interface porque es la mas compleja y requiere toda la informacion
    public class ComplexFuelTank : IFuelTank
    {        
        public void IncreseFuel()
        {
            Console.WriteLine("Aumenta el nivel del tanque");
        }
        public DecreseFuel()
        {
            Console.WriteLine("Disminuye el nivel del tanque");
        }
        public double MedirNivel()
        {
            Console.WriteLine("Se ha medido el gas");
        }
        public static void Saludar()
        {
            Console.WriteLine("Hola te saludo desde ComplexFuelTank");
        }
    } 





}
