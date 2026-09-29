using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmNavegador : Form
    {
        public FrmNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblempleado", 4, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes1.FrmReportescs reportForm = new Reportes1.FrmReportescs();
            reportForm.Show();
        }
    }
}
