
namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmABMCNivel
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
            this.btnCancelarABMC = new System.Windows.Forms.Button();
            this.btnAceptarABMC = new System.Windows.Forms.Button();
            this.lblPuntosHasta = new System.Windows.Forms.Label();
            this.lblPuntosDesde = new System.Windows.Forms.Label();
            this.txtPuntosDesde = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreNivel = new System.Windows.Forms.Label();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.lblIdNivel = new System.Windows.Forms.Label();
            this.txtPuntosHasta = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarABMC
            // 
            this.btnCancelarABMC.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarABMC.Image = global::ProyectoPanaderiaPav.Properties.Resources.cancelar;
            this.btnCancelarABMC.Location = new System.Drawing.Point(140, 277);
            this.btnCancelarABMC.Name = "btnCancelarABMC";
            this.btnCancelarABMC.Size = new System.Drawing.Size(64, 48);
            this.btnCancelarABMC.TabIndex = 19;
            this.btnCancelarABMC.UseVisualStyleBackColor = false;
            this.btnCancelarABMC.Click += new System.EventHandler(this.btnCancelarABMC_Click);
            // 
            // btnAceptarABMC
            // 
            this.btnAceptarABMC.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarABMC.Image = global::ProyectoPanaderiaPav.Properties.Resources.aceptar;
            this.btnAceptarABMC.Location = new System.Drawing.Point(229, 277);
            this.btnAceptarABMC.Name = "btnAceptarABMC";
            this.btnAceptarABMC.Size = new System.Drawing.Size(64, 48);
            this.btnAceptarABMC.TabIndex = 18;
            this.btnAceptarABMC.UseVisualStyleBackColor = false;
            this.btnAceptarABMC.Click += new System.EventHandler(this.btnAceptarABMC_Click);
            // 
            // lblPuntosHasta
            // 
            this.lblPuntosHasta.AutoSize = true;
            this.lblPuntosHasta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosHasta.Location = new System.Drawing.Point(77, 184);
            this.lblPuntosHasta.Name = "lblPuntosHasta";
            this.lblPuntosHasta.Size = new System.Drawing.Size(86, 17);
            this.lblPuntosHasta.TabIndex = 16;
            this.lblPuntosHasta.Text = "PuntosHasta";
            // 
            // lblPuntosDesde
            // 
            this.lblPuntosDesde.AutoSize = true;
            this.lblPuntosDesde.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosDesde.Location = new System.Drawing.Point(76, 138);
            this.lblPuntosDesde.Name = "lblPuntosDesde";
            this.lblPuntosDesde.Size = new System.Drawing.Size(92, 17);
            this.lblPuntosDesde.TabIndex = 15;
            this.lblPuntosDesde.Text = "Puntos Desde";
            // 
            // txtPuntosDesde
            // 
            this.txtPuntosDesde.Location = new System.Drawing.Point(192, 135);
            this.txtPuntosDesde.Name = "txtPuntosDesde";
            this.txtPuntosDesde.Size = new System.Drawing.Size(148, 20);
            this.txtPuntosDesde.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(192, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // lblNombreNivel
            // 
            this.lblNombreNivel.AutoSize = true;
            this.lblNombreNivel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNivel.Location = new System.Drawing.Point(105, 86);
            this.lblNombreNivel.Name = "lblNombreNivel";
            this.lblNombreNivel.Size = new System.Drawing.Size(58, 17);
            this.lblNombreNivel.TabIndex = 12;
            this.lblNombreNivel.Text = "Nombre";
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(192, 38);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(148, 20);
            this.txtIdNivel.TabIndex = 11;
            this.txtIdNivel.UseSystemPasswordChar = true;
            // 
            // lblIdNivel
            // 
            this.lblIdNivel.AutoSize = true;
            this.lblIdNivel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNivel.Location = new System.Drawing.Point(110, 41);
            this.lblIdNivel.Name = "lblIdNivel";
            this.lblIdNivel.Size = new System.Drawing.Size(53, 17);
            this.lblIdNivel.TabIndex = 10;
            this.lblIdNivel.Text = "Id Nivel";
            // 
            // txtPuntosHasta
            // 
            this.txtPuntosHasta.Location = new System.Drawing.Point(192, 184);
            this.txtPuntosHasta.Name = "txtPuntosHasta";
            this.txtPuntosHasta.Size = new System.Drawing.Size(148, 20);
            this.txtPuntosHasta.TabIndex = 20;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(77, 225);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(87, 17);
            this.lblDescuento.TabIndex = 21;
            this.lblDescuento.Text = "% Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(192, 225);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(148, 20);
            this.txtDescuento.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPanaderiaPav.Properties.Resources.iconoGranPan;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmABMCNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtPuntosHasta);
            this.Controls.Add(this.btnCancelarABMC);
            this.Controls.Add(this.btnAceptarABMC);
            this.Controls.Add(this.lblPuntosHasta);
            this.Controls.Add(this.lblPuntosDesde);
            this.Controls.Add(this.txtPuntosDesde);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreNivel);
            this.Controls.Add(this.txtIdNivel);
            this.Controls.Add(this.lblIdNivel);
            this.Name = "frmABMCNivel";
            this.Load += new System.EventHandler(this.frmABMCNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarABMC;
        private System.Windows.Forms.Button btnAceptarABMC;
        private System.Windows.Forms.Label lblPuntosHasta;
        private System.Windows.Forms.Label lblPuntosDesde;
        private System.Windows.Forms.TextBox txtPuntosDesde;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreNivel;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Label lblIdNivel;
        private System.Windows.Forms.TextBox txtPuntosHasta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}