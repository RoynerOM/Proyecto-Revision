using Entidades;
using Negocios;
using System;
using System.Windows.Forms;

namespace GestionCasos
{

    /*
     Reporte completo
     */
    public partial class ReporteEntregaDeCasos : Form
    {

        ContadorNegocio persona = new ContadorNegocio();

        public ReporteEntregaDeCasos()
        {
            InitializeComponent();
        }

        private async void CargarCombo()
        {
            try
            {
                cbContadores.DataSource = await persona.obtenerTodo();
                cbContadores.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ReporteEntregaDeCasos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsEntregaCasos.EntregaTable' table. You can move, or remove it, as needed.
            this.EntregaTableTableAdapter.Fill(this.dtsEntregaCasos.EntregaTable);
            this.reportViewer1.RefreshReport();
            CargarCombo();
        }

        private void cbContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EntregaTableTableAdapter.FillBy3(this.dtsEntregaCasos.EntregaTable, cbContadores.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cbCircuito_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EntregaTableTableAdapter.FillBy(this.dtsEntregaCasos.EntregaTable, int.Parse(cbCircuito.Text));
            this.reportViewer1.RefreshReport();
        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            this.EntregaTableTableAdapter.FillBy4(this.dtsEntregaCasos.EntregaTable, txtConsecutivo.Text.ToUpper());
            this.reportViewer1.RefreshReport();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    this.EntregaTableTableAdapter.FillBy1(this.dtsEntregaCasos.EntregaTable, int.Parse(txtCodigo.Text));
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void txtInstitucion_TextChanged(object sender, EventArgs e)
        {
            this.EntregaTableTableAdapter.FillBy2(this.dtsEntregaCasos.EntregaTable, txtInstitucion.Text.ToUpper());
            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.EntregaTableTableAdapter.Fill(this.dtsEntregaCasos.EntregaTable);
            this.reportViewer1.RefreshReport();

            txtConsecutivo.Clear();
            cbCircuito.SelectedIndex = 0;
            txtCodigo.Clear();
            txtInstitucion.Clear();
            cbContadores.SelectedIndex = 0;
        }
    }
}
