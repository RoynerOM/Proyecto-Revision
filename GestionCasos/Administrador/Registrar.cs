using Entidades;
using Negocios;
using System;
using System.Threading;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos
{

    public partial class Registrar : Form
    {

        UsuarioNegocio negociosU = new UsuarioNegocio();
        showMessageDialog Message = new showMessageDialog();

        private Form activeForm = null;
        public Registrar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            t_Usuario usuario = new t_Usuario();

            if (negociosU.ComprobarCedula(txtCedula.Text))
            {
                usuario.Cedula = txtCedula.Text;
                usuario.Clave = txtContra.Text;

                //usuario.Estado = (int)Enums.Estado.Activo == 1 ? false : true;

                if (negociosU.guardar(usuario))
                {
                    Message.Success(new Alertas.Alerta(), "El usuario se registro correctamente");
                }

            }
            else
            {
                Message.Danger(new Alertas.Alerta(), "No se pudo registrar el usuario");
            }


        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
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

    }
}
