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
    public partial class fDetallesJuntas : Form
    {
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        InstitucionNegocio institucionNegocio = new InstitucionNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        IEnumerable<t_Institucion> Instituciones = null;
        private int Rol = (int)Enums.Tipo.Tramitador;

        public fDetallesJuntas(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
        }


        public void PedirDatos()
        {
            Instituciones = institucionNegocio.obtenerTodo(new t_Institucion());
            CargarTabla(Instituciones);
        }

        //Filtro por Contador
        public void FilterByTramitador(string valor)
        {
            var filtro = Instituciones.Where(x => x.Contador == valor);
            if (filtro != null)
            {
                CargarTabla(filtro);
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
                gunaLabel1.ForeColor = Colors.Black;
                gunaLabel3.ForeColor = Colors.Black;
                gunaLabel4.ForeColor = Colors.Black;
            }
        }


        public void CargarTabla(IEnumerable<t_Institucion> lista)
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
                tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                tabla.Rows[nRows].Cells[0].Value = item.Codigo;
                tabla.Rows[nRows].Cells[1].Value = item.Circuito;
                tabla.Rows[nRows].Cells[2].Value = item.t_Tipo_Institucion.NombreTipo;
                tabla.Rows[nRows].Cells[3].Value = item.Nombre;
                tabla.Rows[nRows].Cells[4].Value = item.Cedula_Juridica;
                tabla.Rows[nRows].Cells[5].Value = item.Cuenta_Danea;
                tabla.Rows[nRows].Cells[6].Value = item.Cuenta_Ley;
                tabla.Rows[nRows].Cells[7].Value = item.t_Persona.Nombre_Completo.ToUpper();
                tabla.Rows[nRows].Cells[8].Value = item.Responsable.ToUpper();
                tabla.Rows[nRows].Cells[9].Value = item.Contacto;

                tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[7].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[9].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[3].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[4].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[5].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[6].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[7].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[9].Style.Font = new Font((string)"Segoe UI Semibold", 9);
            }
        }


        private void fDetallesJuntas_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;

            OpenChildForm(new fLoader(1, hilo));

            PedirDatos();
            CargarCombos();
        }


        public void CargarCombos()
        {
            //Tramitador
            cbTramitador.DataSource = persona.obtenerTodo(new t_Persona());
            cbTramitador.ValueMember = "Cedula";
            cbTramitador.DisplayMember = "Nombre_Completo";
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                var filtro = Instituciones.Where(x => x.Nombre.Trim().ToUpper().StartsWith(txtNombre.Text.Trim().ToUpper()));
                CargarTabla(filtro);
            }
            else
            {
                PedirDatos();
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


        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (screenWidth < 1440)
            {
                tabla.Columns[0].Width = 90;
                tabla.Columns[1].Width = 60;
                tabla.Columns[2].Width = 90;
                tabla.Columns[3].Width = 300;
                tabla.Columns[4].Width = 120;
                tabla.Columns[5].Width = 140;
                tabla.Columns[6].Width = 140;
                tabla.Columns[7].Width = 300;
                tabla.Columns[8].Width = 300;
                tabla.Columns[9].Width = 100;

            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void txtCedulaJuridica_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void txtCedulaJuridica_TextChanged(object sender, EventArgs e)
        {
            if (txtCedulaJuridica.Text.Length > 6)
            {
                var filtro = Instituciones.Where(x => x.Cedula_Juridica.StartsWith(txtCedulaJuridica.Text));
                CargarTabla(filtro);
            }
            else
            {
                PedirDatos();
            }
        }



        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var filtro = Instituciones.Where(x => x.Contador == cbTramitador.SelectedValue.ToString());

            CargarTabla(filtro);
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

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                int codigo = (int)tabla.Rows[fila].Cells[0].Value;


                DatosTemp.t_Institucion = Instituciones.Where(x => x.Codigo == codigo).SingleOrDefault();


                OpenChildForm(new fInstituciones(Rol));

            }
        }
    }
}
