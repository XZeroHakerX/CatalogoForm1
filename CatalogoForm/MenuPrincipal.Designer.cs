namespace CatalogoForm
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lblMenuTitulo = new Label();
            btnVer = new Button();
            bntAgregar = new Button();
            bntBorrar = new Button();
            btnSalir = new Button();
            pnBotonesVer = new Panel();
            btnFiltrar = new Button();
            btnOrdenarPorAtributo = new Button();
            btnOrdenarDefecto = new Button();
            pnlBotonesAgregar = new Panel();
            btnAgregarAltavoz = new Button();
            btnAgregarPantalla = new Button();
            btnAgregarTeclado = new Button();
            btnAgregarRaton = new Button();
            label1 = new Label();
            pnBotonesVer.SuspendLayout();
            pnlBotonesAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // lblMenuTitulo
            // 
            lblMenuTitulo.AutoSize = true;
            lblMenuTitulo.BackColor = SystemColors.ActiveCaption;
            lblMenuTitulo.Font = new Font("Impact", 40F, FontStyle.Bold);
            lblMenuTitulo.Location = new Point(44, 25);
            lblMenuTitulo.Margin = new Padding(4, 0, 4, 0);
            lblMenuTitulo.Name = "lblMenuTitulo";
            lblMenuTitulo.Size = new Size(571, 98);
            lblMenuTitulo.TabIndex = 0;
            lblMenuTitulo.Text = "MENU PRINCIPAL";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.SkyBlue;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.Font = new Font("Yu Gothic UI", 20F, FontStyle.Bold);
            btnVer.Location = new Point(44, 180);
            btnVer.Margin = new Padding(4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(209, 338);
            btnVer.TabIndex = 1;
            btnVer.Text = "Lista Articulos";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntAgregar.BackColor = Color.LightGreen;
            bntAgregar.Cursor = Cursors.Hand;
            bntAgregar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            bntAgregar.FlatAppearance.BorderSize = 4;
            bntAgregar.FlatStyle = FlatStyle.Popup;
            bntAgregar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            bntAgregar.Location = new Point(872, 180);
            bntAgregar.Margin = new Padding(4);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(209, 116);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "Agregar Articulo";
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // bntBorrar
            // 
            bntBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntBorrar.BackColor = Color.Red;
            bntBorrar.Cursor = Cursors.No;
            bntBorrar.FlatStyle = FlatStyle.Popup;
            bntBorrar.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBorrar.Location = new Point(872, 396);
            bntBorrar.Margin = new Padding(4);
            bntBorrar.Name = "bntBorrar";
            bntBorrar.Size = new Size(209, 79);
            bntBorrar.TabIndex = 3;
            bntBorrar.Text = "BORRAR";
            bntBorrar.UseVisualStyleBackColor = false;
            bntBorrar.Click += bntBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Yu Gothic UI Semibold", 16F);
            btnSalir.Location = new Point(872, 482);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(209, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnBotonesVer
            // 
            pnBotonesVer.BackColor = Color.Transparent;
            pnBotonesVer.Controls.Add(btnFiltrar);
            pnBotonesVer.Controls.Add(btnOrdenarPorAtributo);
            pnBotonesVer.Controls.Add(btnOrdenarDefecto);
            pnBotonesVer.Location = new Point(274, 180);
            pnBotonesVer.Margin = new Padding(4);
            pnBotonesVer.Name = "pnBotonesVer";
            pnBotonesVer.Size = new Size(398, 338);
            pnBotonesVer.TabIndex = 5;
            pnBotonesVer.Visible = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.DodgerBlue;
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnFiltrar.Location = new Point(34, 241);
            btnFiltrar.Margin = new Padding(12);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(352, 85);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "FILTRAR Productos";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnOrdenarPorAtributo
            // 
            btnOrdenarPorAtributo.BackColor = Color.DodgerBlue;
            btnOrdenarPorAtributo.Cursor = Cursors.Hand;
            btnOrdenarPorAtributo.FlatStyle = FlatStyle.Popup;
            btnOrdenarPorAtributo.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarPorAtributo.Location = new Point(34, 129);
            btnOrdenarPorAtributo.Margin = new Padding(12);
            btnOrdenarPorAtributo.Name = "btnOrdenarPorAtributo";
            btnOrdenarPorAtributo.Size = new Size(352, 88);
            btnOrdenarPorAtributo.TabIndex = 2;
            btnOrdenarPorAtributo.Text = "Ordenar Por Atributo";
            btnOrdenarPorAtributo.UseVisualStyleBackColor = false;
            btnOrdenarPorAtributo.Click += btnOrdenarPorAtributo_Click;
            // 
            // btnOrdenarDefecto
            // 
            btnOrdenarDefecto.BackColor = Color.DodgerBlue;
            btnOrdenarDefecto.Cursor = Cursors.Hand;
            btnOrdenarDefecto.FlatStyle = FlatStyle.Popup;
            btnOrdenarDefecto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btnOrdenarDefecto.Location = new Point(34, 9);
            btnOrdenarDefecto.Margin = new Padding(12);
            btnOrdenarDefecto.Name = "btnOrdenarDefecto";
            btnOrdenarDefecto.Size = new Size(352, 96);
            btnOrdenarDefecto.TabIndex = 1;
            btnOrdenarDefecto.Text = "Lista Ordenada Por Defecto";
            btnOrdenarDefecto.UseVisualStyleBackColor = false;
            btnOrdenarDefecto.Click += btnOrdenarDefecto_Click;
            // 
            // pnlBotonesAgregar
            // 
            pnlBotonesAgregar.BackColor = Color.Transparent;
            pnlBotonesAgregar.Controls.Add(btnAgregarAltavoz);
            pnlBotonesAgregar.Controls.Add(btnAgregarPantalla);
            pnlBotonesAgregar.Controls.Add(btnAgregarTeclado);
            pnlBotonesAgregar.Controls.Add(btnAgregarRaton);
            pnlBotonesAgregar.Location = new Point(285, 201);
            pnlBotonesAgregar.Margin = new Padding(4);
            pnlBotonesAgregar.Name = "pnlBotonesAgregar";
            pnlBotonesAgregar.Size = new Size(562, 303);
            pnlBotonesAgregar.TabIndex = 6;
            pnlBotonesAgregar.Visible = false;
            // 
            // btnAgregarAltavoz
            // 
            btnAgregarAltavoz.BackColor = Color.Lime;
            btnAgregarAltavoz.Cursor = Cursors.Hand;
            btnAgregarAltavoz.FlatStyle = FlatStyle.Popup;
            btnAgregarAltavoz.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnAgregarAltavoz.Image = (Image)resources.GetObject("btnAgregarAltavoz.Image");
            btnAgregarAltavoz.Location = new Point(283, 154);
            btnAgregarAltavoz.Margin = new Padding(12);
            btnAgregarAltavoz.Name = "btnAgregarAltavoz";
            btnAgregarAltavoz.Size = new Size(271, 133);
            btnAgregarAltavoz.TabIndex = 3;
            btnAgregarAltavoz.Text = "Agregar ALTAVOZ";
            btnAgregarAltavoz.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarAltavoz.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregarAltavoz.UseVisualStyleBackColor = false;
            btnAgregarAltavoz.Click += btnAgregarAltavoz_Click;
            // 
            // btnAgregarPantalla
            // 
            btnAgregarPantalla.BackColor = Color.Lime;
            btnAgregarPantalla.Cursor = Cursors.Hand;
            btnAgregarPantalla.FlatStyle = FlatStyle.Popup;
            btnAgregarPantalla.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnAgregarPantalla.Image = (Image)resources.GetObject("btnAgregarPantalla.Image");
            btnAgregarPantalla.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarPantalla.Location = new Point(0, 154);
            btnAgregarPantalla.Margin = new Padding(12);
            btnAgregarPantalla.Name = "btnAgregarPantalla";
            btnAgregarPantalla.Size = new Size(271, 133);
            btnAgregarPantalla.TabIndex = 2;
            btnAgregarPantalla.Text = "Agregar PANTALLA";
            btnAgregarPantalla.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarPantalla.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregarPantalla.UseVisualStyleBackColor = false;
            btnAgregarPantalla.Click += btnAgregarPantalla_Click;
            // 
            // btnAgregarTeclado
            // 
            btnAgregarTeclado.BackColor = Color.Lime;
            btnAgregarTeclado.Cursor = Cursors.Hand;
            btnAgregarTeclado.FlatStyle = FlatStyle.Popup;
            btnAgregarTeclado.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnAgregarTeclado.Image = (Image)resources.GetObject("btnAgregarTeclado.Image");
            btnAgregarTeclado.Location = new Point(283, 8);
            btnAgregarTeclado.Margin = new Padding(12);
            btnAgregarTeclado.Name = "btnAgregarTeclado";
            btnAgregarTeclado.Size = new Size(271, 130);
            btnAgregarTeclado.TabIndex = 1;
            btnAgregarTeclado.Text = "Agregar TECLADO";
            btnAgregarTeclado.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarTeclado.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregarTeclado.UseVisualStyleBackColor = false;
            btnAgregarTeclado.Click += btnAgregarTeclado_Click;
            // 
            // btnAgregarRaton
            // 
            btnAgregarRaton.BackColor = Color.Lime;
            btnAgregarRaton.Cursor = Cursors.Hand;
            btnAgregarRaton.FlatStyle = FlatStyle.Popup;
            btnAgregarRaton.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnAgregarRaton.Image = (Image)resources.GetObject("btnAgregarRaton.Image");
            btnAgregarRaton.Location = new Point(0, 8);
            btnAgregarRaton.Margin = new Padding(12);
            btnAgregarRaton.Name = "btnAgregarRaton";
            btnAgregarRaton.RightToLeft = RightToLeft.No;
            btnAgregarRaton.Size = new Size(271, 130);
            btnAgregarRaton.TabIndex = 0;
            btnAgregarRaton.Text = "Agregar RATON";
            btnAgregarRaton.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarRaton.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregarRaton.UseVisualStyleBackColor = false;
            btnAgregarRaton.Click += btnAgregarRaton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(12, 528);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 7;
            label1.Text = "V 1.4.A";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 562);
            Controls.Add(label1);
            Controls.Add(pnlBotonesAgregar);
            Controls.Add(pnBotonesVer);
            Controls.Add(btnSalir);
            Controls.Add(bntBorrar);
            Controls.Add(bntAgregar);
            Controls.Add(btnVer);
            Controls.Add(lblMenuTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MenuPrincipal";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo Menu";
            pnBotonesVer.ResumeLayout(false);
            pnlBotonesAgregar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuTitulo;
        private Button btnVer;
        private Button bntAgregar;
        private Button bntBorrar;
        private Button btnSalir;
        private Panel pnBotonesVer;
        private Button btnFiltrar;
        private Button btnOrdenarPorAtributo;
        private Button btnOrdenarDefecto;
        private Panel pnlBotonesAgregar;
        private Button btnAgregarAltavoz;
        private Button btnAgregarPantalla;
        private Button btnAgregarTeclado;
        private Button btnAgregarRaton;
        private Label label1;
    }
}
