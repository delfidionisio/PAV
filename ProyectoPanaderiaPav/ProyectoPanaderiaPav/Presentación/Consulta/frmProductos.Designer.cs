namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblValorPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.trbPrecio = new System.Windows.Forms.TrackBar();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbPuntos = new System.Windows.Forms.ComboBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.cmbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProductos
            // 
            this.grbProductos.Controls.Add(this.pictureBox1);
            this.grbProductos.Controls.Add(this.lblPeso);
            this.grbProductos.Controls.Add(this.lblValorPrecio);
            this.grbProductos.Controls.Add(this.lblPrecio);
            this.grbProductos.Controls.Add(this.trbPrecio);
            this.grbProductos.Controls.Add(this.checkTodos);
            this.grbProductos.Controls.Add(this.dgvProductos);
            this.grbProductos.Controls.Add(this.btnConsultar);
            this.grbProductos.Controls.Add(this.cmbPuntos);
            this.grbProductos.Controls.Add(this.lblPuntos);
            this.grbProductos.Controls.Add(this.cmbOrdenarPor);
            this.grbProductos.Controls.Add(this.lblOrdenarPor);
            this.grbProductos.Controls.Add(this.cmbTipoProducto);
            this.grbProductos.Controls.Add(this.lblTipoProducto);
            this.grbProductos.Controls.Add(this.txtNombreProducto);
            this.grbProductos.Controls.Add(this.lblNombreProducto);
            this.grbProductos.Font = new System.Drawing.Font("Microsoft JhengHei", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProductos.Location = new System.Drawing.Point(17, 20);
            this.grbProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbProductos.Size = new System.Drawing.Size(810, 587);
            this.grbProductos.TabIndex = 0;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Filtros búsqueda";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(338, 139);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(14, 16);
            this.lblPeso.TabIndex = 17;
            this.lblPeso.Text = "$";
            // 
            // lblValorPrecio
            // 
            this.lblValorPrecio.AutoSize = true;
            this.lblValorPrecio.Location = new System.Drawing.Point(351, 139);
            this.lblValorPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPrecio.Name = "lblValorPrecio";
            this.lblValorPrecio.Size = new System.Drawing.Size(14, 16);
            this.lblValorPrecio.TabIndex = 16;
            this.lblValorPrecio.Text = "0";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(55, 112);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 16);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio hasta";
            // 
            // trbPrecio
            // 
            this.trbPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.trbPrecio.Location = new System.Drawing.Point(136, 112);
            this.trbPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trbPrecio.Maximum = 3500;
            this.trbPrecio.Name = "trbPrecio";
            this.trbPrecio.Size = new System.Drawing.Size(189, 45);
            this.trbPrecio.TabIndex = 3;
            this.trbPrecio.TickFrequency = 500;
            this.trbPrecio.Scroll += new System.EventHandler(this.trbPrecio_Scroll);
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTodos.Location = new System.Drawing.Point(606, 140);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(62, 20);
            this.checkTodos.TabIndex = 13;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colNombreProducto,
            this.colTipoProducto,
            this.colPrecio,
            this.colTipoPrecio,
            this.colPuntos});
            this.dgvProductos.Location = new System.Drawing.Point(26, 179);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(756, 384);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.MinimumWidth = 6;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Width = 50;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.HeaderText = "Nombre";
            this.colNombreProducto.MinimumWidth = 6;
            this.colNombreProducto.Name = "colNombreProducto";
            this.colNombreProducto.ReadOnly = true;
            this.colNombreProducto.Width = 200;
            // 
            // colTipoProducto
            // 
            this.colTipoProducto.HeaderText = "Tipo producto";
            this.colTipoProducto.MinimumWidth = 6;
            this.colTipoProducto.Name = "colTipoProducto";
            this.colTipoProducto.ReadOnly = true;
            this.colTipoProducto.Width = 175;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio en $";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colTipoPrecio
            // 
            this.colTipoPrecio.HeaderText = "Precio por";
            this.colTipoPrecio.MinimumWidth = 6;
            this.colTipoPrecio.Name = "colTipoPrecio";
            this.colTipoPrecio.ReadOnly = true;
            this.colTipoPrecio.Width = 90;
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "Puntos";
            this.colPuntos.MinimumWidth = 6;
            this.colPuntos.Name = "colPuntos";
            this.colPuntos.ReadOnly = true;
            this.colPuntos.Width = 90;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(696, 135);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 28);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbPuntos
            // 
            this.cmbPuntos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuntos.FormattingEnabled = true;
            this.cmbPuntos.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "400",
            "500",
            "700"});
            this.cmbPuntos.Location = new System.Drawing.Point(532, 76);
            this.cmbPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPuntos.Name = "cmbPuntos";
            this.cmbPuntos.Size = new System.Drawing.Size(190, 23);
            this.cmbPuntos.TabIndex = 5;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(442, 78);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(78, 16);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = "Puntos hasta";
            // 
            // cmbOrdenarPor
            // 
            this.cmbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenarPor.FormattingEnabled = true;
            this.cmbOrdenarPor.Items.AddRange(new object[] {
            "Alfabéticamente (A - Z)",
            "Alfabéticamente (Z - A)",
            "Precio, menor a mayor",
            "Precio, mayor a menor"});
            this.cmbOrdenarPor.Location = new System.Drawing.Point(532, 32);
            this.cmbOrdenarPor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(190, 23);
            this.cmbOrdenarPor.TabIndex = 4;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Location = new System.Drawing.Point(444, 35);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(77, 16);
            this.lblOrdenarPor.TabIndex = 4;
            this.lblOrdenarPor.Text = "Ordenar por";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(136, 72);
            this.cmbTipoProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(190, 23);
            this.cmbTipoProducto.TabIndex = 2;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(44, 76);
            this.lblTipoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(88, 16);
            this.lblTipoProducto.TabIndex = 2;
            this.lblTipoProducto.Text = "Tipo Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(136, 30);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(190, 23);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(23, 32);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(111, 16);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre producto";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.Location = new System.Drawing.Point(17, 626);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(64, 48);
            this.btnNuevoProducto.TabIndex = 8;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProducto.Image")));
            this.btnEditarProducto.Location = new System.Drawing.Point(105, 626);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(59, 48);
            this.btnEditarProducto.TabIndex = 9;
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.Location = new System.Drawing.Point(183, 626);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(64, 48);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(763, 626);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 48);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(849, 687);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.grbProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.grbProductos.ResumeLayout(false);
            this.grbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductos;
        private System.Windows.Forms.ComboBox cmbPuntos;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.ComboBox cmbOrdenarPor;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.TrackBar trbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblValorPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}