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
using Utilidades;
using Entidades;
namespace GestionCasos.Usuarios
{
    public partial class fRecuperacion : Form
    {
        UsuarioNegocio negociosU = new UsuarioNegocio();
        showMessageDialog Message = new showMessageDialog();
        tUsuario user;
        public fRecuperacion()
        {
            InitializeComponent();
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

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            if (txtCedula.Mask == "0-0000-0000")
            {

                txtCedula.Mask = "000000000000";
            }
            else
            {
                txtCedula.Mask = "0-0000-0000";
            }
        }
        private void LimpiarCampos()
        {
            txtCedula.ResetText();
            txtCodigo.ResetText();
            txtContra.ResetText(); 
        }
        private void fRecuperacion_Load(object sender, EventArgs e)
        {
            txtCedula.Mask = "0-0000-0000";
            txtCodigo.Enabled = false;
            txtContra.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    user.Clave = txtContra.Text;

                    if (negociosU.modificar(user)== true)
                    {
                        Message.Success(new Alertas.Alerta(), "Contraseña modificada correctamente ");
                        LimpiarCampos();
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se pudo actualizar la Contraseña, intentelo nuevamente");
                        LimpiarCampos();
                    }
                }
                else
                {
                    Message.Danger(new Alertas.Alerta(), "No se encotro usuario ");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void txtCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length > 10 && txtCedula.Mask == "0-0000-0000"
                || txtCedula.Text.Length > 11 && txtCedula.Mask == "000000000000")
            {
                try
                {
                    user = negociosU.obtenerPorId(txtCedula.Text);
                    if (user != null)
                    {
                        txtCodigo.Enabled = true;
                        lblCodigo.Text = user.CodigoRes.ToString();
                    }
                    else
                    {
                        lblCodigo.Text = "not found";
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == lblCodigo.Text)
            {
                txtContra.Enabled = true;
                btnRegistrar.Enabled = true;
            }
            else
            {
                txtContra.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }
    }
}
