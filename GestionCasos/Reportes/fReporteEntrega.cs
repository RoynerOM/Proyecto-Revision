using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos.Reportes
{
    public partial class fReporteEntrega : Form
    {
        private string _consecutivo = null;
        public fReporteEntrega(string consecutivo)
        {
            InitializeComponent();
            _consecutivo = consecutivo;
        }

        private void fReporteEntrega_Load(object sender, EventArgs e)
        {
            this.Text = "Entrega de Caso " +_consecutivo;
            this.reportViewer1.RefreshReport();
            
        }
    }
}
