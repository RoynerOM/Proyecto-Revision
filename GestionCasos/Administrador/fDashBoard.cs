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
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos
{
    public partial class fDashBoard : Form
    {
        readonly ContadorNegocio negocio = new ContadorNegocio();
        readonly RevisionNegocio revision = new RevisionNegocio();
        readonly InstitucionNegocio institucion = new InstitucionNegocio();

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

        private async void CargarEstadisticas()
        {
            try
            {
                if (Rol == (int)Enums.Tipo.Contador)
                {
                    var contadores = await negocio.obtenerTrabador(0);
                    label1.Text = contadores.Count().ToString();


                    var casos = await revision.obtenerTodo();

                    //En revisio
                    var pendientes = casos.Where(x => x.Estado == 2).Count();
                    lblTotaPendientes.Text = pendientes.ToString();
                    lblPendientes.Text = "Casos en revisión";

                    //Tramitados
                    var revicion = casos.Where(x => x.Estado == 3).Count();
                    lblTotalRevisados.Text = revicion.ToString();
                    lblRevisados.Text = "Casos tramitados";

                    //Entrgados
                    var entregados = casos.Where(x => x.Estado == 5).Count();
                    lblEntregados.Text = entregados.ToString();
                    label5.Text = "Casos Entregados";

                    var instituciones = await institucion.obtenerTodo();
                    lblTotalJuntas.Text = instituciones.Where(x => x.Estado == true).Count().ToString();

                    var tramitadores = await negocio.obtenerTrabador(1);
                    lblTramitadores.Text = tramitadores.Count().ToString();
                }
                else
                {
                    var contadores = await negocio.obtenerTrabador(0);
                    label1.Text = contadores.Count().ToString();

                    var casos = await revision.obtenerTodo();

                    var pendientes = casos.Where(x => x.Estado == 2 && x.Tramitador == cedula).Count();
                    lblTotaPendientes.Text = pendientes.ToString();


                    var tramitado = casos.Where(x => x.Estado == 3 && x.Tramitador == cedula).Count();
                    lblTotalRevisados.Text = tramitado.ToString();

                    var entregados = casos.Where(x => x.Estado == 4 && x.Tramitador == cedula).Count();
                    lblEntregados.Text = entregados.ToString();

                    var instituciones = await institucion.obtenerTodo();
                    lblTotalJuntas.Text = instituciones.Count().ToString();

                    var tramitadores = await negocio.obtenerTrabador(1);
                    lblTramitadores.Text = tramitadores.Count().ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void FDashBoard_Load(object sender, EventArgs e)
        {

            string cedula = File.ReadAllText("temp.txt");

            var usuario = await negocio.obtenerPorIdAsync(this.cedula);

            lblNombreU.Text = "Usuario: " + usuario.NombreCompleto + ", " + File.ReadAllText("temp.txt");

            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;

            OpenChildForm(new fLoader(1, hilo));
            CargarEstadisticas();

            if (Rol == 1)
            {
                gunaTileButton2.Enabled = false;
            }
            else
            {
                gunaTileButton2.Enabled = true;
            }

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

                this.label4.ForeColor = Colors.Black;
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
            try
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
            catch (Exception ex)
            {
                Console.Write(ex);
            }
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

        private void gunaTileButton4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesPersonas(Rol));
        }
    }
}
