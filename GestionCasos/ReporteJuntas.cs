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
    public partial class ReporteJuntas : Form
    {
        public ReporteJuntas()
        {
            InitializeComponent();
        }

        private void ReporteJuntas_Load(object sender, EventArgs e)
        {
           
        }

        private void ReporteJuntas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet1.Juntas' Puede moverla o quitarla según sea necesario.
            this.JuntasTableAdapter.Fill(this.dbsJuntas.Juntas);

            this.reportViewer1.RefreshReport();
        }
    }
}
