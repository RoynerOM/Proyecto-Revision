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

namespace GestionCasos
{
    public partial class Login : Form
    {
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
    }
}
