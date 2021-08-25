using Entidades;
using GestionCasos.Administrador;
using GestionCasos.Singleton;
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
        readonly ControllerService controller = new ControllerService();
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


        private async void CargarEstadisticas()
        {
            try
            {
                if (Rol == (int)Enums.Tipo.Contador)
                {
                    var contadores = await controller.CrudContador().obtenerTrabador(0);
                    label1.Text = contadores.Count().ToString();

                    var casos = await controller.CrudCaso().obtenerTodo();

                    //En revisio
                    var pendientes = casos.Where(x => x.Estado == 1).Count();
                    lblTotaRevision.Text = pendientes.ToString();

                    var revisados = casos.Where(x => x.Estado == 2).Count();
                    lblCasosRevisados.Text = revisados.ToString();

                    //por Entrega
                    var porEntrega = casos.Where(x => x.Estado == 3).Count();
                    lblTotalPorEntrega.Text = porEntrega.ToString();

                    //Entrgados
                    var entregados = casos.Where(x => x.Estado == 4).Count();
                    lblEntregados.Text = entregados.ToString();

                    var instituciones = await controller.CrudJuntas().obtenerTodo();
                    lblTotalJuntas.Text = instituciones.Where(x => x.Estado == true).Count().ToString();
                }
                else
                {
                    var contadores = await controller.CrudContador().obtenerTrabador(0);
                    label1.Text = contadores.Count().ToString();

                    var casos = await controller.CrudCaso().obtenerTodo();

                    var pendientes = casos.Where(x => x.Estado == 1 && x.Tramitador == cedula).Count();
                    lblTotaRevision.Text = pendientes.ToString();

                    var Revisados = casos.Where(x => x.Estado == 2 && x.Tramitador == cedula).Count();
                    lblCasosRevisados.Text = Revisados.ToString();

                    var tramitado = casos.Where(x => x.Estado == 3 && x.Tramitador == cedula).Count();
                    lblTotalPorEntrega.Text = tramitado.ToString();

                    var entregados = casos.Where(x => x.Estado == 4 && x.Tramitador == cedula).Count();
                    lblEntregados.Text = entregados.ToString();

                    var instituciones = await controller.CrudJuntas().obtenerTodo();
                    lblTotalJuntas.Text = instituciones.Count().ToString();
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

            var usuario = await controller.CrudContador().obtenerPorIdAsync(this.cedula);

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
                this.lblNombreU.ForeColor = Colors.Black;
            }
        }


        private void GunaTileButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCasosAdmin(false));
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
