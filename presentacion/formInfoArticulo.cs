using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class formInfoArticulo : Form
    {
        private Articulo articulo;
        public formInfoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formInfoArticulo_Load(object sender, EventArgs e)
        {
            cargarImagen(articulo.ImagenUrl);
            lblNombre.Text = articulo.Nombre;
            lblCodigo.Text = articulo.Codigo;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("C2");
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }
        }
    }
}
