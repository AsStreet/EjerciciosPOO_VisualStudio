using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int numPag { get; set; }
        public int valoracion { get; set; }

        public Libro(string titulo, string autor, int numPag, int valoracion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numPag = numPag;
            this.valoracion = valoracion;
        }
    }
}
