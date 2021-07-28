
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
    public partial class ReporteBoletaDevolucion : Form
    {
        private string consecutivo = "";
        public ReporteBoletaDevolucion(string consecutivo)
        {
            InitializeComponent();
            this.consecutivo = consecutivo;
        }

        private void ReporteBoletaDevolucion_Load(object sender, EventArgs e)
        {
            if (consecutivo != string.Empty || consecutivo != "")
            {
                try
                {
                    // TODO: This line of code loads data into the 'BD_JuntasDataSet3.viewBoleta' table. You can move, or remove it, as needed.
                    this.viewBoletaTableAdapter.FillBy(this.BD_JuntasDataSet3.viewBoleta, consecutivo);
                    // TODO: This line of code loads data into the 'BD_JuntasDataSet3.viewBoleta' table. You can move, or remove it, as needed.
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }
    }
}
