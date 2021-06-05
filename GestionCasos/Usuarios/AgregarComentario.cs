using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos.Usuarios
{
    public partial class AgregarComentario : Form
    {
        public AgregarComentario()
        {
            InitializeComponent();
           
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanasAbiertas.Form = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarComentario_Load(object sender, EventArgs e)
        {
            VentanasAbiertas.Form = this;
        }
    }
}
