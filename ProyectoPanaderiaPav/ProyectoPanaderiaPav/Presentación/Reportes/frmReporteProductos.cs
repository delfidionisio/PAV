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

namespace ProyectoPanaderiaPav.Presentación
{
    public partial class frmReporteProductos : Form
    {
        ITipoProductoService servicioTipoProducto = new TipoProductoService();
        IProductoService servicioProducto = new ProductoService();
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            CargarComboTipoProducto(cmbTipoProducto, servicioTipoProducto.traerTodos());

        }

        //private void CargarComboMes()
        //{
        //    List<string> lista = new List<string>() {"Enero", "Febrero", "Marzo", "Abril", "Mayo",
        //                                             "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
        //                                             "Noviembre", "Diciembre"};
        //    cmbMes.DataSource = lista;
        //    int numeroMes = DateTime.Now.Month;
        //    cmbMes.SelectedIndex = numeroMes - 1;

        //}

        private void CargarComboTipoProducto(ComboBox comboTipoProducto, List<TipoProducto> lista)
        {
            comboTipoProducto.DataSource = lista;
            comboTipoProducto.DisplayMember = "Nombre";
            comboTipoProducto.ValueMember = "IdTipo";
            comboTipoProducto.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //string consultaSQL = "SELECT p.nombre, tp.nombre as tipoProd,p.precio, uM.nombre as precioPor , SUM(dv.cantidad) as cantidad" +
            //                        " FROM Productos p JOIN TipoProducto tp ON (p.tipoProducto = tp.idTipo)" +
            //                        " JOIN UnidadMedida uM ON (p.idUnidadMedida = uM.idUnidadMedida)" +
            //                        " JOIN DetalleVenta dv ON (dv.idProducto = p.idProducto)" +
            //                        " JOIN Ventas v ON (v.nroVenta = dv.nroVenta)" +
            //                        " WHERE MONTH(v.fecha) = " + (cmbMes.SelectedIndex - 1) + " ";

            //if (cmbTipoProducto.SelectedIndex != -1)
            //    consultaSQL += "AND tp.nombre = '" + cmbTipoProducto.SelectedValue.ToString() + "' ";


            //consultaSQL += "GROUP BY p.nombre, tp.nombre, p.precio, uM.nombre ORDER BY SUM(dv.cantidad) desc";

            //int mes = cmbMes.SelectedIndex + 1;

            rpProductos.LocalReport.SetParameters(new ReportParameter[]
                                   { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                      new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            string tipoProducto = "";
            if (cmbTipoProducto.SelectedIndex != -1)
                tipoProducto = cmbTipoProducto.SelectedValue.ToString();

            DataTable dataReporte = servicioProducto.traerDatosReporte(dtpFechaDesde.Value, dtpFechaHasta.Value, tipoProducto);

            if (dataReporte.Rows.Count != 0)
            {
                this.dsProductosBindingSource.DataSource = dataReporte;
                rpProductos.RefreshReport();
                //Limpiar();
            }
            else
            {
                MessageBox.Show("No se ha registrado ninguna venta con los datos seleccionados.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                rpProductos.Clear();
            }



            //rpProductos.LocalReport.DataSources.Clear();
            //rpProductos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DBHelper.obtenerInstancia().consultar(consultaSQL)));


        }

        private void Limpiar()
        {
            cmbTipoProducto.SelectedIndex = -1;
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos.Checked)
            {
                cmbTipoProducto.SelectedIndex = -1;
                cmbTipoProducto.Enabled = false;

            }
            else
            {
                cmbTipoProducto.Enabled = true;
            }
        }
    }
}

