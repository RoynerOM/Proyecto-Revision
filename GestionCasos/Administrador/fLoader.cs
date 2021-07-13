using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos.Administrador
{
    public partial class fLoader : Form
    {
        private Thread subProceso;
        public fLoader(int segundos, Thread hilo)
        {
            InitializeComponent();
            timer1.Interval = segundos * 1000;    // pasamos de segundos a milisegundos
            subProceso = hilo;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void SetColorTheme()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                this.BackColor = Colors.White;
            }
        }

        private void fLoader_Load(object sender, EventArgs e)
        {
            SetColorTheme();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();     // Se para el timer.

            if (subProceso.IsAlive)
            {
                // Una vez transcurrido el tiempo inicialmente establecido
                // establezco un intervalo de un segundo para mirar si el proceso a terminado.
                
                if (timer1.Interval != 1000)
                    timer1.Interval = 1000;

                timer1.Start();
            }
            else
                this.Close();
        }
    }
}
