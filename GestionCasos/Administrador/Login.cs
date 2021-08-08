using Datos;
using GestionCasos.Usuarios;
using Negocios;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Transitions;
using Utilidades;

namespace GestionCasos
{
    public partial class Login : Form
    {
        readonly UsuarioNegocio un = new UsuarioNegocio();
        private Form activeForm = null;
        readonly showMessageDialog Message = new showMessageDialog();

        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Mask = "0-0000-0000";
            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            t.add(pnTop, "Top", 1);
            t.run();
        }



        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contex = new BDJuntasEntities())
                {
                    Principal principal;
                    var user = contex.tUsuario.Include("tPersona").Where(u => u.Cedula == txtNombreUsuario.Text).SingleOrDefault();


                    if (user != null)
                    {
                        if (user.tPersona.Estado == true)
                        {
                            if (user.Clave == txtContraseña.Text)
                            {
                                if (user.Rol == 0)
                                {
                                    //Message.Success(new Alertas.Alerta(), "Sesión Iniciada correctamente");
                                    principal = new Principal(0);
                                }
                                else
                                {
                                    principal = new Principal(1);
                                }
                                File.WriteAllText("temp.txt", txtNombreUsuario.Text);
                                this.Hide();
                                principal.Show();

                            }
                            else
                            {
                                Message.Danger(new Alertas.Alerta(), "La contraseña es incorrecta");
                            }
                        }
                        else
                        {

                            Message.Danger(new Alertas.Alerta(), "No puede puede ingresar. Usuario bloquedo");
                        }
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), $"El usuario {txtNombreUsuario.Text} no esta registrado");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            fRecuperacion v = new fRecuperacion();
            v.Show();

        }



        private void btnIniciarSecion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (var contex = new BDJuntasEntities())
                    {
                        Principal principal;
                        var user = contex.tUsuario.Include("tPersona").Where(u => u.Cedula == txtNombreUsuario.Text).SingleOrDefault();

                        if (user != null)
                        {
                            if (user.tPersona.Estado == true)
                            {

                                if (user.Clave == txtContraseña.Text)
                                {
                                    if (user.Rol == 0)
                                    {
                                        //Message.Success(new Alertas.Alerta(), "Sesión Iniciada correctamente");
                                        principal = new Principal(0);
                                    }
                                    else
                                    {
                                        principal = new Principal(1);
                                    }
                                    File.WriteAllText("temp.txt", txtNombreUsuario.Text);

                                    this.Hide();
                                    principal.Show();

                                }
                                else
                                {
                                    Message.Danger(new Alertas.Alerta(), "La contraseña es incorrecta");

                                }
                            }
                            else
                            {

                                Message.Danger(new Alertas.Alerta(), "No puede puede ingresar. Usuario bloquedo");
                            }
                        }
                        else
                        {

                            Message.Danger(new Alertas.Alerta(), $"El usuario {txtNombreUsuario.Text} no esta registrado");
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }



        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '•')
            {
                txtContraseña.PasswordChar = '\0';
                gunaAdvenceTileButton1.Image = global::GestionCasos.Properties.Resources.eyea;
            }
            else
            {
                txtContraseña.PasswordChar = '•';
                gunaAdvenceTileButton1.Image = global::GestionCasos.Properties.Resources.eyeb;
            }
        }



        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Mask == "0-0000-0000")
            {
                txtNombreUsuario.Mask = "000000000000";
            }
            else
            {
                txtNombreUsuario.Mask = "0-0000-0000";
            }
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Registrar());
        }
    }
}
