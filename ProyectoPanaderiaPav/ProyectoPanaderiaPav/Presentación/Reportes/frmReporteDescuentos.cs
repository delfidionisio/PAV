using Microsoft.Reporting.WinForms;
using ProyectoPanaderiaPav.Datos;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Reportes;
using ProyectoPanaderiaPav.Servicios.Implementaciones;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Presentación.Reportes
{
    public partial class frmReporteDescuentos : Form
    {
        IVentaService servicioVenta;
        public frmReporteDescuentos()
        {
            InitializeComponent();
            servicioVenta = new VentaService();
        }

        private void frmReporteDescuentos_Load(object sender, EventArgs e)
        {
            //this.rpvDescuentos.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            rpvDescuentos.LocalReport.SetParameters(new ReportParameter[]
                                   { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                     new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            DataTable dataReporte = servicioVenta.traerDatosReporteDescuentos(dtpFechaDesde.Value.ToString("yyyy/MM/dd"), 
                dtpFechaHasta.Value.ToString("yyyy/MM/dd"));

            rpvDescuentos.LocalReport.DataSources.Clear();
            rpvDescuentos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataReporte));
            this.rpvDescuentos.RefreshReport();

            //if (dataReporte.Rows.Count != 0)
            //{
                //this.dsProductosBindingSource.DataSource = dataReporte;
                //rpProductos.RefreshReport();
                //Limpiar();
            //}
            //else
            //{
            //    MessageBox.Show("No se ha registrado ninguna venta con los datos seleccionados.",
            //                    "Información",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Exclamation,
            //                    MessageBoxDefaultButton.Button1);
            //    rpProductos.Clear();
            //}

        }

    }
}
