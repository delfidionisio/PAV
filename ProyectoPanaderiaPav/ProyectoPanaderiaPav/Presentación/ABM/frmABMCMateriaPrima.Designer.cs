
namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmABMCMateriaPrima
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdMateriaPrima = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtIdMateriaPrima = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(119, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // lblIdMateriaPrima
            // 
            this.lblIdMateriaPrima.AutoSize = true;
            this.lblIdMateriaPrima.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMateriaPrima.Location = new System.Drawing.Point(83, 58);
            this.lblIdMateriaPrima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMateriaPrima.Name = "lblIdMateriaPrima";
            this.lblIdMateriaPrima.Size = new System.Drawing.Size(119, 18);
            this.lblIdMateriaPrima.TabIndex = 1;
            this.lblIdMateriaPrima.Text = "Id Materia Prima";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(153, 169);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 18);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(68, 226);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(131, 18);
            this.lblUnidadMedida.TabIndex = 3;
            this.lblUnidadMedida.Text = "Unidad Medida (*)";
            // 
            // txtIdMateriaPrima
            // 
            this.txtIdMateriaPrima.Enabled = false;
            this.txtIdMateriaPrima.Location = new System.Drawing.Point(233, 54);
            this.txtIdMateriaPrima.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMateriaPrima.Name = "txtIdMateriaPrima";
            this.txtIdMateriaPrima.Size = new System.Drawing.Size(196, 22);
            this.txtIdMateriaPrima.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(233, 165);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(196, 22);
            this.txtStock.TabIndex = 6;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(233, 223);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(196, 24);
            this.cmbUnidadMedida.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Image = global::ProyectoPanaderiaPav.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(168, 278);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 59);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Image = global::ProyectoPanaderiaPav.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(285, 278);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 59);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMCMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(583, 363);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdMateriaPrima);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblIdMateriaPrima);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmABMCMateriaPrima";
            this.Load += new System.EventHandler(this.frmABMCMateriaPrima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdMateriaPrima;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtIdMateriaPrima;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}