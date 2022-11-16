namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmABMCProveedor
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMateriaPrima = new System.Windows.Forms.Label();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbMateriaPrima = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Image = global::ProyectoPanaderiaPav.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(275, 331);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 59);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Image = global::ProyectoPanaderiaPav.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(158, 331);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 59);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(223, 220);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 22);
            this.txtMail.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 109);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Location = new System.Drawing.Point(223, 56);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(196, 22);
            this.txtIdProveedor.TabIndex = 17;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(134, 222);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(56, 18);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "Mail (*)";
            // 
            // lblMateriaPrima
            // 
            this.lblMateriaPrima.AutoSize = true;
            this.lblMateriaPrima.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrima.Location = new System.Drawing.Point(69, 167);
            this.lblMateriaPrima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriaPrima.Name = "lblMateriaPrima";
            this.lblMateriaPrima.Size = new System.Drawing.Size(121, 18);
            this.lblMateriaPrima.TabIndex = 15;
            this.lblMateriaPrima.Text = "Materia prima (*)";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(96, 56);
            this.lblIdProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(94, 18);
            this.lblIdProveedor.TabIndex = 14;
            this.lblIdProveedor.Text = "Id proveedor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(109, 115);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 18);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // cmbMateriaPrima
            // 
            this.cmbMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaPrima.FormattingEnabled = true;
            this.cmbMateriaPrima.Location = new System.Drawing.Point(223, 167);
            this.cmbMateriaPrima.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMateriaPrima.Name = "cmbMateriaPrima";
            this.cmbMateriaPrima.Size = new System.Drawing.Size(196, 24);
            this.cmbMateriaPrima.TabIndex = 23;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(223, 274);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 22);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(104, 276);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 18);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono (*)";
            // 
            // frmABMCProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(531, 424);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cmbMateriaPrima);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblMateriaPrima);
            this.Controls.Add(this.lblIdProveedor);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmABMCProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo proveedor";
            this.Load += new System.EventHandler(this.frmABMCProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMateriaPrima;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbMateriaPrima;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
    }
}