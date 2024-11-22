using Catalogo.controller;
using Catalogo.model;
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
        List<Periferico> aux;
        ControladorBD cbd;
        int cont = 0;
        public MenuVer(int opcion)
        {
            cbd = ControladorBD.getControlador();
            if (cbd == null)
            {
                throw new Exception();
            }
            InitializeComponent();
            EleccionMenu(opcion);
            MostrarMenu(aux);
        }

        private void EleccionMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    aux = cbd.VerBD();
                    break;
                case 2:
                    aux = cbd.OrdenarPorDefecto();
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    aux = cbd.OrdenarPorColumna(opcion);
                    break;
                default:
                    aux = cbd.FiltrarProductoPrecio(opcion,null,null,null,null);
                    break;
            }
        }
        private void MostrarMenu(List<Periferico>? aux)
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
