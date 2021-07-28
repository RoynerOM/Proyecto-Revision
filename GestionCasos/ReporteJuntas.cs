using System;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class ReporteJuntas : Form
    {
        public ReporteJuntas()
        {
            InitializeComponent();
        }

        private void ReporteJuntas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet1.Juntas' Puede moverla o quitarla según sea necesario.
            this.JuntasTableAdapter.Fill(this.BD_JuntasDataSet1.Juntas);

            this.reportViewer1.RefreshReport();
        }
    }
}
