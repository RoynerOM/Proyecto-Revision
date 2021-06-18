using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
namespace GestionCasos
{
    public partial class fDashBoard : Form
    {
        ContadorNegocio negocio = new ContadorNegocio();
        public fDashBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarEstadisticas()
        {
            try
            {
                var cantidad = negocio.CantidadContadores();
                label1.Text = cantidad.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void fDashBoard_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            SetThemeColor();
        }

        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                this.DesktopPanel.BackColor = Color.White; 
                this.DesktopPanel.ForeColor = Color.FromArgb(41, 79, 116);

                this.pnContadores.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnContadores.ForeColor = Color.White;

                this.pnPendientes.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnPendientes.ForeColor = Color.White;

                this.pnRevisados.BaseColor = Color.FromArgb(41, 79, 116);
                this.pnRevisados.ForeColor = Color.White;

                this.gunaElipsePanel4.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel4.ForeColor = Color.White;

                this.gunaElipsePanel5.BaseColor = Color.FromArgb(41, 79, 116);
                this.gunaElipsePanel5.ForeColor = Color.White;
            }
            else
            {

            }
        }
        private void pnContadores_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
