using Catalogo.controller;

namespace CatalogoForm
{
    public partial class MenuPrincipal : Form
    {

        bool menuVerActivo = false;
        public MenuPrincipal()
        {
            InitializeComponent();
            pnBotonesVer.Visible = false;
        }



        private void btnVer_Click(object sender, EventArgs e)
        {
            if (menuVerActivo)
            {
                pnBotonesVer.Visible = false;
                menuVerActivo = false;
            }
            else
            {
                pnBotonesVer.Visible = true;
                menuVerActivo = true;

            }

        }

        private void btnSinOrdenar_Click(object sender, EventArgs e)
        {
            MenuVer menuVer = new MenuVer();
            menuVer.ShowDialog();
        }

        private void btnOrdenarDefecto_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarPorAtributo_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
