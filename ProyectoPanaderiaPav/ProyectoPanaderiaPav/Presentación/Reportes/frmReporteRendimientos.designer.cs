namespace ProyectoPanaderiaPav.Presentación.Reportes
{
    partial class frmReporteRendimientos
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
            this.rpvRendimientos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvRendimientos
            // 
            this.rpvRendimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRendimientos.LocalReport.ReportEmbeddedResource = "ProyectoPanaderiaPav.Reportes.rptRendimientos.rdlc";
            this.rpvRendimientos.Location = new System.Drawing.Point(0, 0);
            this.rpvRendimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvRendimientos.Name = "rpvRendimientos";
            this.rpvRendimientos.ServerReport.BearerToken = null;
            this.rpvRendimientos.Size = new System.Drawing.Size(945, 572);
            this.rpvRendimientos.TabIndex = 0;
            // 
            // frmReporteRendimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(945, 572);
            this.Controls.Add(this.rpvRendimientos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteRendimientos";
            this.Text = "Gráfico ventas por mes";
            this.Load += new System.EventHandler(this.frmRendimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvRendimientos;
    }
}