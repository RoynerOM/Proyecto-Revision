
using System;
using System.Windows.Forms;
namespace GestionCasos
{
    public partial class ReporteBoletaDevolucion : Form
    {
        private string consecutivo = null;
        public ReporteBoletaDevolucion(string consecutivo)
        {
            InitializeComponent();
            this.consecutivo = consecutivo;
        }

        private void ReporteBoletaDevolucion_Load(object sender, EventArgs e)
        {

               

        }
    }
}
