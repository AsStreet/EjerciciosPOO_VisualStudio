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
    public partial class PruebaRectangulo : Form
    {
        public PruebaRectangulo()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (!txAltura.Text.Equals("") && !txBase.Text.Equals(""))
            {
                Rectangulo r1 = new Rectangulo(int.Parse(txAltura.Text), int.Parse(txBase.Text));
                lblArea.Text = r1.calcularArea().ToString();
            }
            else
            {
                lblArea.Text = "ERROR";
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (!txAltura.Text.Equals("") && !txBase.Text.Equals(""))
            {
                Rectangulo r1 = new Rectangulo(int.Parse(txAltura.Text), int.Parse(txBase.Text));
                lblPerimetro.Text = r1.calcularPerimetro().ToString();
            }
            else
            {
                lblPerimetro.Text = "ERROR";
            }
        }
    }
}
