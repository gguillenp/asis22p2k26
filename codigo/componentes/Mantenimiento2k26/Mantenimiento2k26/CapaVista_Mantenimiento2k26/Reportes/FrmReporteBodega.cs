using System;
using System.Windows.Forms;
using CapaControlador_Mantenimiento2k26;
using Microsoft.Reporting.WinForms;

namespace CapaVista_Mantenimiento2k26.Reportes
{
    public partial class FrmReporteBodega : Form
    {
        private ClsModeloBodega _ModeloBodega = new ClsModeloBodega();

        public FrmReporteBodega()
        {
            InitializeComponent();
        }

        private void FrmReporteBodega_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("Bodegas", _ModeloBodega.MantenimientoMetObtenerBodegasReporte());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Mantenimiento2k26.Reportes.RpReporteBodega.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
