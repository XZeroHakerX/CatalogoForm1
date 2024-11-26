namespace CatalogoForm
{
    partial class AgregarArticulo
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
            lblTitulo = new Label();
            txtTipo = new TextBox();
            lblTipo = new Label();
            pnlProducto = new Panel();
            comboAtribute10 = new ComboBox();
            comboAtribute9 = new ComboBox();
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
            lblMarca = new Label();
            lblId = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            pbxImagen = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnCargarImagen = new Button();
            pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(33, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(211, 37);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Agregar Articulo";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.LightCyan;
            txtTipo.Cursor = Cursors.IBeam;
            txtTipo.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtTipo.ForeColor = Color.MidnightBlue;
            txtTipo.Location = new Point(228, 60);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(180, 39);
            txtTipo.TabIndex = 22;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 16F);
            lblTipo.Location = new Point(33, 58);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(73, 37);
            lblTipo.TabIndex = 21;
            lblTipo.Text = "TIPO";
            // 
            // pnlProducto
            // 
            pnlProducto.Controls.Add(comboAtribute10);
            pnlProducto.Controls.Add(comboAtribute9);
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
            pnlProducto.Controls.Add(lblMarca);
            pnlProducto.Controls.Add(lblId);
            pnlProducto.Location = new Point(6, 105);
            pnlProducto.Name = "pnlProducto";
            pnlProducto.Size = new Size(413, 338);
            pnlProducto.TabIndex = 20;
            // 
            // comboAtribute10
            // 
            comboAtribute10.Font = new Font("Segoe UI", 12F);
            comboAtribute10.FormattingEnabled = true;
            comboAtribute10.Items.AddRange(new object[] { "true", "false" });
            comboAtribute10.Location = new Point(222, 298);
            comboAtribute10.Margin = new Padding(2);
            comboAtribute10.Name = "comboAtribute10";
            comboAtribute10.Size = new Size(180, 36);
            comboAtribute10.TabIndex = 21;
            // 
            // comboAtribute9
            // 
            comboAtribute9.Font = new Font("Segoe UI", 12F);
            comboAtribute9.FormattingEnabled = true;
            comboAtribute9.Items.AddRange(new object[] { "true", "false" });
            comboAtribute9.Location = new Point(222, 258);
            comboAtribute9.Margin = new Padding(2);
            comboAtribute9.Name = "comboAtribute9";
            comboAtribute9.Size = new Size(180, 36);
            comboAtribute9.TabIndex = 20;
            // 
            // txtAtributo8
            // 
            txtAtributo8.BackColor = Color.LightCyan;
            txtAtributo8.Cursor = Cursors.IBeam;
            txtAtributo8.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo8.ForeColor = Color.MidnightBlue;
            txtAtributo8.Location = new Point(222, 213);
            txtAtributo8.Name = "txtAtributo8";
            txtAtributo8.PlaceholderText = "Integer";
            txtAtributo8.Size = new Size(180, 39);
            txtAtributo8.TabIndex = 15;
            txtAtributo8.WordWrap = false;
            // 
            // txtAtributo7
            // 
            txtAtributo7.BackColor = Color.LightCyan;
            txtAtributo7.Cursor = Cursors.IBeam;
            txtAtributo7.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo7.ForeColor = Color.MidnightBlue;
            txtAtributo7.Location = new Point(222, 172);
            txtAtributo7.Name = "txtAtributo7";
            txtAtributo7.PlaceholderText = "Double use \",\"";
            txtAtributo7.Size = new Size(180, 39);
            txtAtributo7.TabIndex = 14;
            // 
            // txtAtributo6
            // 
            txtAtributo6.BackColor = Color.LightCyan;
            txtAtributo6.Cursor = Cursors.IBeam;
            txtAtributo6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo6.ForeColor = Color.MidnightBlue;
            txtAtributo6.Location = new Point(222, 130);
            txtAtributo6.Name = "txtAtributo6";
            txtAtributo6.PlaceholderText = "String";
            txtAtributo6.Size = new Size(180, 39);
            txtAtributo6.TabIndex = 13;
            // 
            // txtAtributo5
            // 
            txtAtributo5.BackColor = Color.LightCyan;
            txtAtributo5.Cursor = Cursors.IBeam;
            txtAtributo5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtAtributo5.ForeColor = Color.MidnightBlue;
            txtAtributo5.Location = new Point(222, 90);
            txtAtributo5.Name = "txtAtributo5";
            txtAtributo5.PlaceholderText = "Integer";
            txtAtributo5.Size = new Size(180, 39);
            txtAtributo5.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.LightCyan;
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtMarca.ForeColor = Color.MidnightBlue;
            txtMarca.Location = new Point(222, 49);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "String";
            txtMarca.Size = new Size(180, 39);
            txtMarca.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BackColor = Color.LightCyan;
            txtId.Cursor = Cursors.IBeam;
            txtId.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            txtId.ForeColor = Color.MidnightBlue;
            txtId.Location = new Point(222, 7);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Integer";
            txtId.Size = new Size(180, 39);
            txtId.TabIndex = 10;
            txtId.Tag = "";
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
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 54);
            lblMarca.Margin = new Padding(5);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(91, 31);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca: ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(26, 13);
            lblId.Margin = new Padding(5);
            lblId.Name = "lblId";
            lblId.Size = new Size(149, 31);
            lblId.TabIndex = 1;
            lblId.Text = "Id Producto: ";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightCyan;
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Segoe UI", 20F);
            txtPrecio.Location = new Point(429, 384);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Double ";
            txtPrecio.Size = new Size(159, 52);
            txtPrecio.TabIndex = 19;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(438, 330);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(103, 31);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "PRECIO: ";
            // 
            // pbxImagen
            // 
            pbxImagen.Location = new Point(429, 105);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(190, 169);
            pbxImagen.TabIndex = 0;
            pbxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 14F);
            btnCancelar.Location = new Point(463, 482);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 34);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.PaleTurquoise;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(228, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 59);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Font = new Font("Yu Gothic", 10F, FontStyle.Bold);
            btnCargarImagen.Location = new Point(458, 277);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(130, 29);
            btnCargarImagen.TabIndex = 26;
            btnCargarImagen.Text = "Cargar Img.";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // AgregarArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(631, 559);
            Controls.Add(btnCargarImagen);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(lblTitulo);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(pnlProducto);
            Controls.Add(pbxImagen);
            Controls.Add(lblPrecio);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "AgregarArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarArticulo";
            pnlProducto.ResumeLayout(false);
            pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTipo;
        private Label lblTipo;
        private Panel pnlProducto;
        private TextBox txtPrecio;
        private TextBox txtAtributo8;
        private TextBox txtAtributo7;
        private TextBox txtAtributo6;
        private TextBox txtAtributo5;
        private TextBox txtMarca;
        private TextBox txtId;
        private Label lblAtributo10;
        private Label lblAtributo9;
        private Label lblAtributo8;
        private Label lblAtributo7;
        private Label lblAtributo6;
        private Label lblAtributo5;
        private Label lblPrecio;
        private Label lblMarca;
        private Label lblId;
        private PictureBox pbxImagen;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox comboAtribute10;
        private ComboBox comboAtribute9;
        private Button btnCargarImagen;
    }
}