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
    public partial class MenuBorrar : Form
    {
        ControladorBD cbd;
        public MenuBorrar()
        {

            InitializeComponent();
            cbd = ControladorBD.getControlador();
            CargarLista();
        }

        private void CargarListaDetalles()
        {
            clstBorrar.Items.Clear();
            foreach (Periferico p in cbd.OrdenarPorDefecto())
            {
          
                clstBorrar.Items.Add(p);
            }
        }

        private void CargarLista()
        {
            clstBorrar.Items.Clear();
            foreach (Periferico p in cbd.OrdenarPorDefecto())
            {
                clstBorrar.Items.Add($"{(TipoPeriferico)p.Tipo}: {p.IdProducto} ( {p.Marca} ) -->> {p.Precio:C}");
            }
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            var indicesSeleccionados = clstBorrar.CheckedIndices;
            if (indicesSeleccionados.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún articulo.", "Ningun Articulo Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (indicesSeleccionados.Count == 1)
                {
                    dg = MessageBox.Show("¿Borrar Articulo?", "Borrar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    dg = MessageBox.Show($"¿Borrar {indicesSeleccionados.Count} Articulos Seleccionados?", "Borrar Articulos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (dg == DialogResult.Yes)
                {
                    for (int i = indicesSeleccionados.Count - 1; i >= 0; i--)
                    {
                        cbd.BorrarElemento(indicesSeleccionados[i]);
                    }

                    CargarLista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {

            CargarListaDetalles();
            btnMas.Visible = false;
            btnMenos.Visible = true;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            CargarLista();
            btnMas.Visible = true;
            btnMenos.Visible = false;
        }
    }
}
