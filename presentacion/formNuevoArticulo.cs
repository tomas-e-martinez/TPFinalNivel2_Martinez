using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class formNuevoArticulo : Form
    {
        private Articulo articulo = null;
        public formNuevoArticulo()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo artículo";
        }

        public formNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lblTitulo.Text = "Modificar artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (!(soloNumeros(txtPrecio.Text)))
                return;

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Nombre = txtNombre.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado con éxito.");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado con éxito.");
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, revise que el valor para el campo 'Precio' esté escrito correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString())  ;
            }
        }

        private void formNuevoArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedIndex = -1;
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString("F2");
                    txtUrlImagen.Text = articulo.ImagenUrl;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;

                    cargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            validarCampos();
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

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void validarCampos()
        {
            if(string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || cboCategoria.SelectedIndex == -1 || cboMarca.SelectedIndex == -1)
                btnAceptar.Enabled = false;
            else
                btnAceptar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            validarCampos();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

            validarCampos();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)) && (caracter != ',' && caracter != '.'))
                {
                    MessageBox.Show("Solo se pueden ingresar números o comas/puntos en el campo de 'Precio'.");
                    return false;
                }
            }
            return true;
        }
    }
}
