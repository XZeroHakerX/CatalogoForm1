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
    public partial class BotonesOrdenarColumna : Form
    {
        public BotonesOrdenarColumna()
        {
            InitializeComponent();
            
        }

        private void btnOrdenarTipo_Click(object sender, EventArgs e)
        {
            MenuVer menuVer = new MenuVer(3, null, null, null, null);
            this.Visible = false;
            menuVer.ShowDialog();
            this.Close();

        }

        private void btnOrdenarIdproducto_Click(object sender, EventArgs e)
        {

            MenuVer menuVer = new MenuVer(4, null, null, null, null);
            this.Visible = false;
            menuVer.ShowDialog();
            this.Close();
        }

        private void btnOrdenarMarca_Click(object sender, EventArgs e)
        {

            MenuVer menuVer = new MenuVer(5, null, null, null, null);
            this.Visible = false;
            menuVer.ShowDialog();
            this.Close();
        }

        private void btnOrdenarPrecio_Click(object sender, EventArgs e)
        {

            MenuVer menuVer = new MenuVer(6, null, null, null, null);
            this.Visible = false;
            menuVer.ShowDialog();
            this.Close();
        }
    }
}
