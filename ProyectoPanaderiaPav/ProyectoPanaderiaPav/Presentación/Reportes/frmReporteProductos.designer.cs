namespace ProyectoPanaderiaPav.Presentación
{
    partial class frmReporteProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductos = new ProyectoPanaderiaPav.Reportes.dsProductos();
            this.rpProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grbFiltrarReporte = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            this.grbFiltrarReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsProductosBindingSource
            // 
            this.dsProductosBindingSource.DataSource = this.dsProductos;
            this.dsProductosBindingSource.Position = 0;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpProductos
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dsProductosBindingSource;
            this.rpProductos.LocalReport.DataSources.Add(reportDataSource2);
            this.rpProductos.LocalReport.ReportEmbeddedResource = "ProyectoPanaderiaPav.Reportes.rptProductos.rdlc";
            this.rpProductos.Location = new System.Drawing.Point(12, 130);
            this.rpProductos.Name = "rpProductos";
            this.rpProductos.ServerReport.BearerToken = null;
            this.rpProductos.Size = new System.Drawing.Size(651, 413);
            this.rpProductos.TabIndex = 0;
            // 
            // grbFiltrarReporte
            // 
            this.grbFiltrarReporte.Controls.Add(this.checkBoxTodos);
            this.grbFiltrarReporte.Controls.Add(this.dtpFechaHasta);
            this.grbFiltrarReporte.Controls.Add(this.dtpFechaDesde);
            this.grbFiltrarReporte.Controls.Add(this.lblFechaHasta);
            this.grbFiltrarReporte.Controls.Add(this.btnGenerar);
            this.grbFiltrarReporte.Controls.Add(this.cmbTipoProducto);
            this.grbFiltrarReporte.Controls.Add(this.label3);
            this.grbFiltrarReporte.Controls.Add(this.lblFechaDesde);
            this.grbFiltrarReporte.Controls.Add(this.label1);
            this.grbFiltrarReporte.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltrarReporte.Location = new System.Drawing.Point(12, 12);
            this.grbFiltrarReporte.Name = "grbFiltrarReporte";
            this.grbFiltrarReporte.Size = new System.Drawing.Size(650, 112);
            this.grbFiltrarReporte.TabIndex = 1;
            this.grbFiltrarReporte.TabStop = false;
            this.grbFiltrarReporte.Text = "Filtrar Por";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(124, 68);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(89, 23);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(124, 28);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(89, 23);
            this.dtpFechaDesde.TabIndex = 7;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(37, 68);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(78, 16);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(523, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Todos"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(317, 30);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoProducto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(37, 33);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(81, 16);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(317, 72);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(62, 20);
            this.checkBoxTodos.TabIndex = 9;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // frmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.rpProductos);
            this.Controls.Add(this.grbFiltrarReporte);
            this.Name = "frmReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Productos";
            this.Load += new System.EventHandler(this.frmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            this.grbFiltrarReporte.ResumeLayout(false);
            this.grbFiltrarReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpProductos;
        private System.Windows.Forms.GroupBox grbFiltrarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Button btnGenerar;
        private ProyectoPanaderiaPav.Reportes.dsProductos dsProductos;
        private System.Windows.Forms.BindingSource dsProductosBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.CheckBox checkBoxTodos;
    }
}