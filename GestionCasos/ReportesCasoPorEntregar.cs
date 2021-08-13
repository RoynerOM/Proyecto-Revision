using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace GestionCasos
{
    public partial class ReportesCasoPorEntregar : Form
    {
        EstadoNegocio estado = new EstadoNegocio();
        public ReportesCasoPorEntregar()
        {
            InitializeComponent();
        }

        public async void CargarCombos()
        {
            try
            {
                var lista = await estado.obtenerTodo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ReportesCasoPorEntregar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCasosPorEntregar.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.dtsCasosPorEntregar.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDia.Text != string.Empty)
            {
                this.DataTable1TableAdapter.FillBy(this.dtsCasosPorEntregar.DataTable1,cbEstado.Text,dtDesde.Value,dtHasta.Value,cbDia.Text);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
