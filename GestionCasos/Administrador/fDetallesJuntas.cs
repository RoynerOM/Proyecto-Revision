using Entidades;
using GestionCasos.Paginadores;
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
using GestionCasos.Singleton;

namespace GestionCasos.Administrador
{
    public partial class fDetallesJuntas : Form
    {
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        readonly ControllerService controller = new ControllerService();
        private int Rol = (int)Enums.Tipo.Tramitador;
        Paginador<tInstitucion> lista;
        PaginadorJuntas paginador = new PaginadorJuntas();
        int buscarPersona = 0;
        string personaJunta = null;
        int buscarCodigo = 0;

        public fDetallesJuntas(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
            tabla.EnableHeadersVisualStyles = false;
        }


        public async void PedirDatos(int PaginaSeleccionada = 1, string buscar = null, int codigo = 0)
        {
            try
            {
                if (!string.IsNullOrEmpty(buscar))
                {
                    lista = await paginador.PaginadorInst(PaginaSeleccionada, buscar, 0);
                }
                else if (codigo > 0)
                {
                    lista = await paginador.PaginadorInst(PaginaSeleccionada, null, codigo);
                }
                else
                {
                    lista = await paginador.PaginadorInst(PaginaSeleccionada, null, 0);
                }

                lblPag.Text = "Registros:   " + lista.TotalRegistros + "    Página  " + lista.PaginaActual + "  de  " + lista.TotalPaginas;
                CargarTabla(lista);
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

                gunaLabel1.ForeColor = Colors.Black;
                gunaLabel3.ForeColor = Colors.Black;
                gunaLabel4.ForeColor = Colors.Black;
                
                lblPag.ForeColor = Colors.Black;
                lblPag.BackColor = Color.Transparent;
            }
            TableStyle();
        }


        //Estilos de la tabla
        public void TableStyle()
        {

            if (isDark == "false")
            {
                tabla.BackgroundColor = Color.White;

                tabla.ColumnHeadersDefaultCellStyle.BackColor = Colors.Blue;
                tabla.ColumnHeadersDefaultCellStyle.ForeColor = Colors.White;

                tabla.RowHeadersDefaultCellStyle.BackColor = Colors.White;
                tabla.RowHeadersDefaultCellStyle.ForeColor = Colors.Black;

                tabla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                
                tabla.RowsDefaultCellStyle.BackColor = Colors.White;
                tabla.RowsDefaultCellStyle.ForeColor = Colors.Black;

                tabla.RowHeadersDefaultCellStyle.SelectionBackColor = Colors.Gray;
                tabla.RowHeadersDefaultCellStyle.SelectionForeColor = Colors.Black;

                tabla.RowsDefaultCellStyle.SelectionBackColor = Colors.Gray;
                tabla.RowsDefaultCellStyle.SelectionForeColor = Colors.Black;
            }
            else
            {
                tabla.BackgroundColor = Colors.DarkBack;
                tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colors.DarkPanel;
                tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = Colors.White;

                tabla.ColumnHeadersDefaultCellStyle.BackColor = Colors.DarkPanel;
                tabla.ColumnHeadersDefaultCellStyle.ForeColor = Colors.White;

                tabla.RowHeadersDefaultCellStyle.BackColor = Colors.DarkBack;
                tabla.RowHeadersDefaultCellStyle.ForeColor = Colors.White;

                tabla.RowsDefaultCellStyle.BackColor = Colors.DarkBack;
                tabla.RowsDefaultCellStyle.ForeColor = Colors.White;

                tabla.RowHeadersDefaultCellStyle.SelectionBackColor = Colors.DarkHover;
                tabla.RowHeadersDefaultCellStyle.SelectionForeColor = Colors.White;

                tabla.RowsDefaultCellStyle.SelectionBackColor = Colors.DarkHover;
                tabla.RowsDefaultCellStyle.SelectionForeColor = Colors.White;
            }

            //Informacion de cabecera
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font((string)"Segoe UI Semibold", 10);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersHeight = 40;
            //end

            //Estilos de filas
            tabla.DefaultCellStyle.Font = new Font((string)"Segoe UI Semibold", 9);
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.BorderStyle = BorderStyle.None;


            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToOrderColumns = true;
            tabla.ReadOnly = true;
            tabla.MultiSelect = false;
            tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            tabla.AllowUserToResizeColumns = false;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla.AllowUserToResizeRows = false;
            tabla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Row header estilos
            tabla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.RowHeadersVisible = false;
            tabla.RowsDefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }


