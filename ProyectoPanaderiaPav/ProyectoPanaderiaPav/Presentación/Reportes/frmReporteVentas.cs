using Microsoft.Reporting.WinForms;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Reportes;
using ProyectoPanaderiaPav.Servicios.Implementaciones;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPanaderiaPav.Presentación.Reportes
{
    public partial class frmReporteVentas : Form
    {
        IVentaService servicioVenta;
        IEmpleadoService servicioEmpleado;

        public frmReporteVentas()
        {
            InitializeComponent();
            servicioVenta = new VentaService();
            servicioEmpleado = new EmpleadoService();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            CargarComboEmpleados();
            //CargarComboClientes();
            
        }

        private void CargarComboEmpleados()
        {
            cmbEmpleados.DataSource = servicioEmpleado.traerTodos();
            cmbEmpleados.ValueMember = "idEmpleado";
            cmbEmpleados.DisplayMember = "NombreCompleto";
            //cmbEmpleados.Items.Insert(0, "Todos");
            cmbEmpleados.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value <= dtpFechaHasta.Value)
            {
                string fechaDesde = dtpFechaDesde.Value.ToString("yyyy/MM/dd");
                string fechaHasta = dtpFechaHasta.Value.ToString("yyyy/MM/dd");
                string empleado = " ";

                int idEmpleado = 0;
                if (cmbEmpleados.SelectedIndex != -1)
                {
                    idEmpleado = (int)cmbEmpleados.SelectedValue;
                }

                rpvVentas.LocalReport.SetParameters(new ReportParameter[]{
                                                  new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                                  new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")),
                                                  new ReportParameter("prEmpleado", empleado.ToString())});

                if (cmbEmpleados.SelectedIndex != -1)
                {
                    rpvVentas.LocalReport.SetParameters(new ReportParameter[]{
                                                  new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                                  new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")),
                                                  new ReportParameter("prEmpleado", cmbEmpleados.Text.ToString())});
                }
                
                
                dsVentasBindingSource.DataSource = servicioVenta.traerDatosReporteVentas(fechaDesde, fechaHasta, idEmpleado);
                this.rpvVentas.RefreshReport();
            }
            else
            {
                MessageBox.Show("Las fechas seleccionadas son inválidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaDesde.Focus();
            }
                
           
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            cmbEmpleados.SelectedIndex = -1;
            cmbEmpleados.Enabled = true;
            if (chkTodos.Checked)
            {
                cmbEmpleados.Enabled = false;
            }
        }

        //private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        //{
        //    // Assuming your class called Employee , and Firstname & Lastname are the fields
        //    string lastname = ((Empleado)e.ListItem).Nombre;
        //    string firstname = ((Empleado)e.ListItem).Apellido;
        //    e.Value = lastname + " " + firstname;
        //}

    }
}
