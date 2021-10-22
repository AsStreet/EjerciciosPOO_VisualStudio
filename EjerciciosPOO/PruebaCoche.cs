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
    public partial class PruebaCoche : Form
    {

        public static ArrayList lista = new ArrayList();
        int posicion = 0;
        public PruebaCoche()
        {
            InitializeComponent();
        }

        private void btnAgregarCoche_Click(object sender, EventArgs e)
        {
            if(txColor.Text != "" && txMarca.Text != "" && txModelo.Text != "" && txCaballos.Text != "" && txPuertas.Text != "")
            {
                Coche c1 = new Coche(txColor.Text, txMarca.Text, txModelo.Text, int.Parse(txCaballos.Text), int.Parse(txPuertas.Text));
                lista.Add(c1);
                txMarca.Text = "";
                txModelo.Text = "";
                txColor.Text = "";
                txCaballos.Text = "";
                txPuertas.Text = "";
            }
            else
            {
                lblError.Text = "No puede dejar campos vacíos";
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.posicion = 0;
            Coche c1 = (Coche)lista[posicion];
            txMarca.Text = c1.marca;
            txModelo.Text = c1.modelo;
            txColor.Text = c1.color;
            txCaballos.Text = c1.caballos.ToString();
            txPuertas.Text = c1.puertas.ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.posicion > 0)
            {
                this.posicion--;
                listar();
            }     
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.posicion < lista.Count - 1)
            {
                this.posicion++;
                listar();
            }
        }

        private void btnEditarColor_Click(object sender, EventArgs e)
        {
            Coche c1 = (Coche)lista[posicion];
            if(c1.color.Equals(txColor.Text))
            {
                lblError.Text = "El color es el mismo";
            }
            else
            {
                Coche c2 = new Coche(txColor.Text, c1.marca, c1.modelo, c1.caballos, c1.puertas);
                lista.Remove(c1);
                lista.Add(c2);
            }
        }

        private void listar()
        {
            Coche c1 = (Coche)lista[posicion];
            txMarca.Text = c1.marca;
            txModelo.Text = c1.modelo;
            txColor.Text = c1.color;
            txCaballos.Text = c1.caballos.ToString();
            txPuertas.Text = c1.puertas.ToString();
        }
    }
}
