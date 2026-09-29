using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26
{
    public partial class MantenimientoBodega : Form
    {
        public MantenimientoBodega()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            navegador1.NavegadorMetConfigurar("tblbodegas", 14, 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteBodega reportForm = new Reportes.FrmReporteBodega();
            reportForm.Show();
        }

        private void MantenimientoBodega_Load(object sender, EventArgs e)
        {

        }
    }
}