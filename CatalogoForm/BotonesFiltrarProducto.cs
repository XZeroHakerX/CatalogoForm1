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
    public partial class BotonesFiltrarProducto : Form
    {
        
        int opcion;
        MenuVer menuVer;
        public BotonesFiltrarProducto()
        {
            InitializeComponent();
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 7:
                    {
                        int tipo;
                        if (comboBox1.Text.Equals("Raton"))
                        {
                            tipo = 0;
                        }else if (comboBox1.Text.Equals("Teclado"))
                        {
                            tipo = 1;
                        }else if (comboBox1.Text.Equals("Pantalla"))
                        {
                            tipo = 2;
                        }
                        else
                        {
                            tipo = 3;
                        }


                        menuVer = new MenuVer(opcion, tipo, null, null, null);
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }
                case 8:
                    {
                        menuVer = new MenuVer(opcion, null, Int32.Parse(txtIdProducto.Text), null, null);
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }
                case 9:
                    {
                        menuVer = new MenuVer(opcion, null, null, txtMarca.Text , null);
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }
                case 10:
                    {
                        menuVer = new MenuVer(opcion, null, null, null, double.Parse(txtPrecioIgual.Text) );
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }
                case 11:
                    {
                        menuVer = new MenuVer(opcion, null, null, null, double.Parse(txtPrecioMayor.Text));
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }
                case 12:
                    {
                        menuVer = new MenuVer(opcion, null, null, null, double.Parse(txtPrecioMenor.Text));
                        this.Visible = false;
                        menuVer.ShowDialog();
                        this.Close();
                        break;
                    }


            }
          
        }

        private void rbtnFiltrarTipo_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            comboBox1.Enabled = true;
            opcion = 7;
        }

        private void rbtnFiltrarIdProducto_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            txtIdProducto.Enabled = true;
            opcion = 8;
        }

        private void rbtnFiltrarMarca_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            txtMarca.Enabled = true;
            opcion = 9;
        }

        private void rbtnPrecioIgual_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            txtPrecioIgual.Enabled = true;
            opcion = 10;
        }

        private void rbtnPrecioMayor_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            txtPrecioMayor.Enabled = true;
            opcion = 11;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Cerrar();
            txtPrecioMenor.Enabled = true;
            opcion = 12;
        }

        private void Cerrar()
        {
            comboBox1.Enabled = false;
            txtIdProducto.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecioIgual.Enabled = false;
            txtPrecioMayor.Enabled = false;
            txtPrecioMenor.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
