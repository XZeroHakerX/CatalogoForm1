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
using static System.Net.Mime.MediaTypeNames;

namespace CatalogoForm
{
    public partial class AgregarArticulo : Form
    {

        int articuloElegido;
        ControladorBD cbd;
        public AgregarArticulo(int articulo)
        {
            cbd = ControladorBD.getControlador();
            InitializeComponent();
            AtributosProducto(articulo);
            CambiarTipo(articulo);
            articuloElegido = articulo;

        }

        private void CambiarTipo(int articulo)
        {
            if (articulo == 0)
            {
                txtTipo.Text = "RATON";
            }
            else if (articulo == 1)
            {
                txtTipo.Text = "TECLADO";
            }
            else if (articulo == 2)
            {
                txtTipo.Text = "PANTALLA";
            }
            else
            {
                txtTipo.Text = "ALTAVOZ";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cbd.AgregarElemento(articuloElegido, Int32.Parse(txtId.Text), txtMarca.Text, Double.Parse(txtPrecio.Text), Int32.Parse(txtAtributo5.Text), txtAtributo6.Text,
                        Double.Parse(txtAtributo7.Text), Int32.Parse(txtAtributo8.Text), Boolean.Parse(comboAtribute9.SelectedItem.ToString()), Boolean.Parse(comboAtribute10.SelectedItem.ToString()));

                MessageBox.Show("Articulo agregado correctamente.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algun dato es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtributosProducto(int articulo)
        {

            if (articulo == 0)
            {
                lblAtributo5.Text = "Num. Botones:";
                lblAtributo6.Text = "Tipo Señal:";
                lblAtributo7.Text = "Voltaje:";
                lblAtributo8.Text = "DPI:";
                lblAtributo9.Text = "Es Hergonomico?";
                lblAtributo10.Text = "Ruleta central?";
            }

            else if (articulo == 1)
            {
                lblAtributo5.Text = "Num. Botones:";
                lblAtributo6.Text = "Tipo Señal:";
                lblAtributo7.Text = "Voltaje:";
                lblAtributo8.Text = "Num. Bot. NUME:";
                lblAtributo9.Text = "Es Mecanico?";
                lblAtributo10.Text = "Tiene T.NUM.?";
            }
            else if (articulo == 2)
            {
                lblAtributo5.Text = "Rango:";
                lblAtributo6.Text = "Color:";
                lblAtributo7.Text = "Decibelios:";
                lblAtributo8.Text = "Pulgadas:";
                lblAtributo9.Text = "Altavoces?";
                lblAtributo10.Text = "ES HD?";
            }
            else if (articulo == 3)
            {
                lblAtributo5.Text = "Rango:";
                lblAtributo6.Text = "Color:";
                lblAtributo7.Text = "Decibelios:";
                lblAtributo8.Text = "Tamaño:";
                lblAtributo9.Text = "Sonido HQ?";
                lblAtributo10.Text = "Boton Apagado?";
            }
        }

        
    }
}
