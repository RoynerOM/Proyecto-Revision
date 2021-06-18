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

namespace GestionCasos
{
    public partial class Login : Form
    {
        Principal principal = new Principal();
        showMessageDialog Message = new showMessageDialog();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Falta codigo aqui
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void lbLogin_Click(object sender, EventArgs e)
        {
            //lbLogin.ForeColor = Color.Aqua;
            //this.Size = new Size(544, 248);

        }

        private void btnLLamar_Click(object sender, EventArgs e)
        {
            btnLLamar.Visible = false;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            t.add(pnTop, "Top", 12);
            t.run();
        }

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            using (BD_JuntasEntities contex = new BD_JuntasEntities())
            {

                var user = contex.t_Usuario.FirstOrDefault(u => u.Cedula == txtNombreUsuario.Text);
                if (user != null)
                {
                    if (user.Clave == txtContraseña.Text)
                    {
                        Message.Success(new Alertas.Alerta(), "Sesión Iniciada correctamente");
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
    }
}
