namespace CatalogoForm
{
    partial class MenuBorrar
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
            clstBorrar = new CheckedListBox();
            bntBorrar = new Button();
            btnCancelar = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            SuspendLayout();
            // 
            // clstBorrar
            // 
            clstBorrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clstBorrar.BackColor = SystemColors.Info;
            clstBorrar.CheckOnClick = true;
            clstBorrar.Font = new Font("Segoe UI", 14F);
            clstBorrar.FormattingEnabled = true;
            clstBorrar.HorizontalScrollbar = true;
            clstBorrar.Location = new Point(35, 22);
            clstBorrar.Margin = new Padding(2);
            clstBorrar.Name = "clstBorrar";
            clstBorrar.ScrollAlwaysVisible = true;
            clstBorrar.Size = new Size(1004, 582);
            clstBorrar.TabIndex = 0;
            // 
            // bntBorrar
            // 
            bntBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntBorrar.BackColor = Color.Red;
            bntBorrar.Cursor = Cursors.No;
            bntBorrar.FlatStyle = FlatStyle.Popup;
            bntBorrar.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBorrar.Location = new Point(98, 685);
            bntBorrar.Name = "bntBorrar";
            bntBorrar.Size = new Size(167, 63);
            bntBorrar.TabIndex = 4;
            bntBorrar.Text = "BORRAR";
            bntBorrar.UseVisualStyleBackColor = false;
            bntBorrar.Click += bntBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Azure;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 14F);
            btnCancelar.Location = new Point(842, 714);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 34);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMas
            // 
            btnMas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMas.BackColor = Color.Azure;
            btnMas.Cursor = Cursors.Hand;
            btnMas.FlatStyle = FlatStyle.Popup;
            btnMas.Font = new Font("Segoe UI", 12F);
            btnMas.Location = new Point(317, 685);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(203, 63);
            btnMas.TabIndex = 27;
            btnMas.Text = "MAS DETALLES";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenos.BackColor = Color.Azure;
            btnMenos.Cursor = Cursors.Hand;
            btnMenos.FlatStyle = FlatStyle.Popup;
            btnMenos.Font = new Font("Segoe UI", 12F);
            btnMenos.Location = new Point(526, 685);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(203, 63);
            btnMenos.TabIndex = 28;
            btnMenos.Text = "MENOS DETALLES";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Visible = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // MenuBorrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1081, 769);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btnCancelar);
            Controls.Add(bntBorrar);
            Controls.Add(clstBorrar);
            Margin = new Padding(2);
            Name = "MenuBorrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrar Articulo/s";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox clstBorrar;
        private Button bntBorrar;
        private Button btnCancelar;
        private Button btnMas;
        private Button btnMenos;
    }
}