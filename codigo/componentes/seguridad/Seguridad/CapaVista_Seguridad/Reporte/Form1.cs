using CapaControlador_Seguridad;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad.Reportes1
{
    public partial class FrmReportescs : Form
    {

        private ClsModeloModulo Seguridad1 = new ClsModeloModulo();
        public FrmReportescs()
        {
            InitializeComponent();
        }

        private void FrmReportescs_Load_1(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("Seguridad", Seguridad1.SeguridadMetObtenerModulosReporte());
            reportViewer2.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reporte.Report1.rdlc";
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer2.RefreshReport();
        }
    }
}
