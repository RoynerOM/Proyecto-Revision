using GestionCasos.Administrador;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos.Reportes
{
    public partial class fOpcionesReportes : Form
    {
        private Form activeForm;
        private int Rol = 0;
        public fOpcionesReportes(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
        }


        //private void OpcionesPermitidas()
        //{
        //    if (Rol == 0)
        //    {
        //        btnCasos.Visible = false;
        //        btnCasos.Enabled = false;

        //        btnContadores.Visible = false;
        //        btnContadores.Enabled = false;

        //        btnJuntas.Visible = false;
        //        btnJuntas.Enabled = false;
        //    }
        //    else
        //    {
        //        btnCasos.Visible = true;
        //        btnCasos.Enabled = true;

        //        btnContadores.Visible = true;
        //        btnContadores.Enabled = true;

        //        btnJuntas.Visible = true;
        //        btnJuntas.Enabled = true;
        //    }
        //}


        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                flowLayoutPanel1.BackColor = Colors.White;

                btnContadores.BaseColor = Colors.Blue;
                btnCasos.BaseColor = Colors.Blue;
                btnReportes.BaseColor = Colors.Blue;
                btnEntregas.BaseColor = Colors.Blue;


                btnContadores.OnHoverBaseColor = Colors.BlueHover;
                btnCasos.OnHoverBaseColor = Colors.BlueHover;
                btnReportes.OnHoverBaseColor = Colors.BlueHover;
                btnEntregas.OnHoverBaseColor = Colors.BlueHover;

            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnCasos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteCasosAsignados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteJuntas());

        }

        private void btnContadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteContadores());

        }

        private void fOpcionesReportes_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));

        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteEntregaDeCasos());
        }
    }
}
