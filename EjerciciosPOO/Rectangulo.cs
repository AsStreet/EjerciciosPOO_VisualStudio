using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Rectangulo
    {
        private int baseR { get; set; }
        private int altura { get; set; }

        public Rectangulo(int altura, int baseR)
        {
            this.baseR = baseR;
            this.altura = altura;
        }

        public int calcularArea()
        {
            int area = baseR * altura;
            return area;
        }

        public int calcularPerimetro()
        {
            int perimetro = baseR * 2 + altura * 2;
            return perimetro;
        }
    }
}
