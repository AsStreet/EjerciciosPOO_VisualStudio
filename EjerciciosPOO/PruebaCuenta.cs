using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPOO
{
    public partial class PruebaCuenta : Form
    {
        ArrayList listaCuentas = new ArrayList();
        ArrayList listaPersonas = new ArrayList();
        int posicion = 0;
        
        public PruebaCuenta()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if(txCrearCuentaNumCuenta.Text != "" && txCrearCuentaSaldo.Text != "")
            {
                Cuenta c = new Cuenta(txCrearCuentaNumCuenta.Text, int.Parse(txCrearCuentaSaldo.Text));
                if (listaCuentas.Contains(c))
                    lblError.Text = "Ya existe este número de Cuenta";
                else
                {
                    listaCuentas.Add(c);
                    txCrearCuentaNumCuenta.Text = "";
                    txCrearCuentaSaldo.Text = "";
                    lblError.Text = "Cuenta creada correctamente";
                }
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            if(txCrearPersonaDni.Text != "")
            {
                Persona p = new Persona(txCrearPersonaDni.Text);
                if (listaPersonas.Contains(p))
                    lblError.Text = "Ya existe esta Persona";
                else
                {
                    listaPersonas.Add(p);
                    txCrearPersonaDni.Text = "";
                    lblError.Text = "Persona creada correctamente";
                }
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnAsignarCuenta_Click(object sender, EventArgs e)
        { 
            Boolean personaExiste = false;
            if (txAsginarCuentaDni.Text != "" && txAsignarCuentaNumCuenta.Text != "")
            {
                foreach (Persona p in listaPersonas)
                {
                    if (p.dni.Equals(txAsginarCuentaDni.Text))
                    {
                        personaExiste = true;
                        foreach (Cuenta c in listaCuentas)
                        {
                            if (c.nCuenta.Equals(txAsignarCuentaNumCuenta.Text))
                            {
                                Boolean sw = p.agregarCuenta(c);
                                if (sw)
                                {
                                    lblError.Text = "Cuenta asignada Correctamente";
                                    txAsginarCuentaDni.Text = "";
                                    txAsignarCuentaNumCuenta.Text = "";
                                    break;
                                }
                                else
                                    lblError.Text = "Alcanzado el límite de 3 cuentas";
                            }
                        }
                    }
                }
                if (! personaExiste)
                    lblError.Text = "No existe la Persona introducida";
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnConfirmarIngreso_Click(object sender, EventArgs e)
        {
            int posicion = -1;
            // Cuenta c1;

            if (txIngresarCuenta.Text != "" && txIngresarImporte.Text != "")
            {
                for (int i = 0; i < listaCuentas.Count; i++)
                {
                    Cuenta c = (Cuenta)listaCuentas[i];
                    if (c.nCuenta.Equals(txIngresarCuenta.Text))
                    {
                        posicion = i;
                        break;
                    }
                }
                if (posicion >= 0)
                {
                    Cuenta c = (Cuenta)listaCuentas[posicion];
                    listaCuentas.Remove(c);
                    c.recibirAbono(int.Parse(txIngresarImporte.Text));
                    listaCuentas.Add(c);
                    txIngresarCuenta.Text = "";
                    txIngresarImporte.Text = "";
                    lblError.Text = "Ingreso realizado correctamente";
                }
                else
                    lblError.Text = "No existe la Cuenta introducida";
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
            
        }

        private void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            int origen = -1, destino = -1;

            if (txTransferenciaDestino.Text != "" && txTransferenciaOrigen.Text != "" && txTransferenciaImporte.Text != "")
            {
                for (int i = 0; i < listaCuentas.Count; i++)
                {
                    Cuenta c = (Cuenta)listaCuentas[i];
                    if (txTransferenciaOrigen.Text.Equals(c.nCuenta))
                        origen = i;
                    else if (txTransferenciaDestino.Text.Equals(c.nCuenta))
                        destino = i;
                }
                if (origen != -1 && destino != -1)
                {
                    Cuenta cuentaOrigen = (Cuenta)listaCuentas[origen];
                    Cuenta cuentaDestino = (Cuenta)listaCuentas[destino];
                    listaCuentas.Remove(cuentaOrigen);
                    listaCuentas.Remove(cuentaDestino);
                    cuentaOrigen.pagarRecibo(int.Parse(txTransferenciaImporte.Text));
                    if (cuentaOrigen.Dinero < 0)
                        lblTransferenciaMoroso.Text = "MOROSO";
                    cuentaDestino.recibirAbono(int.Parse(txTransferenciaImporte.Text));
                    listaCuentas.Add(cuentaOrigen);
                    listaCuentas.Add(cuentaDestino);
                    txTransferenciaDestino.Text = "";
                    txTransferenciaOrigen.Text = "";
                    txTransferenciaImporte.Text = "";
                    lblError.Text = "Transferencia realizada correctamente";
                }
                else
                {
                    if (-1 == origen && -1 == destino)
                        lblError.Text = "No existen las Cuentas ni de Origen ni de Destino";
                    else if (-1 == origen && destino != -1)
                        lblError.Text = "No existe la Cuenta de Origen";
                    else
                        lblError.Text = "No existe la Cuenta de Destino";
                }
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnConfirmarPago_Click_1(object sender, EventArgs e)
        {
            int indicePersona = -1;
            int indiceCuenta = -1;
            
            // Hay que hacerlo con IndexOf
            
            if (txPagoCuenta.Text != "" && "" != txPagoImporte.Text)
            {
                for(int j = 0; j < listaPersonas.Count; j++)
                {
                    Persona p = (Persona)listaPersonas[j];
                    for (int i = 0; i < p.cuentas.Count; i++)
                    {
                        Cuenta c = (Cuenta)p.cuentas[i];
                        if (c.nCuenta.Equals(txPagoCuenta.Text))
                        {
                            indicePersona = j;
                            indiceCuenta = i;
                            break;
                        }
                    }
                    if (-1 != indicePersona)
                    {
                        Persona p2 = (Persona)listaPersonas[indicePersona];
                        Cuenta c = (Cuenta)p.cuentas[indiceCuenta];
                        p.cuentas.Remove(c);
                        c.pagarRecibo(int.Parse(txPagoImporte.Text));
                        p.cuentas.Add(c);
                        if (c.Dinero < 0)
                            lblPagoMoroso.Text = "MOROSO";
                        txPagoCuenta.Text = "";
                        txPagoImporte.Text = "";
                        lblError.Text = "Pago realizado correctamente";
                        break;
                    }
                    else
                        lblError.Text = "No existe la Cuenta";
                }
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos"; 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int posicion = 0;
            int cuenta = 1;
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Persona p = (Persona)listaPersonas[i];
                lblListadoDni.Text = p.dni;
                foreach(Cuenta c in p.cuentas)
                {
                    switch(cuenta){
                        case 1:
                            cuenta++;
                            lblListadoCuenta1NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta1Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            else
                                lblListadoMoroso.Text = "NO";
                            break;
                        case 2:
                            cuenta++;
                            lblListadoCuenta2NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta2Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            break;
                        case 3:
                            lblListadoCuenta3NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta3Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            break;
                    }
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(posicion > 0)
            {
                posicion--;
                listar();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(posicion < listaPersonas.Count - 1)
            {
                posicion++;
                listar();
            }
        }

        private void listar()
        {
            int cuenta = 1;
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Persona p = (Persona)listaPersonas[i];
                lblListadoDni.Text = p.dni;
                foreach (Cuenta c in p.cuentas)
                {
                    switch (cuenta)
                    {
                        case 1:
                            cuenta++;
                            lblListadoCuenta1NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta1Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            else
                                lblListadoMoroso.Text = "NO";
                            break;
                        case 2:
                            cuenta++;
                            lblListadoCuenta2NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta2Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            break;
                        case 3:
                            lblListadoCuenta3NumCuenta.Text = c.nCuenta;
                            lblListadoCuenta3Saldo.Text = c.Dinero.ToString();
                            if (c.Dinero < 0)
                                lblListadoMoroso.Text = "SI";
                            break;
                    }
                }
            }
        }
    }
}
