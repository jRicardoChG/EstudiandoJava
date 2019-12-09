using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {
    public class Program {
        public static void Main(string[] args) {
            MusicPlayer radio = new MP3Radio();
            // asi puedo liberar a vehiculo del tipo de dependencia que usa, se cumple tambien el prinicpio de liskov, la super clase puede ser reemplazada por sus subclases
            Vehicule carro = new Vehicule(radio);
        }
    }


// tengo una clase madre que agrupa varias clases de reproductores dentro d eun vehiculo, todo normal
    public abstract class MusicPlayer
    {
        public void Play(){}
    }

    public class FMRadio : MusicPlayer
    {

    }
    public class SatelliteRadio : MusicPlayer
    {

    }

    public class MP3Player : MusicPlayer
    {

    } 


    public class Vehicule
    {
        private MusicPlayer _radio;
        public Vehicule(MusicPlayer radio)
        {
            // si defino asi el contructor, solo podre aceptar obejtos de tipo MP3Player, no mas, la Clase queda fija y poco flexible
            //_radio = new MP3Player();
            // en este punto la clase define la forma de sus objetos, sin embargo se peude hacer la inversion del control de las dependencias
            // defineido el contructor como algo que toma un objeto de afuera de ti`po musicplayer, permite que en la funcion en la cual voy a ejecutar todo (Main, frontend, lo que sea)
            // tenga libertad de instanciar vehiculo con el tipo de objeto uqe se me de la gana
            _radio = radio;
        }
        public void DriveLikeTeenager()
        {
            _radio.Play();
        }

    }



}