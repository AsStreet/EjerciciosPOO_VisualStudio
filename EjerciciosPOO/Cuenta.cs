using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Cuenta
    {
        public string nCuenta;
        private float saldo;
        public float Dinero
        {
            get
            {
                return saldo;
            }
        }

        public Cuenta(string nCuenta, float saldo)
        {
            this.nCuenta = nCuenta;
            this.saldo = saldo;
        }

        public Cuenta(string nCuenta)
        {
            this.nCuenta = nCuenta;
            this.saldo = 0;
        }

        public void pagarRecibo(float cantidad)
        {
                this.saldo -= cantidad;
        }

        public void recibirAbono(float cantidad)
        {
            if (cantidad >= 0)
            {
                this.saldo += cantidad;
            }
        }
    }
}
