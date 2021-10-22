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
    public partial class PruebaLibros : Form
    {

        int posicion = 0;
        ConjuntoLibros cl = new ConjuntoLibros();
        
        public PruebaLibros()
        {
            InitializeComponent();
        }

        private void btnCrearLibroAgregar_Click(object sender, EventArgs e)
        {
            Boolean sw = false;

            if (txCrearLibroAutor.Text != "" && txCrearLibroPaginas.Text != "" && txCrearLibroTitulo.Text != "" && cbCrearLibroValoracion.SelectedItem.ToString() != "")
            {
                Libro l = new Libro(txCrearLibroTitulo.Text, txCrearLibroAutor.Text, int.Parse(txCrearLibroPaginas.Text), int.Parse(cbCrearLibroValoracion.SelectedItem.ToString()));
                sw = cl.agregarLibro(l);
                if (sw)
                {
                    txCrearLibroTitulo.Text = "";
                    txCrearLibroAutor.Text = "";
                    txCrearLibroPaginas.Text = "";
                    cbCrearLibroValoracion.SelectedIndex = 0;
                    lblError.Text = "Libro creado correctamente";
                }
                else
                    lblError.Text = "Ya existe ese Libro en la Colección";
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnModificarLibroEditar_Click(object sender, EventArgs e)
        {
            if (txModificarLibroTitulo.Text != "" && cbModificarLibroValoracion.SelectedItem.ToString() != "")
            {
                int posicion = -1;
                for(int i = 0; i < cl.coleccion.Length; i++)
                {
                    if(cl.coleccion[i] != null)
                    {
                        if (cl.coleccion[i].titulo.Equals(txModificarLibroTitulo.Text))
                        {
                            posicion = i;
                            break;
                        }
                    }
                    
                }
                if (posicion != -1)
                {
                    Libro l = cl.coleccion[posicion];
                    l.valoracion = int.Parse(cbModificarLibroValoracion.SelectedItem.ToString());
                    cl.coleccion[posicion] = l;
                    lblError.Text = "Libro modificado correctamente";
                }
                else
                    lblError.Text = "No existe el Libro introducido";
            }
            else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cl.coleccion[posicion] != null)
            {
                Libro l = cl.coleccion[posicion];
                lblColeccionTitulo.Text = l.titulo;
                lblColeccionAutor.Text = l.autor;
                lblColeccionPaginas.Text = l.numPag.ToString();
                lblColeccionValoracion.Text = l.valoracion.ToString();
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
            if(posicion < cl.coleccion.Length - 1)
            {
                posicion++;
                listar();
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if(txEliminarLibro.Text != "")
            {
                int indice = -1;
                for(int i = 0; i < cl.coleccion.Length; i++)
                {
                    if(cl.coleccion[i] != null)
                    {
                        if (cl.coleccion[i].titulo.Equals(txEliminarLibro.Text))
                        {
                            indice = i;
                            break;
                        }
                    }
                    
                }
                if (indice != -1)
                {
                    Boolean sw = cl.eliminarLibro(cl.coleccion[indice]);
                    if(sw)
                        lblError.Text = "Libro eliminado correctamente";
                    else
                        lblError.Text = "No existe el Libro que quiere eliminar";
                    posicion = 0;
                }
                else
                    lblError.Text = "No existe el Libro que quiere eliminar";
            }else
                lblError.Text = "No se pueden dejar campos clave vacíos";
        }

        private void btnValoraciones_Click(object sender, EventArgs e)
        {
            if (cl.coleccion.Length > 0)
            {
                lblMaximaValoracion.Text = cl.mayorPuntuacion().ToString();
                lblMinimaValoracion.Text = cl.menorPuntuacion().ToString();
            }
            else
                lblError.Text = "No hay valoraciones almacenadas";
            
        }

        public void listar()
        {
            if(cl.coleccion[posicion] != null) {
                Libro l = cl.coleccion[posicion];
                lblColeccionTitulo.Text = l.titulo;
                lblColeccionAutor.Text = l.autor;
                lblColeccionPaginas.Text = l.numPag.ToString();
                lblColeccionValoracion.Text = l.valoracion.ToString();
            }
        }
    }
}
