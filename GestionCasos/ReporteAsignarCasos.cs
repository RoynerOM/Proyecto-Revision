//using Microsoft.Reporting.WinForms;
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
    public partial class ReporteAsignarCasos : Form
    {
        public ReporteAsignarCasos()
        {
            InitializeComponent();
        }

        private void ReporteAsignarCasos_Load(object sender, EventArgs e)
        {


            try
            {
              
                // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet.CasosAsignados' Puede moverla o quitarla según sea necesario.
                this.CasosAsignadosTableAdapter.Fill(this.BD_JuntasDataSet.CasosAsignados);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
