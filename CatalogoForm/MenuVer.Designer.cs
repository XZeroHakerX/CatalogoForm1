﻿namespace CatalogoForm
{
    partial class MenuVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVer));
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            lblMarcador = new Label();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlProducto = new Panel();
            txtPrecio = new TextBox();
            txtAtributo10 = new TextBox();
            txtAtributo9 = new TextBox();
            txtAtributo8 = new TextBox();
            txtAtributo7 = new TextBox();
            txtAtributo6 = new TextBox();
            txtAtributo5 = new TextBox();
            txtMarca = new TextBox();
            txtId = new TextBox();
            lblAtributo10 = new Label();
            lblAtributo9 = new Label();
            lblAtributo8 = new Label();
            lblAtributo7 = new Label();
            lblAtributo6 = new Label();
            lblAtributo5 = new Label();
            lblPrecio = new Label();
            lblMarca = new Label();
            lblId = new Label();
            pbxImagen = new PictureBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            lblTitulo = new Label();
            btnAtras = new Button();
            pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnPrimero
            // 
            btnPrimero.Cursor = Cursors.Hand;
            btnPrimero.FlatStyle = FlatStyle.Popup;
            btnPrimero.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPrimero.Location = new Point(42, 451);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(102, 52);
            btnPrimero.TabIndex = 0;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatStyle = FlatStyle.Popup;
            btnAnterior.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAnterior.Location = new Point(150, 451);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(102, 52);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Cursor = Cursors.Hand;
            btnUltimo.FlatStyle = FlatStyle.Popup;
            btnUltimo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnUltimo.Location = new Point(602, 451);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(102, 52);
            btnUltimo.TabIndex = 3;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatStyle = FlatStyle.Popup;
            btnSiguiente.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSiguiente.Location = new Point(494, 451);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(102, 52);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblMarcador
            // 
            lblMarcador.AutoSize = true;
            lblMarcador.BackColor = Color.Transparent;
            lblMarcador.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblMarcador.Location = new Point(339, 463);
            lblMarcador.Name = "lblMarcador";
            lblMarcador.Size = new Size(68, 35);
            lblMarcador.TabIndex = 4;
            lblMarcador.Text = "1 / 1";
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 14F);
            btnModificar.Location = new Point(755, 100);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(181, 51);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Cursor = Cursors.No;
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Font = new Font("Segoe UI", 14F);
            btnBorrar.Location = new Point(755, 336);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(181, 51);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.PaleGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(755, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 51);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 14F);
            btnCancelar.Location = new Point(755, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(181, 48);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlProducto
            // 
            pnlProducto.Controls.Add(txtPrecio);
            pnlProducto.Controls.Add(txtAtributo10);
            pnlProducto.Controls.Add(txtAtributo9);
            pnlProducto.Controls.Add(txtAtributo8);
            pnlProducto.Controls.Add(txtAtributo7);
            pnlProducto.Controls.Add(txtAtributo6);
            pnlProducto.Controls.Add(txtAtributo5);
            pnlProducto.Controls.Add(txtMarca);
            pnlProducto.Controls.Add(txtId);
            pnlProducto.Controls.Add(lblAtributo10);
            pnlProducto.Controls.Add(lblAtributo9);
            pnlProducto.Controls.Add(lblAtributo8);
            pnlProducto.Controls.Add(lblAtributo7);
            pnlProducto.Controls.Add(lblAtributo6);
            pnlProducto.Controls.Add(lblAtributo5);
            pnlProducto.Controls.Add(lblPrecio);
            pnlProducto.Controls.Add(lblMarca);
            pnlProducto.Controls.Add(lblId);
            pnlProducto.Controls.Add(pbxImagen);
            pnlProducto.Location = new Point(42, 100);
            pnlProducto.Name = "pnlProducto";
            pnlProducto.Size = new Size(695, 345);
            pnlProducto.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.SkyBlue;
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Segoe UI", 18F);
            txtPrecio.Location = new Point(448, 288);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(165, 47);
            txtPrecio.TabIndex = 19;
            // 
            // txtAtributo10
            // 
            txtAtributo10.BackColor = Color.SkyBlue;
            txtAtributo10.Cursor = Cursors.IBeam;
            txtAtributo10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo10.ForeColor = Color.MidnightBlue;
            txtAtributo10.Location = new Point(222, 294);
            txtAtributo10.Name = "txtAtributo10";
            txtAtributo10.ReadOnly = true;
            txtAtributo10.Size = new Size(180, 39);
            txtAtributo10.TabIndex = 17;
            // 
            // txtAtributo9
            // 
            txtAtributo9.BackColor = Color.SkyBlue;
            txtAtributo9.Cursor = Cursors.IBeam;
            txtAtributo9.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo9.ForeColor = Color.MidnightBlue;
            txtAtributo9.Location = new Point(222, 254);
            txtAtributo9.Name = "txtAtributo9";
            txtAtributo9.ReadOnly = true;
            txtAtributo9.Size = new Size(180, 39);
            txtAtributo9.TabIndex = 16;
            // 
            // txtAtributo8
            // 
            txtAtributo8.BackColor = Color.SkyBlue;
            txtAtributo8.Cursor = Cursors.IBeam;
            txtAtributo8.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo8.ForeColor = Color.MidnightBlue;
            txtAtributo8.Location = new Point(222, 213);
            txtAtributo8.Name = "txtAtributo8";
            txtAtributo8.ReadOnly = true;
            txtAtributo8.Size = new Size(180, 39);
            txtAtributo8.TabIndex = 15;
            txtAtributo8.WordWrap = false;
            // 
            // txtAtributo7
            // 
            txtAtributo7.BackColor = Color.SkyBlue;
            txtAtributo7.Cursor = Cursors.IBeam;
            txtAtributo7.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo7.ForeColor = Color.MidnightBlue;
            txtAtributo7.Location = new Point(222, 172);
            txtAtributo7.Name = "txtAtributo7";
            txtAtributo7.ReadOnly = true;
            txtAtributo7.Size = new Size(180, 39);
            txtAtributo7.TabIndex = 14;
            // 
            // txtAtributo6
            // 
            txtAtributo6.BackColor = Color.SkyBlue;
            txtAtributo6.Cursor = Cursors.IBeam;
            txtAtributo6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo6.ForeColor = Color.MidnightBlue;
            txtAtributo6.Location = new Point(222, 130);
            txtAtributo6.Name = "txtAtributo6";
            txtAtributo6.ReadOnly = true;
            txtAtributo6.Size = new Size(180, 39);
            txtAtributo6.TabIndex = 13;
            // 
            // txtAtributo5
            // 
            txtAtributo5.BackColor = Color.SkyBlue;
            txtAtributo5.Cursor = Cursors.IBeam;
            txtAtributo5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo5.ForeColor = Color.MidnightBlue;
            txtAtributo5.Location = new Point(222, 90);
            txtAtributo5.Name = "txtAtributo5";
            txtAtributo5.ReadOnly = true;
            txtAtributo5.Size = new Size(180, 39);
            txtAtributo5.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.SkyBlue;
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtMarca.ForeColor = Color.MidnightBlue;
            txtMarca.Location = new Point(222, 49);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(180, 39);
            txtMarca.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BackColor = Color.SkyBlue;
            txtId.Cursor = Cursors.IBeam;
            txtId.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtId.ForeColor = Color.MidnightBlue;
            txtId.Location = new Point(222, 7);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(180, 39);
            txtId.TabIndex = 10;
            // 
            // lblAtributo10
            // 
            lblAtributo10.AutoSize = true;
            lblAtributo10.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo10.Location = new Point(26, 300);
            lblAtributo10.Margin = new Padding(5);
            lblAtributo10.Name = "lblAtributo10";
            lblAtributo10.Size = new Size(156, 31);
            lblAtributo10.TabIndex = 9;
            lblAtributo10.Text = "ATRIBUTO10: ";
            // 
            // lblAtributo9
            // 
            lblAtributo9.AutoSize = true;
            lblAtributo9.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo9.Location = new Point(26, 259);
            lblAtributo9.Margin = new Padding(5);
            lblAtributo9.Name = "lblAtributo9";
            lblAtributo9.Size = new Size(147, 31);
            lblAtributo9.TabIndex = 8;
            lblAtributo9.Text = "ATRIBUTO9: ";
            // 
            // lblAtributo8
            // 
            lblAtributo8.AutoSize = true;
            lblAtributo8.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo8.Location = new Point(26, 218);
            lblAtributo8.Margin = new Padding(5);
            lblAtributo8.Name = "lblAtributo8";
            lblAtributo8.Size = new Size(147, 31);
            lblAtributo8.TabIndex = 7;
            lblAtributo8.Text = "ATRIBUTO8: ";
            // 
            // lblAtributo7
            // 
            lblAtributo7.AutoSize = true;
            lblAtributo7.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo7.Location = new Point(26, 177);
            lblAtributo7.Margin = new Padding(5);
            lblAtributo7.Name = "lblAtributo7";
            lblAtributo7.Size = new Size(146, 31);
            lblAtributo7.TabIndex = 6;
            lblAtributo7.Text = "ATRIBUTO7: ";
            // 
            // lblAtributo6
            // 
            lblAtributo6.AutoSize = true;
            lblAtributo6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo6.Location = new Point(26, 136);
            lblAtributo6.Margin = new Padding(5);
            lblAtributo6.Name = "lblAtributo6";
            lblAtributo6.Size = new Size(147, 31);
            lblAtributo6.TabIndex = 5;
            lblAtributo6.Text = "ATRIBUTO6: ";
            // 
            // lblAtributo5
            // 
            lblAtributo5.AutoSize = true;
            lblAtributo5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtributo5.Location = new Point(26, 95);
            lblAtributo5.Margin = new Padding(5);
            lblAtributo5.Name = "lblAtributo5";
            lblAtributo5.Size = new Size(147, 31);
            lblAtributo5.TabIndex = 4;
            lblAtributo5.Text = "ATRIBUTO5: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(452, 254);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(103, 31);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "PRECIO: ";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 54);
            lblMarca.Margin = new Padding(5);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(105, 31);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "MARCA: ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(26, 13);
            lblId.Margin = new Padding(5);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 31);
            lblId.TabIndex = 1;
            lblId.Text = "ID: ";
            // 
            // pbxImagen
            // 
            pbxImagen.Location = new Point(419, 3);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(273, 249);
            pbxImagen.TabIndex = 0;
            pbxImagen.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 16F);
            lblTipo.Location = new Point(68, 60);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(73, 37);
            lblTipo.TabIndex = 10;
            lblTipo.Text = "TIPO";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.SkyBlue;
            txtTipo.Cursor = Cursors.IBeam;
            txtTipo.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtTipo.ForeColor = Color.MidnightBlue;
            txtTipo.Location = new Point(263, 62);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(180, 39);
            txtTipo.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(68, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 37);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Lista Sin Ordenar";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Gainsboro;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Font = new Font("Segoe UI", 14F);
            btnAtras.Location = new Point(753, 455);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(181, 48);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // MenuVer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 526);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(pnlProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(lblMarcador);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MenuVer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Vista";
            pnlProducto.ResumeLayout(false);
            pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Label lblMarcador;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Panel pnlProducto;
        private Label lblPrecio;
        private Label lblMarca;
        private Label lblId;
        private PictureBox pbxImagen;
        private Label lblAtributo6;
        private Label lblAtributo5;
        private Label lblAtributo10;
        private Label lblAtributo9;
        private Label lblAtributo8;
        private Label lblAtributo7;
        private TextBox txtId;
        private Label lblTipo;
        private TextBox txtAtributo10;
        private TextBox txtAtributo9;
        private TextBox txtAtributo8;
        private TextBox txtAtributo7;
        private TextBox txtAtributo6;
        private TextBox txtAtributo5;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtTipo;
        private Label lblTitulo;
        private Button btnAtras;
    }
}