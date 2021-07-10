using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
namespace GestionCasos
{
    public partial class fDashBoard : Form
    {
        ContadorNegocio negocio = new ContadorNegocio();
        RevisionNegocio revision = new RevisionNegocio();
        InstitucionNegocio institucion = new InstitucionNegocio();
        private Form activeForm;

        public fDashBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarEstadisticas()
        {
            try
            {
                var cantidad = negocio.CantidadContadores();
                label1.Text = cantidad.ToString();

                var casos = revision.obtenerTodo(new t_Revision());

                var pendientes = casos.Where(x => x.Estado == 1).Count();
                lblTotaPendientes.Text = pendientes.ToString();


                var revicion = casos.Where(x => x.Estado == 2).Count();
                lblTotalRevisados.Text = revicion.ToString();

                var tramitado = casos.Where(x => x.Estado == 3).Count();
                var todos = casos.Count();

                var instituciones = institucion.obtenerTodo(new t_Institucion()).Count();
                lblTotalJuntas.Text = instituciones.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void fDashBoard_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            SetThemeColor();
        }

        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                this.DesktopPanel.BackColor = Color.White; 
                this.DesktopPanel.ForeColor = Color.FromArgb(41, 79, 116);

                this.pnContadores.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnContadores.ForeColor = Color.White;

                this.pnPendientes.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnPendientes.ForeColor = Color.White;

                this.pnRevisados.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnRevisados.ForeColor = Color.White;

                this.gunaElipsePanel4.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel4.ForeColor = Color.White;

                this.gunaElipsePanel5.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel5.ForeColor = Color.White;
            }
            else
            {

            }
        }
        private void pnContadores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCasosAdmin());
        }
        //Pintar formulario hijo
        //Formulario en uso
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
