using Entidades;
using Negocios;
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

    /*
     Reporte falta completar
     */
    public partial class ReporteEntregaDeCasos : Form
    {

        ContadorNegocio persona = new ContadorNegocio();

        public ReporteEntregaDeCasos()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            cbContadores.DataSource = persona.obtenerTodo(new tPersona());
            cbContadores.DisplayMember = "NombreCompleto";
        }

        private void ReporteEntregaDeCasos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsEntregaCasos.EntregaTable' table. You can move, or remove it, as needed.
            this.EntregaTableTableAdapter.Fill(this.dtsEntregaCasos.EntregaTable);
            
            this.reportViewer1.RefreshReport();
        }

        private void cbContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.FillBy4(this.BD_JuntasDataSet2.EntregaCasos, cbContadores.Text);
            //this.reportViewer1.RefreshReport();
        }

        private void cbCircuito_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.FillBy1(this.BD_JuntasDataSet2.EntregaCasos, int.Parse(cbCircuito.Text));
            //this.reportViewer1.RefreshReport();
        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.FillBy(this.BD_JuntasDataSet2.EntregaCasos, txtConsecutivo.Text);
            //this.reportViewer1.RefreshReport();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.FillBy2(this.BD_JuntasDataSet2.EntregaCasos, int.Parse(txtCodigo.Text));
            //this.reportViewer1.RefreshReport();
        }

        private void txtInstitucion_TextChanged(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.FillBy3(this.BD_JuntasDataSet2.EntregaCasos, txtInstitucion.Text);
            //this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //this.EntregaCasosTableAdapter.Fill(this.BD_JuntasDataSet2.EntregaCasos);
            //this.reportViewer1.RefreshReport();

            txtConsecutivo.Clear();
            cbCircuito.SelectedIndex = 0;
            txtCodigo.Clear();
            txtInstitucion.Clear();
            cbContadores.SelectedIndex = 0;
        }
    }
}
