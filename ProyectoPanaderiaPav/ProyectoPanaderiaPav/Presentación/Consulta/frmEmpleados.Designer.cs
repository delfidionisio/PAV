
namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEmpleados = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumentoEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.colIdEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(940, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // grbEmpleados
            // 
            this.grbEmpleados.Controls.Add(this.dgvEmpleados);
            this.grbEmpleados.Controls.Add(this.btnConsultar);
            this.grbEmpleados.Controls.Add(this.checkTodos);
            this.grbEmpleados.Controls.Add(this.txtNumeroDocumento);
            this.grbEmpleados.Controls.Add(this.lblDocumentoEmpleado);
            this.grbEmpleados.Controls.Add(this.txtApellidoEmpleado);
            this.grbEmpleados.Controls.Add(this.pictureBox1);
            this.grbEmpleados.Controls.Add(this.lblApellidoEmpleado);
            this.grbEmpleados.Controls.Add(this.lblNombreEmpleado);
            this.grbEmpleados.Controls.Add(this.txtNombreEmpleado);
            this.grbEmpleados.Location = new System.Drawing.Point(41, 6);
            this.grbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmpleados.Name = "grbEmpleados";
            this.grbEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmpleados.Size = new System.Drawing.Size(1048, 636);
            this.grbEmpleados.TabIndex = 21;
            this.grbEmpleados.TabStop = false;
            this.grbEmpleados.Text = "Filtros de busqueda";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEmpleados,
            this.colNombre,
            this.colApellido,
            this.colMail,
            this.colTipoDocumento,
            this.colNroDocumento,
            this.colIdUsuario,
            this.colPerfil});
            this.dgvEmpleados.Location = new System.Drawing.Point(24, 170);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(992, 443);
            this.dgvEmpleados.TabIndex = 21;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(901, 116);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 34);
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
            this.checkTodos.Location = new System.Drawing.Point(796, 124);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(69, 20);
            this.checkTodos.TabIndex = 8;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(625, 53);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(197, 22);
            this.txtNumeroDocumento.TabIndex = 7;
            // 
            // lblDocumentoEmpleado
            // 
            this.lblDocumentoEmpleado.AutoSize = true;
            this.lblDocumentoEmpleado.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F);
            this.lblDocumentoEmpleado.Location = new System.Drawing.Point(451, 59);
            this.lblDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentoEmpleado.Name = "lblDocumentoEmpleado";
            this.lblDocumentoEmpleado.Size = new System.Drawing.Size(152, 19);
            this.lblDocumentoEmpleado.TabIndex = 6;
            this.lblDocumentoEmpleado.Text = "Número Documento";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(199, 97);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(197, 22);
            this.txtApellidoEmpleado.TabIndex = 5;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F);
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(20, 102);
            this.lblApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(141, 19);
            this.lblApellidoEmpleado.TabIndex = 4;
            this.lblApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F);
            this.lblNombreEmpleado.Location = new System.Drawing.Point(20, 58);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(141, 19);
            this.lblNombreEmpleado.TabIndex = 3;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(199, 54);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(197, 22);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleado.Image")));
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(41, 650);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(85, 59);
            this.btnNuevoEmpleado.TabIndex = 22;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEmpleado.Image")));
            this.btnEditarEmpleado.Location = new System.Drawing.Point(153, 650);
            this.btnEditarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(79, 59);
            this.btnEditarEmpleado.TabIndex = 23;
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Image")));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(256, 650);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(85, 59);
            this.btnEliminarEmpleado.TabIndex = 24;
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1004, 650);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 59);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // colIdEmpleados
            // 
            this.colIdEmpleados.HeaderText = "Id Empleado";
            this.colIdEmpleados.MinimumWidth = 6;
            this.colIdEmpleados.Name = "colIdEmpleados";
            this.colIdEmpleados.ReadOnly = true;
            this.colIdEmpleados.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 125;
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.MinimumWidth = 6;
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            this.colMail.Width = 140;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.HeaderText = "Tipo Documento";
            this.colTipoDocumento.MinimumWidth = 6;
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.ReadOnly = true;
            this.colTipoDocumento.Width = 80;
            // 
            // colNroDocumento
            // 
            this.colNroDocumento.HeaderText = "Número Documento";
            this.colNroDocumento.MinimumWidth = 6;
            this.colNroDocumento.Name = "colNroDocumento";
            this.colNroDocumento.ReadOnly = true;
            this.colNroDocumento.Width = 80;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.HeaderText = "Usuario";
            this.colIdUsuario.MinimumWidth = 6;
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.ReadOnly = true;
            this.colIdUsuario.Width = 125;
            // 
            // colPerfil
            // 
            this.colPerfil.HeaderText = "Perfil";
            this.colPerfil.MinimumWidth = 6;
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.ReadOnly = true;
            this.colPerfil.Width = 140;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1151, 722);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.grbEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbEmpleados.ResumeLayout(false);
            this.grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblDocumentoEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
    }
}