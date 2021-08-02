using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos
{
    /*
     Reporte completado
     */
    public partial class ReporteContadores : Form
    {
        public ReporteContadores()
        {
            InitializeComponent();
        }

        private void ReporteContadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsContador.tPersona' table. You can move, or remove it, as needed.
            this.tPersonaTableAdapter.Fill(this.dtsContador.tPersona);
            this.reportViewer1.RefreshReport();
        }
    }
}
