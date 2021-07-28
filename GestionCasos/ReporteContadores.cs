using System;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class ReporteContadores : Form
    {
        public ReporteContadores()
        {
            InitializeComponent();
        }

        private void ReporteContadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet1.Contadores' Puede moverla o quitarla según sea necesario.
            this.ContadoresTableAdapter.Fill(this.BD_JuntasDataSet1.Contadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
