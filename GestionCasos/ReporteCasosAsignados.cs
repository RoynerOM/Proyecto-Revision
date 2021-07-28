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
    public partial class ReporteCasosAsignados : Form
    {
        public ReporteCasosAsignados()
        {
            InitializeComponent();
        }

        private void ReporteCasosAsignados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet.CasosAsignados' Puede moverla o quitarla según sea necesario.
            //this.CasosAsignadosTableAdapter.Fill(this.BD_JuntasDataSet.CasosAsignados);
            this.CasosAsignadosTableAdapter.FillBy(this.BD_JuntasDataSet.CasosAsignados,"R-1");

            this.reportViewer1.RefreshReport();
        }
    }
}
