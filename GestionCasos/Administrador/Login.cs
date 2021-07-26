using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using Entidades;
using Datos;
using Utilidades;
using System.IO;
using System.Threading;

namespace GestionCasos
{
    public partial class Login : Form
    {

        Registrar llamarRegistrar = new Registrar();
        showMessageDialog Message = new showMessageDialog();
        private Form activeForm = null;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbIdentificacion.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLLamar_Click(object sender, EventArgs e)
        {
            btnLLamar.Visible = false;
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
                using (BD_JuntasEntities contex = new BD_JuntasEntities())
                {
                    Principal principal;
                    var user = contex.t_Usuario.FirstOrDefault(u => u.Cedula == txtNombreUsuario.Text);
                    if (user != null)
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

            OpenChildForm(new Registrar());
        }

        private void cbIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdentificacion.SelectedIndex == 0)
            {
                txtNombreUsuario.Mask = "0-0000-0000";
            }
            else
            {
                txtNombreUsuario.Mask = "000000000000";
            }
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
                    using (BD_JuntasEntities contex = new BD_JuntasEntities())
                    {
                        Principal principal;
                        var user = contex.t_Usuario.FirstOrDefault(u => u.Cedula == txtNombreUsuario.Text);
                        if (user != null)
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    using (BD_JuntasEntities contex = new BD_JuntasEntities())
                    {
                        Principal principal;
                        var user = contex.t_Usuario.FirstOrDefault(u => u.Cedula == txtNombreUsuario.Text);
                        if (user != null)
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

    }
}
