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
using Datos;
using Entidades;
using Utilidades;

namespace GestionCasos.Administrador
{
    public partial class fUsers : Form
    {
        List<tUsuario> lista = null;
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];

        public fUsers()
        {
            InitializeComponent();
            SetThemeColor();
        }


        private void SetThemeColor()
        {
            if (isDark == "false")
            {
                this.panel1.BackColor = Colors.White;
                this.panel1.ForeColor = Colors.Black;
                tabla.ColumnHeadersDefaultCellStyle.BackColor = Colors.Blue;
                tabla.ColumnHeadersDefaultCellStyle.ForeColor = Colors.White;
                tabla.RowHeadersDefaultCellStyle.BackColor = Colors.White;
                tabla.RowHeadersDefaultCellStyle.ForeColor = Colors.Black;
                tabla.RowsDefaultCellStyle.BackColor = Colors.White;
                tabla.RowsDefaultCellStyle.ForeColor = Colors.Black;
                tabla.RowHeadersDefaultCellStyle.SelectionBackColor = Colors.Gray;
                tabla.RowsDefaultCellStyle.SelectionBackColor = Colors.Gray;
                tabla.BackgroundColor = Color.White;
            }
        }

        public void PedirDatos()
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var c = db.tUsuario.Include("tPersona").ToList();
                    if (c != null)
                    {
                        CargarTabla(c);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        public void CargarTabla(List<tUsuario> listaU)
        {
            tabla.Rows.Clear();

            try
            {
                foreach (var item in listaU)
                {
                    int nRows = tabla.Rows.Add();
                    tabla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    tabla.Rows[nRows].Cells[0].Value = item.Cedula;
                    tabla.Rows[nRows].Cells[1].Value = item.tPersona.NombreCompleto;
                    tabla.Rows[nRows].Cells[2].Value = item.Clave;


                    tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);

                }
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


        private void fUsers_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
            PedirDatos();
        }
    }
}
