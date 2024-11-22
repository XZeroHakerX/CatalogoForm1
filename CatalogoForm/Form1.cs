using Catalogo.controller;

namespace CatalogoForm
{
    public partial class MenuPrincipal : Form
    {

        bool menuVerActivo = false;
        bool menuAgregarActivo = false;
        public MenuPrincipal()
        {
            InitializeComponent();
            pnBotonesVer.Visible = false;
        }



        private void btnVer_Click(object sender, EventArgs e)
        {
            if (menuAgregarActivo)
            {
                pnlBotonesAgregar.Visible = false;
                menuAgregarActivo = false;
            }
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

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (menuVerActivo)
            {
                pnBotonesVer.Visible = false;
                menuVerActivo = false;
            }
            if (menuAgregarActivo)
            {
                pnlBotonesAgregar.Visible = false;
                menuAgregarActivo = false;
            }
            else
            {
                pnlBotonesAgregar.Visible = true;
                menuAgregarActivo = true;

            }
        }

        private void btnSinOrdenar_Click(object sender, EventArgs e)
        {
            MenuVer menuVer = new MenuVer(1);
            menuVer.ShowDialog();
        }

        private void btnOrdenarDefecto_Click(object sender, EventArgs e)
        {
            MenuVer menuVer = new MenuVer(2);
            menuVer.ShowDialog();
        }

        private void btnOrdenarPorAtributo_Click(object sender, EventArgs e)
        {
            BotonesOrdenarColumna menuBotones = new BotonesOrdenarColumna();
            menuBotones.ShowDialog();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
