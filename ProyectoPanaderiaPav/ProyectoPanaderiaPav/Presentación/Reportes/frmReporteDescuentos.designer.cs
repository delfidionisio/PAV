namespace ProyectoPanaderiaPav.Presentación.Reportes
{
    partial class frmReporteDescuentos
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
            this.dsDescuentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDescuentos = new ProyectoPanaderiaPav.Reportes.dsDescuentos();
            this.rpvDescuentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grbFiltrarReporte = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentos)).BeginInit();
            this.grbFiltrarReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsDescuentosBindingSource
            // 
            this.dsDescuentosBindingSource.DataSource = this.dsDescuentos;
            this.dsDescuentosBindingSource.Position = 0;
            // 
            // dsDescuentos
            // 
            this.dsDescuentos.DataSetName = "dsDescuentos";
            this.dsDescuentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvDescuentos
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dsDescuentosBindingSource;
            this.rpvDescuentos.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDescuentos.LocalReport.ReportEmbeddedResource = "ProyectoPanaderiaPav.Reportes.rptDescuentos.rdlc";
            this.rpvDescuentos.Location = new System.Drawing.Point(16, 120);
            this.rpvDescuentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvDescuentos.Name = "rpvDescuentos";
            this.rpvDescuentos.ServerReport.BearerToken = null;
            this.rpvDescuentos.Size = new System.Drawing.Size(1063, 497);
            this.rpvDescuentos.TabIndex = 0;
            // 
            // grbFiltrarReporte
            // 
            this.grbFiltrarReporte.Controls.Add(this.dtpFechaHasta);
            this.grbFiltrarReporte.Controls.Add(this.lblFechaHasta);
            this.grbFiltrarReporte.Controls.Add(this.lblFechaDesde);
            this.grbFiltrarReporte.Controls.Add(this.dtpFechaDesde);
            this.grbFiltrarReporte.Controls.Add(this.btnGenerar);
            this.grbFiltrarReporte.Controls.Add(this.label1);
            this.grbFiltrarReporte.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltrarReporte.Location = new System.Drawing.Point(16, 15);
            this.grbFiltrarReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFiltrarReporte.Name = "grbFiltrarReporte";
            this.grbFiltrarReporte.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFiltrarReporte.Size = new System.Drawing.Size(1064, 97);
            this.grbFiltrarReporte.TabIndex = 2;
            this.grbFiltrarReporte.TabStop = false;
            this.grbFiltrarReporte.Text = "Filtrar Por";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(444, 49);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(130, 27);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(336, 55);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(92, 19);
            this.lblFechaHasta.TabIndex = 8;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(25, 53);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(97, 19);
            this.lblFechaDesde.TabIndex = 7;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(139, 47);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(139, 27);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(657, 49);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            // 
            // frmReporteDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1096, 630);
            this.Controls.Add(this.grbFiltrarReporte);
            this.Controls.Add(this.rpvDescuentos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteDescuentos";
            this.Text = "Reporte descuentos";
            this.Load += new System.EventHandler(this.frmReporteDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentos)).EndInit();
            this.grbFiltrarReporte.ResumeLayout(false);
            this.grbFiltrarReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDescuentos;
        private System.Windows.Forms.GroupBox grbFiltrarReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.BindingSource dsDescuentosBindingSource;
        private ProyectoPanaderiaPav.Reportes.dsDescuentos dsDescuentos;
    }
}