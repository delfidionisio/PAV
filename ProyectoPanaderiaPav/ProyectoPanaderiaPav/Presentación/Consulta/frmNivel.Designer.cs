
namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNivel));
            this.grbEmpleados = new System.Windows.Forms.GroupBox();
            this.cmbNombreNivel = new System.Windows.Forms.ComboBox();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.colIdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntosDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntosHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarNivel = new System.Windows.Forms.Button();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.btnNuevoNivel = new System.Windows.Forms.Button();
            this.grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEmpleados
            // 
            this.grbEmpleados.Controls.Add(this.cmbNombreNivel);
            this.grbEmpleados.Controls.Add(this.dgvNiveles);
            this.grbEmpleados.Controls.Add(this.btnConsultar);
            this.grbEmpleados.Controls.Add(this.checkTodos);
            this.grbEmpleados.Controls.Add(this.txtIdNivel);
            this.grbEmpleados.Controls.Add(this.pictureBox1);
            this.grbEmpleados.Controls.Add(this.lblId);
            this.grbEmpleados.Controls.Add(this.lblNombre);
            this.grbEmpleados.Location = new System.Drawing.Point(12, 12);
            this.grbEmpleados.Name = "grbEmpleados";
            this.grbEmpleados.Size = new System.Drawing.Size(580, 360);
            this.grbEmpleados.TabIndex = 22;
            this.grbEmpleados.TabStop = false;
            this.grbEmpleados.Text = "Filtros de busqueda";
            // 
            // cmbNombreNivel
            // 
            this.cmbNombreNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreNivel.FormattingEnabled = true;
            this.cmbNombreNivel.Location = new System.Drawing.Point(158, 46);
            this.cmbNombreNivel.Name = "cmbNombreNivel";
            this.cmbNombreNivel.Size = new System.Drawing.Size(149, 21);
            this.cmbNombreNivel.TabIndex = 22;
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.AllowUserToAddRows = false;
            this.dgvNiveles.AllowUserToDeleteRows = false;
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNivel,
            this.colNombre,
            this.colPuntosDesde,
            this.colPuntosHasta,
            this.colDescuento});
            this.dgvNiveles.Location = new System.Drawing.Point(18, 133);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.ReadOnly = true;
            this.dgvNiveles.RowHeadersWidth = 51;
            this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveles.Size = new System.Drawing.Size(540, 205);
            this.dgvNiveles.TabIndex = 21;
            // 
            // colIdNivel
            // 
            this.colIdNivel.HeaderText = "Id";
            this.colIdNivel.Name = "colIdNivel";
            this.colIdNivel.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPuntosDesde
            // 
            this.colPuntosDesde.HeaderText = "Puntos Desde";
            this.colPuntosDesde.Name = "colPuntosDesde";
            this.colPuntosDesde.ReadOnly = true;
            // 
            // colPuntosHasta
            // 
            this.colPuntosHasta.HeaderText = "Puntos Hasta";
            this.colPuntosHasta.Name = "colPuntosHasta";
            this.colPuntosHasta.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "% Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(363, 83);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 28);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTodos.Location = new System.Drawing.Point(393, 48);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(56, 17);
            this.checkTodos.TabIndex = 8;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(158, 87);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(149, 20);
            this.txtIdNivel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F);
            this.lblId.Location = new System.Drawing.Point(70, 91);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 16);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id Nivel";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F);
            this.lblNombre.Location = new System.Drawing.Point(70, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(499, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 49);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarNivel
            // 
            this.btnEliminarNivel.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarNivel.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarNivel.Image")));
            this.btnEliminarNivel.Location = new System.Drawing.Point(181, 396);
            this.btnEliminarNivel.Name = "btnEliminarNivel";
            this.btnEliminarNivel.Size = new System.Drawing.Size(69, 49);
            this.btnEliminarNivel.TabIndex = 24;
            this.btnEliminarNivel.UseVisualStyleBackColor = false;
            this.btnEliminarNivel.Click += new System.EventHandler(this.btnEliminarNivel_Click);
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarNivel.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNivel.Image")));
            this.btnEditarNivel.Location = new System.Drawing.Point(103, 396);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(63, 49);
            this.btnEditarNivel.TabIndex = 23;
            this.btnEditarNivel.UseVisualStyleBackColor = false;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // btnNuevoNivel
            // 
            this.btnNuevoNivel.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoNivel.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoNivel.Image")));
            this.btnNuevoNivel.Location = new System.Drawing.Point(15, 396);
            this.btnNuevoNivel.Name = "btnNuevoNivel";
            this.btnNuevoNivel.Size = new System.Drawing.Size(69, 49);
            this.btnNuevoNivel.TabIndex = 22;
            this.btnNuevoNivel.UseVisualStyleBackColor = false;
            this.btnNuevoNivel.Click += new System.EventHandler(this.btnNuevoNivel_Click);
            // 
            // frmNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(617, 464);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbEmpleados);
            this.Controls.Add(this.btnEliminarNivel);
            this.Controls.Add(this.btnEditarNivel);
            this.Controls.Add(this.btnNuevoNivel);
            this.Name = "frmNivel";
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.frmNivel_Load);
            this.grbEmpleados.ResumeLayout(false);
            this.grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEmpleados;
        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntosDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntosHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarNivel;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.Button btnNuevoNivel;
        private System.Windows.Forms.ComboBox cmbNombreNivel;
    }
}