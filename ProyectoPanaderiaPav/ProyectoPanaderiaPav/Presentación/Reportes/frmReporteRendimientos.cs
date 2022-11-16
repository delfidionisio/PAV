using Microsoft.Reporting.WinForms;
using ProyectoPanaderiaPav.Datos;
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
    public partial class frmReporteRendimientos : Form
    {
        public frmReporteRendimientos()
        {
            InitializeComponent();
        }

        private void frmRendimientos_Load(object sender, EventArgs e)
        {
            string consultaSQL = "SELECT COUNT(nroVenta) as Cantidad, DATENAME(MONTH, fecha) mes " +
                                 "FROM Ventas " +
                                 "GROUP BY DATENAME(MONTH, fecha), MONTH(fecha)";
            rpvRendimientos.LocalReport.DataSources.Clear();
            rpvRendimientos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DBHelper.obtenerInstancia().consultar(consultaSQL)));
            this.rpvRendimientos.RefreshReport();
        }
    }
}
