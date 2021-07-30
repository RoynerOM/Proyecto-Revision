using Entidades;
using GestionCasos.Administrador;
using GestionCasos.Usuarios;
using Negocios;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades.Enumerables;

namespace GestionCasos
{
    public partial class fDashBoard : Form
    {
        ContadorNegocio negocio = new ContadorNegocio();
        RevisionNegocio revision = new RevisionNegocio();
        InstitucionNegocio institucion = new InstitucionNegocio();
        private Form activeForm;
        private int Rol = (int)Enums.Tipo.Tramitador;
        private string cedula = null;
        public fDashBoard(int Rol)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Rol = Rol;
            cedula = File.ReadAllText("temp.txt");
            SetThemeColor();
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarEstadisticas()
        {
            try
            {
                if (Rol == (int)Enums.Tipo.Contador)
                {
                    var contadores = negocio.obtenerTrabador(0).Count();
                    label1.Text = contadores.ToString();


                    var casos = revision.obtenerTodo(new t_Revision());

                    //En revisio
                    var pendientes = casos.Where(x => x.Estado == 2).Count();
                    lblTotaPendientes.Text = pendientes.ToString();
                    lblPendientes.Text = "Casos en revision";

                    //Tramitados
                    var revicion = casos.Where(x => x.Estado == 3).Count();
                    lblTotalRevisados.Text = revicion.ToString();
                    lblRevisados.Text = "Casos tramitados";

                    //Entrgados
                    var entregados = casos.Where(x => x.Estado == 5).Count();
                    lblEntregados.Text = entregados.ToString();
                    label5.Text = "Casos Entregados";

                    var instituciones = institucion.obtenerTodo(new t_Institucion()).Count();
                    lblTotalJuntas.Text = instituciones.ToString();

                    var tramitadores = negocio.obtenerTrabador(1).Count();
                    lblTramitadores.Text = tramitadores.ToString();
                }
                else
                {
                    var contadores = negocio.obtenerTrabador(0).Count();
                    label1.Text = contadores.ToString();

                    var casos = revision.obtenerTodo(new t_Revision());

                    var pendientes = casos.Where(x => x.Estado == 2 && x.Tramitador == cedula).Count();
                    lblTotaPendientes.Text = pendientes.ToString();


                    var tramitado = casos.Where(x => x.Estado == 3 && x.Tramitador == cedula).Count();
                    lblTotalRevisados.Text = tramitado.ToString();

                    var entregados = casos.Where(x => x.Estado == 4 && x.Tramitador == cedula).Count();
                    lblEntregados.Text = entregados.ToString();

                    var instituciones = institucion.obtenerTodo(new t_Institucion()).Count();
                    lblTotalJuntas.Text = instituciones.ToString();

                    var tramitadores = negocio.obtenerTrabador(1).Count();
                    lblTramitadores.Text = tramitadores.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FDashBoard_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;

            OpenChildForm(new fLoader(1, hilo));
            CargarEstadisticas();

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

                this.gunaElipsePanel2.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel2.ForeColor = Color.White;

                this.gunaElipsePanel1.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel1.ForeColor = Color.White;
            }
            else
            {

            }
        }
        private void PnContadores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaTileButton1_Click(object sender, EventArgs e)
        {

            if (Rol == (int)Enums.Tipo.Contador)
            {
                OpenChildForm(new fCasosAdmin(false));
            }
            else
            {
                OpenChildForm(new CasosAsignados(false));
            }
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

        private void GunaTileButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AsignarCaso());
        }

        private void GunaTileButton4_Click(object sender, EventArgs e)
        {
            if (Rol == (int)Enums.Tipo.Contador)
            {
                OpenChildForm(new fCasosAdmin(true));
            }
            else
            {
                OpenChildForm(new CasosAsignados(true));
            }
        }

        private void GunaTileButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesJuntas(Rol));
        }
    }
}
