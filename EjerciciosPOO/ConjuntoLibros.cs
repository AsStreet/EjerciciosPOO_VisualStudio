using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class ConjuntoLibros
    {
        public Libro[] coleccion = new Libro[10];

        public Boolean eliminarLibro(Libro l)
        {
            int posicion = -1;

            if (coleccion.Contains(l))
            {
                Libro[] aux = new Libro[10];
                for(int i = 0; i < coleccion.Length; i++)
                {
                    if (coleccion[i] != null)
                        if (! coleccion[i].titulo.Equals(l.titulo))
                            aux[i] = coleccion[i];
                }
                coleccion = aux;
                return true;
            }
            else
                return false;
        }

        public Boolean agregarLibro(Libro l)
        {
            Boolean sw = false;
            
            if (coleccion.Contains(l))
                return sw;
            else
            {
                for (int i = 0; i < coleccion.Length; i++)
                {
                    if (null == coleccion[i])
                    {
                        coleccion[i] = l;
                        sw = true;
                        break;
                    }
                }
                return sw;
            }
        }

        public int mayorPuntuacion()
        {
            List<int> puntuaciones = new List<int>();
            for(int i = 0; i < coleccion.Length; i++)
                if(coleccion[i] != null)
                    puntuaciones.Add(coleccion[i].valoracion);      
            return puntuaciones.Max();
        }

        public int menorPuntuacion()
        {
            List<int> puntuaciones = new List<int>();
            for (int i = 0; i < coleccion.Length; i++)
                if (coleccion[i] != null)
                    puntuaciones.Add(coleccion[i].valoracion);
            return puntuaciones.Min();
        }

        public Libro[] getColeccion()
        {
            return this.coleccion;
        }

        public void setColeccion(Libro[] coleccion)
        {
            this.coleccion = coleccion;
        }
    }
}
