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
    public partial class AsignarCaso : Form
    {
        public AsignarCaso()
        {
            InitializeComponent();
        }

        private void AsignarCaso_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso asignado con exito","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
