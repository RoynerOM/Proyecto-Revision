//using Microsoft.Reporting.WinForms;
using GestionCasos.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class ReporteAsignarCasos : Form
    {
        private Form activeForm = null;
        public ReporteAsignarCasos()
        {
            InitializeComponent();
        }

        private void ReporteAsignarCasos_Load(object sender, EventArgs e)
        {
            try
            {
                Procesos proceso = new Procesos();
                Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
                hilo.Start();                           // Ejecutamos el subproceso
                while (!hilo.IsAlive) ;

                OpenChildForm(new fLoader(2, hilo));
                // TODO: esta línea de código carga datos en la tabla 'BD_JuntasDataSet.CasosAsignados' Puede moverla o quitarla según sea necesario.
                this.CasosAsignadosTableAdapter.Fill(this.BD_JuntasDataSet.CasosAsignados);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
