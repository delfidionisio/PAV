
namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaPrima));
            this.groupBoxMatPrima = new System.Windows.Forms.GroupBox();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.dgvMateriaPrima = new System.Windows.Forms.DataGridView();
            this.colIdMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtIdMateriaPrima = new System.Windows.Forms.TextBox();
            this.lblIdMateriaPrima = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnNuevaMateriaPrima = new System.Windows.Forms.Button();
            this.btnEditarMateriaPrima = new System.Windows.Forms.Button();
            this.btnEliminarMateriaPrima = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMatPrima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMatPrima
            // 
            this.groupBoxMatPrima.Controls.Add(this.pictureBox1);
            this.groupBoxMatPrima.Controls.Add(this.checkTodos);
            this.groupBoxMatPrima.Controls.Add(this.dgvMateriaPrima);
            this.groupBoxMatPrima.Controls.Add(this.btnConsultar);
            this.groupBoxMatPrima.Controls.Add(this.txtIdMateriaPrima);
            this.groupBoxMatPrima.Controls.Add(this.lblIdMateriaPrima);
            this.groupBoxMatPrima.Controls.Add(this.txtNombre);
            this.groupBoxMatPrima.Controls.Add(this.lblNombre);
            this.groupBoxMatPrima.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatPrima.Location = new System.Drawing.Point(22, 12);
            this.groupBoxMatPrima.Name = "groupBoxMatPrima";
            this.groupBoxMatPrima.Size = new System.Drawing.Size(547, 502);
            this.groupBoxMatPrima.TabIndex = 0;
            this.groupBoxMatPrima.TabStop = false;
            this.groupBoxMatPrima.Text = "Filtros de Búsqueda";
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTodos.Location = new System.Drawing.Point(369, 132);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(58, 19);
            this.checkTodos.TabIndex = 14;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // dgvMateriaPrima
            // 
            this.dgvMateriaPrima.AllowUserToAddRows = false;
            this.dgvMateriaPrima.AllowUserToDeleteRows = false;
            this.dgvMateriaPrima.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMateriaPrima,
            this.colNombreMateriaPrima,
            this.colStock,
            this.colUnidadMedida});
            this.dgvMateriaPrima.Location = new System.Drawing.Point(60, 176);
            this.dgvMateriaPrima.Name = "dgvMateriaPrima";
            this.dgvMateriaPrima.ReadOnly = true;
            this.dgvMateriaPrima.RowHeadersWidth = 51;
            this.dgvMateriaPrima.Size = new System.Drawing.Size(430, 306);
            this.dgvMateriaPrima.TabIndex = 8;
            this.dgvMateriaPrima.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriaPrima_CellClick);
            // 
            // colIdMateriaPrima
            // 
            this.colIdMateriaPrima.HeaderText = "Id ";
            this.colIdMateriaPrima.MinimumWidth = 6;
            this.colIdMateriaPrima.Name = "colIdMateriaPrima";
            this.colIdMateriaPrima.ReadOnly = true;
            this.colIdMateriaPrima.Width = 125;
            // 
            // colNombreMateriaPrima
            // 
            this.colNombreMateriaPrima.HeaderText = "Nombre";
            this.colNombreMateriaPrima.MinimumWidth = 6;
            this.colNombreMateriaPrima.Name = "colNombreMateriaPrima";
            this.colNombreMateriaPrima.ReadOnly = true;
            this.colNombreMateriaPrima.Width = 125;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 125;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.HeaderText = "Unidad Medida";
            this.colUnidadMedida.MinimumWidth = 6;
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.ReadOnly = true;
            this.colUnidadMedida.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(441, 126);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIdMateriaPrima
            // 
            this.txtIdMateriaPrima.Location = new System.Drawing.Point(144, 80);
            this.txtIdMateriaPrima.Name = "txtIdMateriaPrima";
            this.txtIdMateriaPrima.Size = new System.Drawing.Size(196, 22);
            this.txtIdMateriaPrima.TabIndex = 3;
            // 
            // lblIdMateriaPrima
            // 
            this.lblIdMateriaPrima.AutoSize = true;
            this.lblIdMateriaPrima.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMateriaPrima.Location = new System.Drawing.Point(40, 83);
            this.lblIdMateriaPrima.Name = "lblIdMateriaPrima";
            this.lblIdMateriaPrima.Size = new System.Drawing.Size(93, 15);
            this.lblIdMateriaPrima.TabIndex = 2;
            this.lblIdMateriaPrima.Text = "Id Materia Prima";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(83, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnNuevaMateriaPrima
            // 
            this.btnNuevaMateriaPrima.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevaMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaMateriaPrima.Image")));
            this.btnNuevaMateriaPrima.Location = new System.Drawing.Point(22, 521);
            this.btnNuevaMateriaPrima.Name = "btnNuevaMateriaPrima";
            this.btnNuevaMateriaPrima.Size = new System.Drawing.Size(64, 48);
            this.btnNuevaMateriaPrima.TabIndex = 9;
            this.btnNuevaMateriaPrima.UseVisualStyleBackColor = false;
            this.btnNuevaMateriaPrima.Click += new System.EventHandler(this.btnNuevaMateriaPrima_Click);
            // 
            // btnEditarMateriaPrima
            // 
            this.btnEditarMateriaPrima.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMateriaPrima.Image")));
            this.btnEditarMateriaPrima.Location = new System.Drawing.Point(96, 521);
            this.btnEditarMateriaPrima.Name = "btnEditarMateriaPrima";
            this.btnEditarMateriaPrima.Size = new System.Drawing.Size(59, 48);
            this.btnEditarMateriaPrima.TabIndex = 10;
            this.btnEditarMateriaPrima.UseVisualStyleBackColor = false;
            this.btnEditarMateriaPrima.Click += new System.EventHandler(this.btnEditarMateriaPrima_Click);
            // 
            // btnEliminarMateriaPrima
            // 
            this.btnEliminarMateriaPrima.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMateriaPrima.Image")));
            this.btnEliminarMateriaPrima.Location = new System.Drawing.Point(166, 521);
            this.btnEliminarMateriaPrima.Name = "btnEliminarMateriaPrima";
            this.btnEliminarMateriaPrima.Size = new System.Drawing.Size(64, 48);
            this.btnEliminarMateriaPrima.TabIndex = 11;
            this.btnEliminarMateriaPrima.UseVisualStyleBackColor = false;
            this.btnEliminarMateriaPrima.Click += new System.EventHandler(this.btnEliminarMateriaPrima_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(505, 521);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 48);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(591, 579);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarMateriaPrima);
            this.Controls.Add(this.btnEditarMateriaPrima);
            this.Controls.Add(this.btnNuevaMateriaPrima);
            this.Controls.Add(this.groupBoxMatPrima);
            this.Name = "frmMateriaPrima";
            this.Text = "Materia Prima";
            this.Load += new System.EventHandler(this.frmMateriaPrima_Load);
            this.groupBoxMatPrima.ResumeLayout(false);
            this.groupBoxMatPrima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatPrima;
        private System.Windows.Forms.TextBox txtIdMateriaPrima;
        private System.Windows.Forms.Label lblIdMateriaPrima;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvMateriaPrima;
        private System.Windows.Forms.Button btnNuevaMateriaPrima;
        private System.Windows.Forms.Button btnEditarMateriaPrima;
        private System.Windows.Forms.Button btnEliminarMateriaPrima;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidadMedida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}