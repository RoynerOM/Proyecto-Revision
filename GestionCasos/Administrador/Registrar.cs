using Entidades;
using Negocios;
using System;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos
{

    public partial class Registrar : Form
    {
        UsuarioNegocio negociosU = new UsuarioNegocio();
        showMessageDialog Message = new showMessageDialog();
        ContadorNegocio contadorNegocio = new ContadorNegocio();

        public Registrar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                tUsuario usuario = new tUsuario();
                tTrabajador trabajador = new tTrabajador();
                trabajador = contadorNegocio.obtenerTrabador(txtCedula.Text);

                if (trabajador != null)
                {
                    if (negociosU.ComprobarCedula(txtCedula.Text))
                    {
                        usuario.Cedula = txtCedula.Text;
                        usuario.Clave = txtContra.Text;
                        usuario.Rol = trabajador.Tipo;
                        usuario.Estado = (int)Enums.Estado.activo != 1;

                        if (negociosU.guardar(usuario))
                        {
                            Message.Success(new Alertas.Alerta(), "El usuario se registró correctamente");
                            this.Close();
                        }
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se pudo registrar el usuario");
                    }
                }
                else
                {
                    Message.Danger(new Alertas.Alerta(), "Error al registar, solo las personas inscritas pueden registrase ");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            cbIdentificacion.SelectedIndex = 0;
        }

        private void btnCerrarR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdentificacion.SelectedIndex == 0)
            {
                txtCedula.Mask = "0-0000-0000";
            }
            else
            {
                txtCedula.Mask = "000000000000";
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    tUsuario usuario = new tUsuario();
                    tTrabajador trabajador = new tTrabajador();
                    trabajador = contadorNegocio.obtenerTrabador(txtCedula.Text);

                    if (trabajador != null)
                    {
                        if (negociosU.ComprobarCedula(txtCedula.Text))
                        {
                            usuario.Cedula = txtCedula.Text;
                            usuario.Clave = txtContra.Text;
                            usuario.Rol = trabajador.Tipo;
                            usuario.Estado = (int)Enums.Estado.activo == 1 ? false : true;

                            if (negociosU.guardar(usuario))
                            {
                                Message.Success(new Alertas.Alerta(), "El usuario se registró correctamente");
                                this.Close();
                            }
                        }
                        else
                        {
                            Message.Danger(new Alertas.Alerta(), "No se pudo registrar el usuario");
                        }
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "Error al registar, solo las personas inscritas pueden registrase ");
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '•')
            {
                txtContra.PasswordChar = '\0';
                gunaAdvenceTileButton1.Image = global::GestionCasos.Properties.Resources.eyea;
            }
            else
            {
                txtContra.PasswordChar = '•';
                gunaAdvenceTileButton1.Image = global::GestionCasos.Properties.Resources.eyeb;
            }
        }
    }
}
