using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Persona
    {
        public string dni;
        public ArrayList cuentas = new ArrayList();

        public Persona(string dni)
        {
            this.dni = dni;
        }

        public Boolean agregarCuenta(Cuenta c)
        {
            if (cuentas.Count < 3)
            {
                cuentas.Add(c);
                return true;
            }
            else
                return false;
        }

        public Boolean moroso()
        {
            Boolean sw = false;
            foreach (Cuenta c in cuentas)
            {
                if (c.Dinero < 0)
                {
                    sw = true;
                    break;
                }
            }
            return sw;
        }
    }
}
