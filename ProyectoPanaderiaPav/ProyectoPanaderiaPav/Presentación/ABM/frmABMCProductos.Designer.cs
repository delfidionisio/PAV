namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmABMCProductos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.lblUnidadPrecio = new System.Windows.Forms.Label();
            this.cmbPrecioPor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Image = global::ProyectoPanaderiaPav.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(341, 415);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 59);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Image = global::ProyectoPanaderiaPav.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(233, 415);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 59);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(91, 49);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(104, 22);
            this.lblIdProducto.TabIndex = 11;
            this.lblIdProducto.Text = "Id producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(217, 46);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(268, 22);
            this.txtIdProducto.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 107);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(128, 164);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(68, 22);
            this.lblTipoProducto.TabIndex = 15;
            this.lblTipoProducto.Text = "Tipo (*)";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(114, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(81, 22);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio (*)";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(128, 337);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(65, 22);
            this.lblPuntos.TabIndex = 19;
            this.lblPuntos.Text = "Puntos";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(217, 164);
            this.cmbTipoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(268, 24);
            this.cmbTipoProducto.TabIndex = 20;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(217, 222);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(268, 22);
            this.txtPrecio.TabIndex = 21;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(217, 337);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(268, 22);
            this.txtPuntos.TabIndex = 22;
            this.txtPuntos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntos_KeyPress);
            // 
            // lblUnidadPrecio
            // 
            this.lblUnidadPrecio.AutoSize = true;
            this.lblUnidadPrecio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadPrecio.Location = new System.Drawing.Point(80, 277);
            this.lblUnidadPrecio.Name = "lblUnidadPrecio";
            this.lblUnidadPrecio.Size = new System.Drawing.Size(113, 22);
            this.lblUnidadPrecio.TabIndex = 23;
            this.lblUnidadPrecio.Text = "Precio por (*)";
            // 
            // cmbPrecioPor
            // 
            this.cmbPrecioPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrecioPor.FormattingEnabled = true;
            this.cmbPrecioPor.Items.AddRange(new object[] {
            "Kilo",
            "Unidad"});
            this.cmbPrecioPor.Location = new System.Drawing.Point(217, 277);
            this.cmbPrecioPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrecioPor.Name = "cmbPrecioPor";
            this.cmbPrecioPor.Size = new System.Drawing.Size(268, 24);
            this.cmbPrecioPor.TabIndex = 24;
            // 
            // frmABMCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(629, 511);
            this.Controls.Add(this.cmbPrecioPor);
            this.Controls.Add(this.lblUnidadPrecio);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmABMCProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo producto";
            this.Load += new System.EventHandler(this.frmABMCProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label lblUnidadPrecio;
        private System.Windows.Forms.ComboBox cmbPrecioPor;
    }
}