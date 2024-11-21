﻿namespace CatalogoForm
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
            btnSinOrdenar = new Button();
            pnBotonesVer.SuspendLayout();
            SuspendLayout();
            // 
            // lblMenuTitulo
            // 
            lblMenuTitulo.AutoSize = true;
            lblMenuTitulo.BackColor = SystemColors.ActiveCaption;
            lblMenuTitulo.Font = new Font("Impact", 40F, FontStyle.Bold);
            lblMenuTitulo.Location = new Point(35, 20);
            lblMenuTitulo.Name = "lblMenuTitulo";
            lblMenuTitulo.Size = new Size(482, 82);
            lblMenuTitulo.TabIndex = 0;
            lblMenuTitulo.Text = "MENU PRINCIPAL";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.SkyBlue;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.Font = new Font("Yu Gothic UI", 20F, FontStyle.Bold);
            btnVer.Location = new Point(35, 144);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(167, 270);
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
            bntAgregar.Location = new Point(588, 144);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(167, 93);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "Agregar Articulo";
            bntAgregar.UseVisualStyleBackColor = false;
            // 
            // bntBorrar
            // 
            bntBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntBorrar.BackColor = Color.Red;
            bntBorrar.Cursor = Cursors.No;
            bntBorrar.FlatStyle = FlatStyle.Popup;
            bntBorrar.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBorrar.Location = new Point(588, 304);
            bntBorrar.Name = "bntBorrar";
            bntBorrar.Size = new Size(167, 63);
            bntBorrar.TabIndex = 3;
            bntBorrar.Text = "BORRAR";
            bntBorrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Yu Gothic UI Semibold", 16F);
            btnSalir.Location = new Point(588, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(167, 41);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // pnBotonesVer
            // 
            pnBotonesVer.BackColor = Color.Transparent;
            pnBotonesVer.Controls.Add(btnFiltrar);
            pnBotonesVer.Controls.Add(btnOrdenarPorAtributo);
            pnBotonesVer.Controls.Add(btnOrdenarDefecto);
            pnBotonesVer.Controls.Add(btnSinOrdenar);
            pnBotonesVer.Location = new Point(214, 145);
            pnBotonesVer.Name = "pnBotonesVer";
            pnBotonesVer.Size = new Size(355, 270);
            pnBotonesVer.TabIndex = 5;
            pnBotonesVer.Visible = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LavenderBlush;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnFiltrar.Location = new Point(27, 210);
            btnFiltrar.Margin = new Padding(10);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(282, 49);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "FILTRAR Productos";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnOrdenarPorAtributo
            // 
            btnOrdenarPorAtributo.BackColor = Color.LavenderBlush;
            btnOrdenarPorAtributo.FlatStyle = FlatStyle.Popup;
            btnOrdenarPorAtributo.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarPorAtributo.Location = new Point(27, 141);
            btnOrdenarPorAtributo.Margin = new Padding(10);
            btnOrdenarPorAtributo.Name = "btnOrdenarPorAtributo";
            btnOrdenarPorAtributo.Size = new Size(282, 49);
            btnOrdenarPorAtributo.TabIndex = 2;
            btnOrdenarPorAtributo.Text = "Ordenar Por Atributo";
            btnOrdenarPorAtributo.UseVisualStyleBackColor = false;
            btnOrdenarPorAtributo.Click += btnOrdenarPorAtributo_Click;
            // 
            // btnOrdenarDefecto
            // 
            btnOrdenarDefecto.BackColor = Color.LavenderBlush;
            btnOrdenarDefecto.FlatStyle = FlatStyle.Popup;
            btnOrdenarDefecto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btnOrdenarDefecto.Location = new Point(27, 72);
            btnOrdenarDefecto.Margin = new Padding(10);
            btnOrdenarDefecto.Name = "btnOrdenarDefecto";
            btnOrdenarDefecto.Size = new Size(282, 49);
            btnOrdenarDefecto.TabIndex = 1;
            btnOrdenarDefecto.Text = "Lista Ordenada X Defecto";
            btnOrdenarDefecto.UseVisualStyleBackColor = false;
            btnOrdenarDefecto.Click += btnOrdenarDefecto_Click;
            // 
            // btnSinOrdenar
            // 
            btnSinOrdenar.BackColor = Color.LavenderBlush;
            btnSinOrdenar.FlatStyle = FlatStyle.Popup;
            btnSinOrdenar.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnSinOrdenar.Location = new Point(27, 3);
            btnSinOrdenar.Margin = new Padding(10);
            btnSinOrdenar.Name = "btnSinOrdenar";
            btnSinOrdenar.Size = new Size(282, 49);
            btnSinOrdenar.TabIndex = 0;
            btnSinOrdenar.Text = "Lista Sin Ordenar";
            btnSinOrdenar.UseVisualStyleBackColor = false;
            btnSinOrdenar.Click += btnSinOrdenar_Click;
            // 
            // MenuPrincipal
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 437);
            Controls.Add(pnBotonesVer);
            Controls.Add(btnSalir);
            Controls.Add(bntBorrar);
            Controls.Add(bntAgregar);
            Controls.Add(btnVer);
            Controls.Add(lblMenuTitulo);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "MenuPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "Catalogo Menu";
            pnBotonesVer.ResumeLayout(false);
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
        private Button btnSinOrdenar;
    }
}
