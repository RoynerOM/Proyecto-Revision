using System;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class fReporteBoleta : Form
    {
        private string consecutivo;
        public fReporteBoleta(string consecutivo)
        {
            InitializeComponent();
            this.consecutivo = consecutivo;
        }

        private void fReporteBoleta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsBoleta.BoletaTable' table. You can move, or remove it, as needed.
            this.BoletaTableTableAdapter.FillBy(this.dtsBoleta.BoletaTable, consecutivo);

            this.reportViewer1.RefreshReport();
        }
    }
}
