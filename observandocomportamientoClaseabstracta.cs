// cuando se crea una variable de tipo clase madre, solo va  a poder usar los metodos que esta clase posea.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {
            // si creo moto como elemento vehiculo, aun usando elcontructor Motocicletas, este moto no puede usar los metodos y propeidades propios de motocicletas
            Vehiculos moto = new Motocicletas();
            // como moto1 es una motocicleta si tiene los metodos dueno
            Motocicletas moto1 = (Motocicletas)moto;
            Carros mercedes = new Carros();
            moto1.Dueno = "Luis";
            Console.WriteLine(moto1.Dueno);
        }
    }

    public abstract class Vehiculos
    {
        protected string marca;
        protected string color;
        protected string gamma;

        public abstract void prenderMotor();
        public void apagarMotor()
        {
            Console.WriteLine("Hola todos los vehiculos apagan su motor");
        }
    }

    public class Carros : Vehiculos
    {
        protected string dueno;
        public Carros(){}
        public Carros(string marca,string color,string gamma,string dueno)
        {
            this.marca = marca;
            this.color = color;
            this.gamma = gamma;
            this.Dueno = dueno;
        }

        public String Dueno {
            get{
                return this.dueno;
            }
            set{
                this.dueno = value;
            }
        }
        public override void prenderMotor()
        {
            Console.WriteLine("Hola el motor del coche prende con la llave");
        }
        public void apagarMotor()
        {
            Console.WriteLine("me definieron un dueno y es: " + this.dueno);
        }
    }

    public class Motocicletas : Vehiculos
    {
        protected string dueno;
        public Motocicletas(){}
        public Motocicletas(string marca,string color,string gamma,string dueno)
        {
            this.marca = marca;
            this.color = color;
            this.gamma = gamma;
            this.Dueno = dueno;
        }

        public String Dueno {
            get{
                return this.dueno;
            }
            set{
                this.dueno = value;
            }
        }
        public override void prenderMotor()
        {
            Console.WriteLine("Hola el motor dela motocicleta prende con la llave");
        }
        public void apagarMotor()
        {
            Console.WriteLine("Hola soy una motocicleta asi que me apago asi tuss");
        }
    }


} 