using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Coche
    {
        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int caballos { get; set; }
        public int puertas { get; set; }

        public Coche()
        {

        }

        public Coche(string color, string marca, string modelo, int caballos, int puertas)
        {
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
            this.caballos = caballos;
            this.puertas = puertas;
        }

        public string datos()
        {
            string cadena = "Color: " + color + " Marca: " + marca + " Modelo: " + modelo + " Caballos: " + caballos + " Puertas: " + puertas;

            return cadena;
        }
    }
}
