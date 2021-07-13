using GestionCasos.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos.Reportes
{
    public partial class fOpcionesReportes : Form
    {
        private Form activeForm;

        public fOpcionesReportes()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnCasos_Click(object sender, EventArgs e)
        {

            OpenChildForm(new ReporteAsignarCasos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteJuntas());

        }

        private void btnContadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteContadores());

        }
    }
}
