using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Tiempo
    {
        public int hora;
        public int minuto;
        public int segundo;

        public Tiempo(int hora, int minuto, int segundo)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
                if (minuto >= 0 && minuto <= 59)
                {
                    this.minuto = minuto;
                    if (segundo >= 0 && segundo <= 59)
                    {
                        this.segundo = segundo;
                    }
                    else
                    {
                        this.segundo = 0;
                    }
                }
                else
                {
                    this.minuto = 0;
                    if (segundo >= 0 && segundo <= 59)
                    {
                        this.segundo = segundo;
                    }
                    else
                    {
                        this.segundo = 0;
                    }
                }
            }
            else
            {
                this.hora = 0;
                if (minuto >= 0 && minuto <= 59)
                {
                    this.minuto = minuto;
                    if (segundo >= 0 && segundo <= 59)
                    {
                        this.segundo = segundo;
                    }
                    else
                    {
                        this.segundo = 0;
                    }
                }
                else
                {
                    this.minuto = 0;
                    if (segundo >= 0 && minuto <= 59)
                    {
                        this.segundo = segundo;
                    }
                    else
                    {
                        this.segundo = 0;
                    }
                }
            }
        }

        public Tiempo(int hora, int minuto)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
                if (minuto >= 0 && minuto <= 59)
                {
                    this.minuto = minuto;
                }
                else
                {
                    this.minuto = 0;
                }
            }
            else
            {
                this.hora = 0;
                if (minuto >= 0 && minuto <= 59)
                {
                    this.minuto = minuto;
                }
                else
                {
                    this.minuto = 0;
                }
            }
            this.segundo = 0;
        }

        public Tiempo(int hora)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
                this.minuto = 0;
                this.segundo = 0;
            }
            else
            {
                this.hora = 0;
                this.minuto = 0;
                this.segundo = 0;
            }
        }

        public int getHora()
        {
            return hora;
        }

        public void setHora(int hora)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
            }
            else
            {
                this.hora = 0;
            }
        }

        public int getMinuto()
        {
            return minuto;
        }

        public void setMinuto(int minuto)
        {
            if (minuto >= 0 && minuto <= 23)
            {
                this.minuto = minuto;
            }
            else
            {
                this.minuto = 0;
            }
        }

        public int getSegundo()
        {
            return segundo;
        }

        public void setSegundo(int segundo)
        {
            if (segundo >= 0 && segundo <= 23)
            {
                this.segundo = segundo;
            }
            else
            {
                this.segundo = 0;
            }
        }
    }
}
