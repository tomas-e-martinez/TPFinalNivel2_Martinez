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
    public partial class formMain : Form
    {
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
    }
}
