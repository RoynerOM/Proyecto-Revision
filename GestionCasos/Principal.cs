using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Registrar llamarRegistrar = new Registrar();
        AsignarCaso llamarAsignarCaso = new AsignarCaso();
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //llamarRegistrar.Show();
            //llamarRegistrar.TopMost = true;
        }
 
        private void btnAsignarCasos_Click(object sender, EventArgs e)
        {
            llamarAsignarCaso.Show();
            llamarAsignarCaso.TopMost = true;
        }

        private void btnDashBoard_MouseEnter(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(9, 12, 16);
        }
    }

}
