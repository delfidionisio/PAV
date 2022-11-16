using Microsoft.Reporting.WinForms;
using ProyectoPanaderiaPav.Datos;
using ProyectoPanaderiaPav.Entidades;
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
    public partial class frmReporteClientes : Form
    {
        IClienteService servicioCliente;
        public frmReporteClientes()
        {
            InitializeComponent();
            servicioCliente = new ClienteService();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value <= dtpFechaHasta.Value)
            {
                string fechaDesde = dtpFechaDesde.Value.ToString("yyyy/MM/dd");
                string fechaHasta = dtpFechaHasta.Value.ToString("yyyy/MM/dd");

                rpvClientes.LocalReport.SetParameters(new ReportParameter[]{
                                                  new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                                  new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });
                //dsClientesBindingSource.DataSource = servicioCliente.traerDatosReporteClientes();
                rpvClientes.LocalReport.DataSources.Clear();
                rpvClientes.LocalReport.DataSources.Add(new ReportDataSource("dtClientes",
                servicioCliente.traerDatosReporteClientes()));
                this.rpvClientes.RefreshReport();
            }
            else
            {
                MessageBox.Show("Las fechas seleccionadas son inválidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaDesde.Focus();
            }
        }
    }
}
