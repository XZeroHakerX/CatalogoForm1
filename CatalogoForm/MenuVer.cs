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

        public MenuVer(int opcion, int? tipo, int? idProducto, string? marca, double? precio)
        {
            cbd = ControladorBD.getControlador();

            InitializeComponent();
            EleccionMenu(opcion, tipo, idProducto, marca, precio);
            MostrarMenu();
        }

    //Metodo para traer la lista correcta:
        private void EleccionMenu(int opcion, int? tipo, int? idProducto, string? marca, double? precio)
        {
            switch (opcion)
            {
                case 1:
                    aux = cbd.VerBD();
                    lblTitulo.Text = "Lista Sin Ordenar:";
                    break;
                case 2:
                    aux = cbd.OrdenarPorDefecto();
                    lblTitulo.Text = "Lista Ordenada Por Defecto:";
                    break;
                case 3:
                    aux = cbd.OrdenarPorColumna(opcion);
                    lblTitulo.Text = "Lista Ordenada Por TIPO:";
                    break;
                case 4:
                    aux = cbd.OrdenarPorColumna(opcion);
                    lblTitulo.Text = "Lista Ordenada Por IDPRODUCTO:";
                    break;
                case 5:
                    aux = cbd.OrdenarPorColumna(opcion);
                    lblTitulo.Text = "Lista Ordenada Por MARCA:";
                    break;
                case 6:
                    aux = cbd.OrdenarPorColumna(opcion);
                    lblTitulo.Text = "Lista Ordenada Por PRECIO:";
                    break;
                case 7:
                    aux = cbd.FiltrarProductoPrecio(opcion, tipo, null, null, null);
                    lblTitulo.Text = "Lista FILTRADA Por TIPO:";
                    break;
                case 8:
                    aux = cbd.FiltrarProductoPrecio(opcion, null, idProducto, null, null);
                    lblTitulo.Text = "Lista FILTRADA Por IDPRODUCTO:";
                    break;
                case 9:
                    aux = cbd.FiltrarProductoPrecio(opcion, null, null, marca, null);
                    lblTitulo.Text = "Lista FILTRADA Por MARCA:";
                    break;
                case 10:
                case 11:
                case 12:
                    lblTitulo.Text = "Lista FILTRADA Por PRECIO:";
                    aux = cbd.FiltrarProductoPrecio(opcion, null, null, null, precio);
                    break;
                default:
                    aux = cbd.FiltrarProductoPrecio(opcion, null, null, null, null);
                    break;
            }
        }

    //Metodo para actualizar vista menu:
        private void MostrarMenu()
        {
            if (aux == null || aux.Count == 0)
            {
                throw new ArgumentException();
            }

            ActivarDesactivarNavegacion();
            AtributosSegunProductos();
            MostrarArticulo();


        }

    //Metodo para mostrar el articulo actual:
        private void MostrarArticulo()
        {
            txtTipo.Text = ((TipoPeriferico)aux[cont].Tipo).ToString();
            txtId.Text = aux[cont].IdProducto.ToString();
            txtMarca.Text = aux[cont].Marca.ToString();
            txtPrecio.Text = aux[cont].Precio.ToString();
            if (aux[cont].Tipo == 0)
            {
                Raton r = (Raton)aux[cont];
                txtAtributo5.Text = r.NumBotones.ToString();
                txtAtributo6.Text = r.TipoSenal;
                txtAtributo7.Text = r.Voltaje.ToString();
                txtAtributo8.Text = r.Dpi.ToString();
                txtAtributo9.Text = r.Hergonomico.ToString();
                txtAtributo10.Text = r.RuletaCentral.ToString();
            }

            else if (aux[cont].Tipo == 1)
            {
                Teclado t = (Teclado)aux[cont];
                txtAtributo5.Text = t.NumBotones.ToString();
                txtAtributo6.Text = t.TipoSenal;
                txtAtributo7.Text = t.Voltaje.ToString();
                txtAtributo8.Text = t.NumTeclasNumerico.ToString();
                txtAtributo9.Text = t.EsMecanico.ToString();
                txtAtributo10.Text = t.TecladoNumerico.ToString();
            }
            else if (aux[cont].Tipo == 2)
            {
                Pantalla p = (Pantalla)aux[cont];
                txtAtributo5.Text = p.RangoVolumen.ToString();
                txtAtributo6.Text = p.Color;
                txtAtributo7.Text = p.Decibelios.ToString();
                txtAtributo8.Text = p.Pulgadas.ToString();
                txtAtributo9.Text = p.TieneAltavoces.ToString();
                txtAtributo10.Text = p.EsHd.ToString();
            }
            else if (aux[cont].Tipo == 3)
            {
                Altavoz a = (Altavoz)aux[cont];
                txtAtributo5.Text = a.RangoVolumen.ToString();
                txtAtributo6.Text = a.Color;
                txtAtributo7.Text = a.Decibelios.ToString();
                txtAtributo8.Text = a.Alto.ToString();
                txtAtributo9.Text = a.SonidoHq.ToString();
                txtAtributo10.Text = a.TieneBotonApagado.ToString();
            }
        }

    //Metodo para cambiar  
        private void AtributosSegunProductos()
        {
            if (aux[cont].Tipo == 0)
            {
                lblAtributo5.Text = "Num. Botones:";
                lblAtributo6.Text = "Tipo Señal:";
                lblAtributo7.Text = "Voltaje:";
                lblAtributo8.Text = "DPI:";
                lblAtributo9.Text = "Es Hergonomico?";
                lblAtributo10.Text = "Ruleta central?";
            }

            else if (aux[cont].Tipo == 1)
            {
                lblAtributo5.Text = "Num. Botones:";
                lblAtributo6.Text = "Tipo Señal:";
                lblAtributo7.Text = "Voltaje:";
                lblAtributo8.Text = "Num. Bot. NUME:";
                lblAtributo9.Text = "Es Mecanico?";
                lblAtributo10.Text = "Tiene T.NUM.?";
            }
            else if (aux[cont].Tipo == 2)
            {
                lblAtributo5.Text = "Rango:";
                lblAtributo6.Text = "Color:";
                lblAtributo7.Text = "Decibelios:";
                lblAtributo8.Text = "Pulgadas:";
                lblAtributo9.Text = "Altavoces?";
                lblAtributo10.Text = "ES HD?";
            }
            else if (aux[cont].Tipo == 3)
            {
                lblAtributo5.Text = "Rango:";
                lblAtributo6.Text = "Color:";
                lblAtributo7.Text = "Decibelios:";
                lblAtributo8.Text = "Tamaño:";
                lblAtributo9.Text = "Sonido HQ?";
                lblAtributo10.Text = "Boton Apagado?";
            }
            else
            {
                throw new Exception();
            }

        }

    //Metodo para comprobacion de Botones NAVEGACION:
        private void ActivarDesactivarNavegacion()
        {
            //Marcador de Producto
            lblMarcador.Text = $"{cont + 1} / {aux.Count}";

            //Comprobaciones para activar o no los botones Primero o Anterior
            if (cont == 0)
            {
                btnAnterior.Enabled = false;
                btnPrimero.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
                btnPrimero.Enabled = true;
            }

            //Comprobaciones para activar o no los botones Siguiente o Ultimo
            if (cont == aux.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
        }

    //Metodo para el boton MODIFICAR:
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnAnterior.Enabled = false;
            btnPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            txtId.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtAtributo5.ReadOnly = false;
            txtAtributo6.ReadOnly = false;
            txtAtributo7.ReadOnly = false;
            txtAtributo8.ReadOnly = false;
            txtAtributo9.ReadOnly = false;
            txtAtributo10.ReadOnly = false;

            txtId.BackColor = SystemColors.Window;
            txtMarca.BackColor = SystemColors.Window;
            txtPrecio.BackColor = SystemColors.Window;
            txtAtributo5.BackColor = SystemColors.Window;
            txtAtributo6.BackColor = SystemColors.Window;
            txtAtributo7.BackColor = SystemColors.Window;
            txtAtributo8.BackColor = SystemColors.Window;
            txtAtributo9.BackColor = SystemColors.Window;
            txtAtributo10.BackColor = SystemColors.Window;

        }

    //Metodo para guardar os cambios:
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

    //Metodo para el boton CANCELAR:
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtId.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtAtributo5.ReadOnly = true;
            txtAtributo6.ReadOnly = true;
            txtAtributo7.ReadOnly = true;
            txtAtributo8.ReadOnly = true;
            txtAtributo9.ReadOnly = true;
            txtAtributo10.ReadOnly = true;

            txtId.BackColor = Color.SkyBlue;
            txtMarca.BackColor = Color.SkyBlue;
            txtPrecio.BackColor = Color.SkyBlue;
            txtAtributo5.BackColor = Color.SkyBlue;
            txtAtributo6.BackColor = Color.SkyBlue;
            txtAtributo7.BackColor = Color.SkyBlue;
            txtAtributo8.BackColor = Color.SkyBlue;
            txtAtributo9.BackColor = Color.SkyBlue;
            txtAtributo10.BackColor = Color.SkyBlue;
            MostrarArticulo();
            ActivarDesactivarNavegacion();
        }


    //Metodos para botones de NAVEGACION:
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cont = 0;
            MostrarMenu();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cont--;
            MostrarMenu();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            cont++;
            MostrarMenu();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cont = aux.Count - 1;
            MostrarMenu();
        }

        
    }
}
