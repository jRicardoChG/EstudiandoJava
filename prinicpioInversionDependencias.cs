// ENTENDIENDO DEPENDENCIAS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {
            // al crear esta instancia se crean las isntancias de las demas clases, si algo falla en algunas de las clases que definen a vehiculo tendre que verificar cual es la que falla, y esto cuesta tiempo y hace al software poco flexible 
            Vehicule carro = new Vehicule();

        }
    }

    public class Vehicule
    {
        // aqui se ha creado una dependencia, Vehiculo deende de radio para definirse, cualquier cambio en radio se vera reflejado en Vehiculo. si quisiera otra clase radio satelital, tendria que cambiar vehiculo, lo cual no es bueno con el paso del tiempo
        private Radio _radio = new Radio();
        private WindShieldWiper _wiper = new WindShieldWiper();
        private HeadLights _lights = new HeadLights();
        public void DriveInRain()
        {
            _radio.SetVolume(0.25);
            _wiper.WipeFront();
            _wiper.WipeRear();
            _lights.On();
        }
    }

    public class Radio
    {
        public void SetVolume(double amount)
        {

        }
    }

    public class WindShieldWiper
    {
        public void WipeFront(){}
        public void WipeRear(){}
    }
    public class HeadLights
    {
        public void On(){}
        public void Off(){}

    }
}