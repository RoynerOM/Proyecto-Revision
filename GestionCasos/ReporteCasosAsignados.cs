using System;
using System.Windows.Forms;
using Utilidades.Enumerables;

namespace GestionCasos
{
    /*
     Reporte  completamente funcional
     */
    public partial class ReporteCasosAsignados : Form
    {
        public ReporteCasosAsignados()
        {
            InitializeComponent();
        }
    
        private void ReporteCasosAsignados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet.CasosAsignados' Puede moverla o quitarla según sea necesario.
            this.CasosTableTableAdapter.Fill(this.dtsCasos.CasosTable);
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            this.reportViewer1.RefreshReport();
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.CasosTableTableAdapter.FillBy1(this.dtsCasos.CasosTable, txtConsecutivo.Text);
                this.reportViewer1.RefreshReport();

            }
        }

        private void txtBuscar1_Click(object sender, EventArgs e)
        {
            if (txtConsecutivo.Text != string.Empty)
            {
                this.CasosTableTableAdapter.FillBy1(this.dtsCasos.CasosTable, txtConsecutivo.Text);
                this.reportViewer1.RefreshReport();

            }
            //if (cbReception.Text != string.Empty)
            //{
            //    this.CasosTableTableAdapter.FillBy3(this.dtsCasos.CasosTable, cbReception.Text);
            //    this.reportViewer1.RefreshReport();
            //}
            //if (txtConsecutivo.Text != string.Empty && cbReception.Text != string.Empty)
            //{
            //    this.CasosTableTableAdapter.FillBy1(this.dtsCasos.CasosTable, txtConsecutivo.Text);
            //    this.reportViewer1.RefreshReport();

            //}
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.CasosTableTableAdapter.Fill(this.dtsCasos.CasosTable);
            this.reportViewer1.RefreshReport();

            txtConsecutivo.Clear();
            //cbReception.SelectedIndex = 0;
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            this.CasosTableTableAdapter.FillBy2(this.dtsCasos.CasosTable, dtpFechaInicio.Value, dtpFechaFinal.Value,int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();

        }
    }
}
