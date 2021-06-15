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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo usurio registrado","Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
