using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class formMain : Form
    {
        private List<Articulo> listaArticulos;
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formNuevoArticulo formAgregar = new formNuevoArticulo();
            formAgregar.Text = "Agregar artículo";
            formAgregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formNuevoArticulo formModificar = new formNuevoArticulo();
            formModificar.Text = "Modificar artículo";
            formModificar.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            formInfoArticulo formInfoArticulo = new formInfoArticulo();
            formInfoArticulo.ShowDialog();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://www.svgrepo.com/show/508699/landscape-placeholder.svg");
            }
        }
    }
}
