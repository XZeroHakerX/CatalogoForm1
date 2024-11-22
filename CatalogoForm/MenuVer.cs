using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoForm
{
    public partial class MenuVer : Form
    {
        public MenuVer()
        {
            InitializeComponent();
        }
        private void MenuVer_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnAnterior.Enabled = false;
            btnPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            txtId.Enabled = true;
            txtMarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtAtributo5.Enabled = true;
            txtAtributo6.Enabled = true;
            txtAtributo7.Enabled = true;
            txtAtributo8.Enabled = true;
            txtAtributo9.Enabled = true;
            txtAtributo10.Enabled = true;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            btnAnterior.Enabled = true;
            btnPrimero.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
            txtId.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;
            txtAtributo5.Enabled = false;
            txtAtributo6.Enabled = false;
            txtAtributo7.Enabled = false;
            txtAtributo8.Enabled = false;
            txtAtributo9.Enabled = false;
            txtAtributo10.Enabled = false;
        }
    }
}
