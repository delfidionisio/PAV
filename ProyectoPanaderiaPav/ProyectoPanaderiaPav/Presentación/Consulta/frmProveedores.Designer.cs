namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.grbProveedores = new System.Windows.Forms.GroupBox();
            this.cmbMateriaPrima = new System.Windows.Forms.ComboBox();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.colIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMateriaPrima = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.grbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProveedores
            // 
            this.grbProveedores.Controls.Add(this.cmbMateriaPrima);
            this.grbProveedores.Controls.Add(this.checkTodos);
            this.grbProveedores.Controls.Add(this.dgvProveedores);
            this.grbProveedores.Controls.Add(this.btnConsultar);
            this.grbProveedores.Controls.Add(this.lblMateriaPrima);
            this.grbProveedores.Controls.Add(this.txtNombre);
            this.grbProveedores.Controls.Add(this.lblNombre);
            this.grbProveedores.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProveedores.Location = new System.Drawing.Point(25, 28);
            this.grbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.grbProveedores.Name = "grbProveedores";
            this.grbProveedores.Padding = new System.Windows.Forms.Padding(4);
            this.grbProveedores.Size = new System.Drawing.Size(881, 547);
            this.grbProveedores.TabIndex = 1;
            this.grbProveedores.TabStop = false;
            this.grbProveedores.Text = "Filtros de Búsqueda";
            // 
            // cmbMateriaPrima
            // 
            this.cmbMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaPrima.FormattingEnabled = true;
            this.cmbMateriaPrima.Location = new System.Drawing.Point(160, 91);
            this.cmbMateriaPrima.Name = "cmbMateriaPrima";
            this.cmbMateriaPrima.Size = new System.Drawing.Size(260, 26);
            this.cmbMateriaPrima.TabIndex = 15;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTodos.Location = new System.Drawing.Point(643, 135);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(71, 22);
            this.checkTodos.TabIndex = 14;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProveedor,
            this.colNombreProveedor,
            this.colMateriaPrima,
            this.colMail,
            this.colTelefono});
            this.dgvProveedores.Location = new System.Drawing.Point(25, 170);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(829, 353);
            this.dgvProveedores.TabIndex = 8;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.HeaderText = "Id ";
            this.colIdProveedor.MinimumWidth = 6;
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.ReadOnly = true;
            this.colIdProveedor.Width = 50;
            // 
            // colNombreProveedor
            // 
            this.colNombreProveedor.HeaderText = "Nombre";
            this.colNombreProveedor.MinimumWidth = 6;
            this.colNombreProveedor.Name = "colNombreProveedor";
            this.colNombreProveedor.ReadOnly = true;
            this.colNombreProveedor.Width = 160;
            // 
            // colMateriaPrima
            // 
            this.colMateriaPrima.HeaderText = "Materia Prima";
            this.colMateriaPrima.MinimumWidth = 6;
            this.colMateriaPrima.Name = "colMateriaPrima";
            this.colMateriaPrima.ReadOnly = true;
            this.colMateriaPrima.Width = 180;
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.MinimumWidth = 6;
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            this.colMail.Width = 200;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(739, 128);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 34);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMateriaPrima
            // 
            this.lblMateriaPrima.AutoSize = true;
            this.lblMateriaPrima.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrima.Location = new System.Drawing.Point(39, 98);
            this.lblMateriaPrima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriaPrima.Name = "lblMateriaPrima";
            this.lblMateriaPrima.Size = new System.Drawing.Size(103, 18);
            this.lblMateriaPrima.TabIndex = 2;
            this.lblMateriaPrima.Text = "Materia prima";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(79, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(821, 583);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 59);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProveedor.Image")));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(264, 583);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(85, 59);
            this.btnEliminarProveedor.TabIndex = 7;
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProveedor.Image")));
            this.btnEditarProveedor.Location = new System.Drawing.Point(148, 583);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(79, 59);
            this.btnEditarProveedor.TabIndex = 6;
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProveedor.Image")));
            this.btnNuevoProveedor.Location = new System.Drawing.Point(27, 583);
            this.btnNuevoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(85, 59);
            this.btnNuevoProveedor.TabIndex = 5;
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(932, 652);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.grbProveedores);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.grbProveedores.ResumeLayout(false);
            this.grbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProveedores;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblMateriaPrima;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbMateriaPrima;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
    }
}