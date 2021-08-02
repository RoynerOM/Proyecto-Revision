using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fDetallesPersonas : Form
    {
        private Form activeForm = null;
        ContadorNegocio persona = new ContadorNegocio();
        List<tPersona> Personas = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private int Rol = (int)Enums.Tipo.Tramitador;

        public fDetallesPersonas(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
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


        private void fDetallesPersonas_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
            CargarCombos();
            PedirDatos();
        }


        public void PedirDatos()
        {
            try
            {
                Personas = (List<tPersona>)persona.obtenerTodo(new tPersona());
                CargarTabla(Personas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Cambio de color
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
                gunaLabel3.ForeColor = Colors.Black;
                gunaLabel4.ForeColor = Colors.Black;
            }
        }

        public void CargarTabla(IEnumerable<tPersona> lista)
        {
            try
            {
                tabla.Rows.Clear();
                foreach (var item in lista)
                {
                    int nRows = tabla.Rows.Add();
                    tabla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[0].Value = item.Cedula;
                    tabla.Rows[nRows].Cells[1].Value = item.TipoIdentificacion == 0 ? "NACIONAL" : "DIMEX";
                    tabla.Rows[nRows].Cells[2].Value = item.Carnet;
                    tabla.Rows[nRows].Cells[3].Value = item.NombreCompleto;
                    tabla.Rows[nRows].Cells[4].Value = item.Correo;

                    tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[3].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[4].Style.Font = new Font((string)"Segoe UI Semibold", 9);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void CargarCombos()
        {
            //Tramitador
            cbTramitador.DataSource = persona.obtenerTodo(new tPersona());
            cbTramitador.ValueMember = "Cedula";
            cbTramitador.DisplayMember = "NombreCompleto";
        }


        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text != null)
            {
                try
                {
                    var filtro = Personas.Where(x => x.Cedula.StartsWith(txtCedula.Text));
                    CargarTabla(filtro);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                PedirDatos();
            }
        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;

            if (screenWidth >= 1000)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void tabla_Resize(object sender, EventArgs e)
        {
            var Grid = (DataGridView)sender;


            var width = tabla.Width;

            if (width <= 1300)
            {
                Grid.RowsDefaultCellStyle.Font = new Font(Name, 9);
            }
            else
            {
                Grid.RowsDefaultCellStyle.Font = new Font(Name, 10);
            }
        }


        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var filtro = Personas.Where(x => x.Cedula == cbTramitador.SelectedValue.ToString());
                CargarTabla(filtro);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }


        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                string cedula = tabla.Rows[fila].Cells[0].Value.ToString();


                DatosTemp.tPersona = Personas.Where(x => x.Cedula == cedula).SingleOrDefault();


                OpenChildForm(new fContador(Rol));

            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            PedirDatos();
        }
    }
}
