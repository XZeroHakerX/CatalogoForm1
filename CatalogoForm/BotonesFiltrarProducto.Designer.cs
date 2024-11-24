namespace CatalogoForm
{
    partial class BotonesFiltrarProducto
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
            gbxFiltrado = new GroupBox();
            radioButton6 = new RadioButton();
            rbtnPrecioMayor = new RadioButton();
            rbtnPrecioIgual = new RadioButton();
            rbtnFiltrarMarca = new RadioButton();
            rbtnFiltrarIdProducto = new RadioButton();
            rbtnFiltrarTipo = new RadioButton();
            txtIdProducto = new TextBox();
            txtMarca = new TextBox();
            txtPrecioIgual = new TextBox();
            txtPrecioMayor = new TextBox();
            txtPrecioMenor = new TextBox();
            btnFiltrar = new Button();
            comboBox1 = new ComboBox();
            gbxFiltrado.SuspendLayout();
            SuspendLayout();
            // 
            // gbxFiltrado
            // 
            gbxFiltrado.Controls.Add(radioButton6);
            gbxFiltrado.Controls.Add(rbtnPrecioMayor);
            gbxFiltrado.Controls.Add(rbtnPrecioIgual);
            gbxFiltrado.Controls.Add(rbtnFiltrarMarca);
            gbxFiltrado.Controls.Add(rbtnFiltrarIdProducto);
            gbxFiltrado.Controls.Add(rbtnFiltrarTipo);
            gbxFiltrado.Location = new Point(12, 56);
            gbxFiltrado.Name = "gbxFiltrado";
            gbxFiltrado.Size = new Size(338, 474);
            gbxFiltrado.TabIndex = 0;
            gbxFiltrado.TabStop = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Cursor = Cursors.Hand;
            radioButton6.FlatStyle = FlatStyle.Popup;
            radioButton6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            radioButton6.Location = new Point(21, 389);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(246, 36);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Por Precio MENOR:";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // rbtnPrecioMayor
            // 
            rbtnPrecioMayor.AutoSize = true;
            rbtnPrecioMayor.Cursor = Cursors.Hand;
            rbtnPrecioMayor.FlatStyle = FlatStyle.Popup;
            rbtnPrecioMayor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            rbtnPrecioMayor.Location = new Point(21, 310);
            rbtnPrecioMayor.Name = "rbtnPrecioMayor";
            rbtnPrecioMayor.Size = new Size(245, 36);
            rbtnPrecioMayor.TabIndex = 4;
            rbtnPrecioMayor.TabStop = true;
            rbtnPrecioMayor.Text = "Por Precio MAYOR:";
            rbtnPrecioMayor.UseVisualStyleBackColor = true;
            rbtnPrecioMayor.CheckedChanged += rbtnPrecioMayor_CheckedChanged;
            // 
            // rbtnPrecioIgual
            // 
            rbtnPrecioIgual.AutoSize = true;
            rbtnPrecioIgual.Cursor = Cursors.Hand;
            rbtnPrecioIgual.FlatStyle = FlatStyle.Popup;
            rbtnPrecioIgual.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            rbtnPrecioIgual.Location = new Point(21, 230);
            rbtnPrecioIgual.Name = "rbtnPrecioIgual";
            rbtnPrecioIgual.Size = new Size(230, 36);
            rbtnPrecioIgual.TabIndex = 3;
            rbtnPrecioIgual.TabStop = true;
            rbtnPrecioIgual.Text = "Por Precio IGUAL:";
            rbtnPrecioIgual.UseVisualStyleBackColor = true;
            rbtnPrecioIgual.CheckedChanged += rbtnPrecioIgual_CheckedChanged;
            // 
            // rbtnFiltrarMarca
            // 
            rbtnFiltrarMarca.AutoSize = true;
            rbtnFiltrarMarca.Cursor = Cursors.Hand;
            rbtnFiltrarMarca.FlatStyle = FlatStyle.Popup;
            rbtnFiltrarMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            rbtnFiltrarMarca.Location = new Point(21, 156);
            rbtnFiltrarMarca.Name = "rbtnFiltrarMarca";
            rbtnFiltrarMarca.Size = new Size(242, 36);
            rbtnFiltrarMarca.TabIndex = 2;
            rbtnFiltrarMarca.TabStop = true;
            rbtnFiltrarMarca.Text = "Filtrar por MARCA:";
            rbtnFiltrarMarca.UseVisualStyleBackColor = true;
            rbtnFiltrarMarca.CheckedChanged += rbtnFiltrarMarca_CheckedChanged;
            // 
            // rbtnFiltrarIdProducto
            // 
            rbtnFiltrarIdProducto.AutoSize = true;
            rbtnFiltrarIdProducto.Cursor = Cursors.Hand;
            rbtnFiltrarIdProducto.FlatStyle = FlatStyle.Popup;
            rbtnFiltrarIdProducto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            rbtnFiltrarIdProducto.Location = new Point(21, 87);
            rbtnFiltrarIdProducto.Name = "rbtnFiltrarIdProducto";
            rbtnFiltrarIdProducto.Size = new Size(309, 36);
            rbtnFiltrarIdProducto.TabIndex = 1;
            rbtnFiltrarIdProducto.TabStop = true;
            rbtnFiltrarIdProducto.Text = "Filtrar por IDPRODUCTO:";
            rbtnFiltrarIdProducto.UseVisualStyleBackColor = true;
            rbtnFiltrarIdProducto.CheckedChanged += rbtnFiltrarIdProducto_CheckedChanged;
            // 
            // rbtnFiltrarTipo
            // 
            rbtnFiltrarTipo.AllowDrop = true;
            rbtnFiltrarTipo.AutoSize = true;
            rbtnFiltrarTipo.Cursor = Cursors.Hand;
            rbtnFiltrarTipo.FlatStyle = FlatStyle.Popup;
            rbtnFiltrarTipo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            rbtnFiltrarTipo.Location = new Point(21, 20);
            rbtnFiltrarTipo.Name = "rbtnFiltrarTipo";
            rbtnFiltrarTipo.Size = new Size(210, 36);
            rbtnFiltrarTipo.TabIndex = 0;
            rbtnFiltrarTipo.TabStop = true;
            rbtnFiltrarTipo.Text = "Filtrar por TIPO:";
            rbtnFiltrarTipo.UseVisualStyleBackColor = true;
            rbtnFiltrarTipo.CheckedChanged += rbtnFiltrarTipo_CheckedChanged;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Cursor = Cursors.IBeam;
            txtIdProducto.Enabled = false;
            txtIdProducto.Font = new Font("Segoe UI", 12F);
            txtIdProducto.Location = new Point(356, 153);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(300, 39);
            txtIdProducto.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Enabled = false;
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.Location = new Point(356, 222);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(300, 39);
            txtMarca.TabIndex = 3;
            // 
            // txtPrecioIgual
            // 
            txtPrecioIgual.Cursor = Cursors.IBeam;
            txtPrecioIgual.Enabled = false;
            txtPrecioIgual.Font = new Font("Segoe UI", 12F);
            txtPrecioIgual.Location = new Point(356, 296);
            txtPrecioIgual.Name = "txtPrecioIgual";
            txtPrecioIgual.Size = new Size(300, 39);
            txtPrecioIgual.TabIndex = 4;
            // 
            // txtPrecioMayor
            // 
            txtPrecioMayor.Cursor = Cursors.IBeam;
            txtPrecioMayor.Enabled = false;
            txtPrecioMayor.Font = new Font("Segoe UI", 12F);
            txtPrecioMayor.Location = new Point(356, 376);
            txtPrecioMayor.Name = "txtPrecioMayor";
            txtPrecioMayor.Size = new Size(300, 39);
            txtPrecioMayor.TabIndex = 5;
            // 
            // txtPrecioMenor
            // 
            txtPrecioMenor.Cursor = Cursors.IBeam;
            txtPrecioMenor.Enabled = false;
            txtPrecioMenor.Font = new Font("Segoe UI", 12F);
            txtPrecioMenor.Location = new Point(356, 455);
            txtPrecioMenor.Name = "txtPrecioMenor";
            txtPrecioMenor.Size = new Size(300, 39);
            txtPrecioMenor.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LightGreen;
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Yu Gothic UI", 14F);
            btnFiltrar.Location = new Point(237, 553);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(190, 64);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Enabled = false;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Raton", "Teclado", "Pantalla", "Altavoz" });
            comboBox1.Location = new Point(356, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 40);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Elige. . .";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BotonesFiltrarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(668, 661);
            Controls.Add(comboBox1);
            Controls.Add(btnFiltrar);
            Controls.Add(txtPrecioMenor);
            Controls.Add(txtPrecioMayor);
            Controls.Add(txtPrecioIgual);
            Controls.Add(txtMarca);
            Controls.Add(txtIdProducto);
            Controls.Add(gbxFiltrado);
            Name = "BotonesFiltrarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BotonesFiltrarProducto";
            gbxFiltrado.ResumeLayout(false);
            gbxFiltrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxFiltrado;
        private RadioButton radioButton6;
        private RadioButton rbtnPrecioMayor;
        private RadioButton rbtnPrecioIgual;
        private RadioButton rbtnFiltrarMarca;
        private RadioButton rbtnFiltrarIdProducto;
        private TextBox txtIdProducto;
        private TextBox txtMarca;
        private TextBox txtPrecioIgual;
        private TextBox txtPrecioMayor;
        private TextBox txtPrecioMenor;
        private RadioButton rbtnFiltrarTipo;
        private Button btnFiltrar;
        private ComboBox comboBox1;
    }
}