        //Cargar la tabla de los datos de instituciones
        public void CargarTabla(Paginador<tInstitucion> lista)
        {
            try
            {
                tabla.Rows.Clear();
                foreach (var item in lista.Resultado)
                {
                    int nRows = tabla.Rows.Add();

                    tabla.Rows[nRows].Cells[0].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[1].Value = item.Circuito;
                    tabla.Rows[nRows].Cells[2].Value = item.tTipoInstitucion.NombreTipo;
                    tabla.Rows[nRows].Cells[3].Value = item.Nombre;
                    tabla.Rows[nRows].Cells[4].Value = item.CedulaJuridica;
                    tabla.Rows[nRows].Cells[5].Value = item.DiaRuta == null? "-": item.DiaRuta.ToUpper();
                    tabla.Rows[nRows].Cells[6].Value = item.CuentaLey;
                    tabla.Rows[nRows].Cells[7].Value = item.tPersona.NombreCompleto.ToUpper();
                    tabla.Rows[nRows].Cells[8].Value = item.Responsable.ToUpper();
                    tabla.Rows[nRows].Cells[9].Value = item.Contacto;
                    tabla.Rows[nRows].Cells[10].Value = item.TipoBanco != null? item.TipoBanco : "-";

                    tabla.Rows[nRows].Height = 40;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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


        //Cargar la lista de contadores
        public async void CargarCombos()
        {
            try
            {
                //Obtener solo los contadores
                cbTramitador.DataSource = await controller.CrudContador().obtenerTrabador(0);
                cbTramitador.ValueMember = "Cedula";
                cbTramitador.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            if (screenWidth <= 1280)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tabla.Columns[0].Width = 80;
                tabla.Columns[1].Width = 60;
                tabla.Columns[2].Width = 90;
                tabla.Columns[3].Width = 360;
                tabla.Columns[4].Width = 120;
                tabla.Columns[5].Width = 100;
                tabla.Columns[6].Width = 120;
                tabla.Columns[7].Width = 300;
                tabla.Columns[8].Width = 300;
                tabla.Columns[9].Width = 100;
            }
            else if (screenWidth > 1280 && screenWidth <= 1720)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                tabla.Columns[0].Width = 80;
                tabla.Columns[1].Width = 60;
                tabla.Columns[2].Width = 85;
                tabla.Columns[3].Width = 380;
                tabla.Columns[4].Width = 140;
                tabla.Columns[5].Width = 120;
                tabla.Columns[6].Width = 125;
                tabla.Columns[7].Width = 300;
                tabla.Columns[8].Width = 300;
                tabla.Columns[9].Width = 115;
            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabla.Columns[0].FillWeight = 80;
                tabla.Columns[1].FillWeight = 60;
                tabla.Columns[2].FillWeight = 90;
                tabla.Columns[3].FillWeight = 360;
                tabla.Columns[4].FillWeight = 120;
                tabla.Columns[5].FillWeight = 100;
                tabla.Columns[6].FillWeight = 120;
                tabla.Columns[7].FillWeight = 300;
                tabla.Columns[8].FillWeight = 300;
                tabla.Columns[9].FillWeight = 100;
            }
        }



        //Al seleccionar un trabajador busca las juntas relacionadas a el
        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                buscarPersona = 1;
                personaJunta = cbTramitador.SelectedValue.ToString();
                PedirDatos(1, cbTramitador.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        //Agregar un formulario a un control
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



        //Abrir los datos seleccionados al formulario de instituciones
        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    int fila = e.RowIndex;

                    int codigo = (int)tabla.Rows[fila].Cells[0].Value;

                    DatosTemp.tInstitucion = lista.Resultado.Where(x => x.Codigo == codigo).SingleOrDefault();

                    OpenChildForm(new fInstituciones(Rol));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        //Boton de reestablecer informacion de la tabla
        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            buscarPersona = 0;
            buscarCodigo = 0;
            btnNext.Enabled = true;
            button1.Enabled = true;
            txtCodigo.ResetText();
            PedirDatos(1, null);
        }



        //Boton de siguiente
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lista.PaginaActual < lista.TotalPaginas)
            {
                if (buscarPersona == 1)
                {
                    PedirDatos(lista.PaginaActual + 1, personaJunta);
                }
                else
                {
                    PedirDatos(lista.PaginaActual + 1);
                }
                button1.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }



        //Boton de Anterior
        private void button1_Click(object sender, EventArgs e)
        {
            if (lista.PaginaActual > 1)
            {
                if (buscarPersona == 1)
                {
                    PedirDatos(lista.PaginaActual - 1, personaJunta);
                }
                else
                {
                    PedirDatos(lista.PaginaActual - 1);
                }
                btnNext.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }



        //Al presionar una tecla buscar por codigo
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        buscarCodigo = int.Parse(txtCodigo.Text);
                        btnNext.Enabled = false;
                        button1.Enabled = false;
                        PedirDatos(1, null, buscarCodigo);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        //Al presionar una tecla busca por el nombre de la junta
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txtNombre.Text != string.Empty)
                    {
                        buscarPersona = 1;
                        personaJunta = txtNombre.Text.ToUpper();
                        PedirDatos(1, txtNombre.Text.ToUpper());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedirDatos(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PedirDatos(lista.TotalPaginas);
        }
    }
}
