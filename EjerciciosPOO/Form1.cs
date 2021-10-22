using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Form ejercicio1 = new PruebaRectangulo();
            ejercicio1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Form ejercicio2= new PruebaCoche();
            ejercicio2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Form ejercicio3 = new PruebaTiempo();
            ejercicio3.Show();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Form ejercicio4 = new PruebaCuenta();
            ejercicio4.Show();
        }

        private void btnEjercicio5_Click(object sender, EventArgs e)
        {
            Form ejercicio5 = new PruebaLibros();
            ejercicio5.Show();
        }
    }
}
