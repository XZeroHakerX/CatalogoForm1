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
            pnlBotonesAgregar.Location = new Point(13, 37);
            pnlBotonesAgregar.Margin = new Padding(4);
            pnlBotonesAgregar.Name = "pnlBotonesAgregar";
            pnlBotonesAgregar.Size = new Size(781, 163);
            pnlBotonesAgregar.TabIndex = 7;
            // 
            // btnOrdenarPrecio
            // 
            btnOrdenarPrecio.BackColor = Color.SteelBlue;
            btnOrdenarPrecio.FlatStyle = FlatStyle.Popup;
            btnOrdenarPrecio.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarPrecio.Location = new Point(410, 90);
            btnOrdenarPrecio.Margin = new Padding(12);
            btnOrdenarPrecio.Name = "btnOrdenarPrecio";
            btnOrdenarPrecio.Size = new Size(352, 61);
            btnOrdenarPrecio.TabIndex = 3;
            btnOrdenarPrecio.Text = "Por PRECIO";
            btnOrdenarPrecio.UseVisualStyleBackColor = false;
            btnOrdenarPrecio.Click += btnOrdenarPrecio_Click;
            // 
            // btnOrdenarMarca
            // 
            btnOrdenarMarca.BackColor = Color.SteelBlue;
            btnOrdenarMarca.FlatStyle = FlatStyle.Popup;
            btnOrdenarMarca.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarMarca.Location = new Point(410, 4);
            btnOrdenarMarca.Margin = new Padding(12);
            btnOrdenarMarca.Name = "btnOrdenarMarca";
            btnOrdenarMarca.Size = new Size(352, 61);
            btnOrdenarMarca.TabIndex = 2;
            btnOrdenarMarca.Text = "Por MARCA";
            btnOrdenarMarca.UseVisualStyleBackColor = false;
            btnOrdenarMarca.Click += btnOrdenarMarca_Click;
            // 
            // btnOrdenarIdproducto
            // 
            btnOrdenarIdproducto.BackColor = Color.SteelBlue;
            btnOrdenarIdproducto.FlatStyle = FlatStyle.Popup;
            btnOrdenarIdproducto.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarIdproducto.Location = new Point(34, 90);
            btnOrdenarIdproducto.Margin = new Padding(12);
            btnOrdenarIdproducto.Name = "btnOrdenarIdproducto";
            btnOrdenarIdproducto.Size = new Size(352, 61);
            btnOrdenarIdproducto.TabIndex = 1;
            btnOrdenarIdproducto.Text = "Por IDPRODUCTO";
            btnOrdenarIdproducto.UseVisualStyleBackColor = false;
            btnOrdenarIdproducto.Click += btnOrdenarIdproducto_Click;
            // 
            // btnOrdenarTipo
            // 
            btnOrdenarTipo.BackColor = Color.SteelBlue;
            btnOrdenarTipo.FlatStyle = FlatStyle.Popup;
            btnOrdenarTipo.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold);
            btnOrdenarTipo.Location = new Point(34, 4);
            btnOrdenarTipo.Margin = new Padding(12);
            btnOrdenarTipo.Name = "btnOrdenarTipo";
            btnOrdenarTipo.Size = new Size(352, 61);
            btnOrdenarTipo.TabIndex = 0;
            btnOrdenarTipo.Text = "Por TIPO";
            btnOrdenarTipo.UseVisualStyleBackColor = false;
            btnOrdenarTipo.Click += btnOrdenarTipo_Click;
            // 
            // BotonesOrdenarColumna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 227);
            Controls.Add(pnlBotonesAgregar);
            Name = "BotonesOrdenarColumna";
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