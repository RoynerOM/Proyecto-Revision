using Entidades;
using Negocios;
using System;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos
{

    public partial class Registrar : Form
    {

        UsuarioNegocio negociosU = new UsuarioNegocio();
        showMessageDialog Message = new showMessageDialog();


        public Registrar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void MostrarNombre()
        {

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

        }

    }
}
