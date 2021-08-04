using Entidades;
using Negocios;
using System;
using System.Windows.Forms;

namespace GestionCasos
{
    /*
     Reportes de completado
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
            // TODO: This line of code loads data into the 'dtsJuntas.TableJuntas' table. You can move, or remove it, as needed.
            this.TableJuntasTableAdapter.Fill(this.dtsJuntas.TableJuntas);
            this.reportViewer1.RefreshReport();
        }

        private void cbContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TableJuntasTableAdapter.FillBy2(this.dtsJuntas.TableJuntas, cbContadores.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TableJuntasTableAdapter.FillBy3(this.dtsJuntas.TableJuntas, cbTipo.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cbCiruitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TableJuntasTableAdapter.FillBy(this.dtsJuntas.TableJuntas, cbCiruitos.SelectedIndex+1);
            this.reportViewer1.RefreshReport();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cbCiruitos.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            cbContadores.SelectedIndex = 0;

            this.TableJuntasTableAdapter.Fill(this.dtsJuntas.TableJuntas);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                this.TableJuntasTableAdapter.FillBy1(this.dtsJuntas.TableJuntas, txtNombre.Text.ToUpper());
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
