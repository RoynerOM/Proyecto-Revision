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
    public partial class ReporteEntregaDeCasos : Form
    {
        public ReporteEntregaDeCasos()
        {
            InitializeComponent();
        }

        private void ReporteEntregaDeCasos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet2.EntregaDeCasos' Puede moverla o quitarla según sea necesario.
            this.EntregaDeCasosTableAdapter.Fill(this.BD_JuntasDataSet2.EntregaDeCasos);

            this.reportViewer1.RefreshReport();
        }
    }
}
