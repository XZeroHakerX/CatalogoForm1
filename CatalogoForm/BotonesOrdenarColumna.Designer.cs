namespace CatalogoForm
{
    partial class BotonesOrdenarColumna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonesOrdenarColumna));
            pnlBotonesAgregar = new Panel();
            btnOrdenarPrecio = new Button();
            btnOrdenarMarca = new Button();
            btnOrdenarIdproducto = new Button();
            btnOrdenarTipo = new Button();
            pnlBotonesAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonesAgregar
            // 
            pnlBotonesAgregar.BackColor = Color.Transparent;
            pnlBotonesAgregar.Controls.Add(btnOrdenarPrecio);
            pnlBotonesAgregar.Controls.Add(btnOrdenarMarca);
            pnlBotonesAgregar.Controls.Add(btnOrdenarIdproducto);
            pnlBotonesAgregar.Controls.Add(btnOrdenarTipo);
            pnlBotonesAgregar.Location = new Point(10, 30);
            pnlBotonesAgregar.Name = "pnlBotonesAgregar";
            pnlBotonesAgregar.Size = new Size(625, 130);
            pnlBotonesAgregar.TabIndex = 7;
            // 
            // btnOrdenarPrecio
            // 
            btnOrdenarPrecio.BackColor = Color.PowderBlue;
            btnOrdenarPrecio.Cursor = Cursors.Hand;
            btnOrdenarPrecio.FlatStyle = FlatStyle.Popup;
            btnOrdenarPrecio.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarPrecio.Location = new Point(328, 72);
            btnOrdenarPrecio.Margin = new Padding(10, 10, 10, 10);
            btnOrdenarPrecio.Name = "btnOrdenarPrecio";
            btnOrdenarPrecio.Size = new Size(282, 49);
            btnOrdenarPrecio.TabIndex = 3;
            btnOrdenarPrecio.Text = "Por PRECIO";
            btnOrdenarPrecio.UseVisualStyleBackColor = false;
            btnOrdenarPrecio.Click += btnOrdenarPrecio_Click;
            // 
            // btnOrdenarMarca
            // 
            btnOrdenarMarca.BackColor = Color.PowderBlue;
            btnOrdenarMarca.Cursor = Cursors.Hand;
            btnOrdenarMarca.FlatStyle = FlatStyle.Popup;
            btnOrdenarMarca.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarMarca.Location = new Point(328, 3);
            btnOrdenarMarca.Margin = new Padding(10, 10, 10, 10);
            btnOrdenarMarca.Name = "btnOrdenarMarca";
            btnOrdenarMarca.Size = new Size(282, 49);
            btnOrdenarMarca.TabIndex = 2;
            btnOrdenarMarca.Text = "Por MARCA";
            btnOrdenarMarca.UseVisualStyleBackColor = false;
            btnOrdenarMarca.Click += btnOrdenarMarca_Click;
            // 
            // btnOrdenarIdproducto
            // 
            btnOrdenarIdproducto.BackColor = Color.PowderBlue;
            btnOrdenarIdproducto.Cursor = Cursors.Hand;
            btnOrdenarIdproducto.FlatStyle = FlatStyle.Popup;
            btnOrdenarIdproducto.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarIdproducto.Location = new Point(27, 72);
            btnOrdenarIdproducto.Margin = new Padding(10, 10, 10, 10);
            btnOrdenarIdproducto.Name = "btnOrdenarIdproducto";
            btnOrdenarIdproducto.Size = new Size(282, 49);
            btnOrdenarIdproducto.TabIndex = 1;
            btnOrdenarIdproducto.Text = "Por IDPRODUCTO";
            btnOrdenarIdproducto.UseVisualStyleBackColor = false;
            btnOrdenarIdproducto.Click += btnOrdenarIdproducto_Click;
            // 
            // btnOrdenarTipo
            // 
            btnOrdenarTipo.BackColor = Color.PowderBlue;
            btnOrdenarTipo.Cursor = Cursors.Hand;
            btnOrdenarTipo.FlatStyle = FlatStyle.Popup;
            btnOrdenarTipo.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarTipo.Location = new Point(27, 3);
            btnOrdenarTipo.Margin = new Padding(10, 10, 10, 10);
            btnOrdenarTipo.Name = "btnOrdenarTipo";
            btnOrdenarTipo.Size = new Size(282, 49);
            btnOrdenarTipo.TabIndex = 0;
            btnOrdenarTipo.Text = "Por TIPO";
            btnOrdenarTipo.UseVisualStyleBackColor = false;
            btnOrdenarTipo.Click += btnOrdenarTipo_Click;
            // 
            // BotonesOrdenarColumna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(661, 182);
            Controls.Add(pnlBotonesAgregar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "BotonesOrdenarColumna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordenar Productos";
            pnlBotonesAgregar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonesAgregar;
        private Button btnOrdenarPrecio;
        private Button btnOrdenarMarca;
        private Button btnOrdenarIdproducto;
        private Button btnOrdenarTipo;
    }
}