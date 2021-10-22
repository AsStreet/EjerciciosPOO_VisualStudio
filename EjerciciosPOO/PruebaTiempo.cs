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
    public partial class PruebaTiempo : Form
    {
        public PruebaTiempo()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txHora.Text != "" && txMinuto.Text != "" && txSegundo.Text != "") 
            {
                Tiempo t = new Tiempo(int.Parse(txHora.Text), int.Parse(txMinuto.Text), int.Parse(txSegundo.Text));
                lblHora.Text = t.hora.ToString();
                lblMinuto.Text = t.minuto.ToString();
                lblSegundo.Text = t.segundo.ToString();
            }
            else if(txHora.Text != "" && txMinuto.Text != "" && "" == txSegundo.Text)
            {
                Tiempo t = new Tiempo(int.Parse(txHora.Text), int.Parse(txMinuto.Text));
                lblHora.Text = t.hora.ToString();
                lblMinuto.Text = t.minuto.ToString();
                lblSegundo.Text = t.segundo.ToString();
            }else if(txHora.Text != "" && "" == txMinuto.Text && "" == txSegundo.Text)
            {
                Tiempo t = new Tiempo(int.Parse(txHora.Text));
                lblHora.Text = t.hora.ToString();
                lblMinuto.Text = t.minuto.ToString();
                lblSegundo.Text = t.segundo.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tiempo t = new Tiempo(int.Parse(txHora.Text), int.Parse(txMinuto.Text), int.Parse(txSegundo.Text));
            lblHora.Text = t.getHora().ToString();
            lblMinuto.Text = t.getMinuto().ToString();
            lblSegundo.Text = t.getSegundo().ToString();
        }
    }
}
