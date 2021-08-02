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
     Reportes de completamente funcional
     */
    public partial class ReporteJuntas : Form
    {
        ContadorNegocio persona = new ContadorNegocio();

        public ReporteJuntas()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            cbContadores.DataSource = persona.obtenerTodo(new tPersona());
            cbContadores.DisplayMember = "NombreCompleto";
        }

        private void ReporteJuntas_Load(object sender, EventArgs e)
        {
            CargarCombo();

            // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet1.Juntas' Puede moverla o quitarla según sea necesario.
            //this.JuntasTableAdapter.Fill(this.BD_JuntasDataSet1.Juntas);

            this.reportViewer1.RefreshReport();
        }

        private void cbContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.JuntasTableAdapter.FillBy(this.BD_JuntasDataSet1.Juntas, cbContadores.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.JuntasTableAdapter.FillBy1(this.BD_JuntasDataSet1.Juntas, cbTipo.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cbCiruitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.JuntasTableAdapter.FillBy2(this.BD_JuntasDataSet1.Juntas, int.Parse(cbCiruitos.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cbCiruitos.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            cbContadores.SelectedIndex = 0;

            //this.JuntasTableAdapter.Fill(this.BD_JuntasDataSet1.Juntas);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //this.JuntasTableAdapter.FillBy3(this.BD_JuntasDataSet1.Juntas, txtNombre.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
