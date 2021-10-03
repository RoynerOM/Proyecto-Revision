using Entidades;
using GestionCasos.Administrador;
using GestionCasos.Alertas;
using GestionCasos.Usuarios;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using GestionCasos.Singleton;
using GestionCasos.Paginadores;

namespace GestionCasos
{

    public partial class fCasosAdmin : Form
    {
        readonly tRevision revision = new tRevision();
        readonly ControllerService controller = new ControllerService();
        readonly showMessageDialog Alerta = new showMessageDialog();
        Paginador<tRevision> lista;
        PaginadorCasos paginador = new PaginadorCasos();
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private bool entrega = false;

        int fecha = 0;
        int buscarPersona = 0;
        string personaJunta = null;
        int buscarCodigo = 0;


        public fCasosAdmin(bool entrega)
        {
            InitializeComponent();
            SetThemeColor();
            this.entrega = entrega;
        }


        private void FormStyle_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;

            OpenChildForm(new fLoader(1, hilo));
            PedirDatos();
            CargarCombos();
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



        public async void PedirDatos(int PaginaSeleccionada = 1, string buscar = null, int codigo = 0, string start = null, string end = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(buscar))
                {
                    lista = await paginador.PaginadorCaso(PaginaSeleccionada, buscar, 0);
                }
                else if (codigo > 0)
                {
                    lista = await paginador.PaginadorCaso(PaginaSeleccionada, null, codigo);
                }
                else if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
                {
                    lista = await paginador.PaginadorCaso(PaginaSeleccionada, null, 0, start, end);
                }
                else
                {
                    lista = await paginador.PaginadorCaso(PaginaSeleccionada, null, 0);
                }

                lblPag.Text = "Registros:   " + lista.TotalRegistros + "    Página  " + lista.PaginaActual + "  de  " + lista.TotalPaginas;
                CargarTabla(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public void TableStyle()
        {

            if (isDark == "false")
            {
                tabla.BackgroundColor = Color.White;

                tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colors.Blue;
                tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = Colors.White;

                tabla.ColumnHeadersDefaultCellStyle.BackColor = Colors.Blue;
                tabla.ColumnHeadersDefaultCellStyle.ForeColor = Colors.White;

                tabla.RowHeadersDefaultCellStyle.BackColor = Colors.White;
                tabla.RowHeadersDefaultCellStyle.ForeColor = Colors.Black;

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

            tabla.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            tabla.RowsDefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            this.Comentario.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        public void CargarTabla(Paginador<tRevision> lista)
        {
            try
            {
                tabla.Rows.Clear();
                foreach (var item in lista.Resultado)
                {
                    int nRows = tabla.Rows.Add();

                    tabla.Rows[nRows].Cells[0].Value = item.Consecutivo;
                    tabla.Rows[nRows].Cells[1].Value = item.Fecha.ToShortDateString();
                    tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[3].Value = item.tInstitucion.Nombre.ToUpper();
                    tabla.Rows[nRows].Cells[4].Value = item.tInstitucion.Circuito;
                    tabla.Rows[nRows].Cells[5].Value = item.tRecepcion.Recepcion.ToUpper();
                    tabla.Rows[nRows].Cells[6].Value = item.tPersona.NombreCompleto.ToUpper();
                    tabla.Rows[nRows].Cells[8].Value = item.tEstado.Estado.ToUpper();

                    tabla.Rows[nRows].Height = 40;

                    tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 8);



                    if (item.tEstado.Estado.ToUpper() == "EN REVISIÓN")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.RedFont;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.RedBack;

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Colors.RedFont;
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Colors.RedBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.RedFontDark;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.RedBackDark;

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Colors.RedFontDark;
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Colors.RedBackDark;
                        }
                    }
                    else if (item.tEstado.Estado.ToUpper() == "POR ENTREGAR")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.GreenFont;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.GreenBack;

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Colors.GreenFont;
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Colors.GreenBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Color.FromArgb(46, 160, 67);
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Color.FromArgb(11, 38, 40);
                        }
                    }
                    else if (item.tEstado.Estado.ToUpper() == "ENTREGADO")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 75, 160);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(168, 209, 255);

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Color.FromArgb(0, 75, 160);
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Color.FromArgb(168, 209, 255);
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 120, 255);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(0, 45, 96);

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Color.FromArgb(0, 120, 255);
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Color.FromArgb(0, 45, 96);
                        }
                    }
                    else
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.OrangeFont;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.OrangeBack;

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Colors.OrangeFont;
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Colors.OrangeBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.OrangeFontDark;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.OrangeBackDark;

                            tabla.Rows[nRows].Cells[8].Style.SelectionForeColor = Colors.OrangeFontDark;
                            tabla.Rows[nRows].Cells[8].Style.SelectionBackColor = Colors.OrangeBackDark;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            Console.WriteLine(panel1.Width + " x " + panel1.Height);
            if (screenWidth <= 1280)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tabla.Columns[0].Width = 90;
                tabla.Columns[1].Width = 100;
                tabla.Columns[2].Width = 55;
                tabla.Columns[3].Width = 360;
                tabla.Columns[4].Width = 60;
                tabla.Columns[5].Width = 85;
                tabla.Columns[6].Width = 220;
                tabla.Columns[7].Width = 120;
                tabla.Columns[8].Width = 115;
            }
            else if (screenWidth > 1280 && screenWidth <= 1400)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                tabla.Columns[0].Width = 95;
                tabla.Columns[1].Width = 100;
                tabla.Columns[2].Width = 55;
                tabla.Columns[3].Width = 360;
                tabla.Columns[4].Width = 60;
                tabla.Columns[5].Width = 90;
                tabla.Columns[6].Width = 300;
                tabla.Columns[7].Width = 120;
                tabla.Columns[8].Width = 115;
            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabla.Columns[0].FillWeight = 95;
                tabla.Columns[1].FillWeight = 105;
                tabla.Columns[2].FillWeight = 70;
                tabla.Columns[3].FillWeight = 320;
                tabla.Columns[4].FillWeight = 55;
                tabla.Columns[5].FillWeight = 100;
                tabla.Columns[6].FillWeight = 300;
                tabla.Columns[7].FillWeight = 120;
                tabla.Columns[8].FillWeight = 115;
            }
        }


        private void tabla_Resize(object sender, EventArgs e)
        {
            //var Grid = (DataGridView)sender;

            //var width = tabla.Width;

            //if (width <= 1300)
            //{
            //    Grid.RowsDefaultCellStyle.Font = new Font(Name, 8);
            //}
            //else
            //{
            //    Grid.RowsDefaultCellStyle.Font = new Font(Name, 9);
            //}
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
                gunaLabel5.ForeColor = Colors.Black;
                gunaLabel6.ForeColor = Colors.Black;
                lblPag.ForeColor = Colors.Black;
            }
            TableStyle();
        }


        private void tabla_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Codigo a evaluar
                //Convertir el objeto en un dataGrid
                var Grid = (DataGridView)sender;
                //Se evalua si la celda seleccionada es de tipo boton
                if (Grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (e.RowIndex != -1)
                    {
                        string consecutivo = tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (entrega == false)
                        {
                            OpenChildForm(new fBoleta(consecutivo));
                        }
                        else
                        {
                            tRevision r = controller.CrudCaso().ObtenerPorCaso(consecutivo);
                            if (r.Estado >= 3)
                            {
                                //tEntregaCasos entregaCasos = await controller.CrudEntrega().obtenerPorCasoAsync(consecutivo);
                                
                                OpenChildForm(new fEntrega(consecutivo));
                            }
                            else
                            {
                                Alerta.Danger(new Alerta(), "Documento no tramitado. No se puede cargar la información de entrega, porque el documento no ha sido revisado");
                            }
                        }
                    }
                }
            }
            //Control de la excepcio
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public async void CargarCombos()
        {
            try
            {
                //Tramitador
                cbTramitador.DataSource = await controller.CrudContador().obtenerTodo();
                cbTramitador.ValueMember = "Cedula";
                cbTramitador.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        #region Filtros de lso datos
        //Filtro de Tramitador
        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    PedirDatos(aux, cbTramitador.SelectedValue.ToString(), 0, 0);
            //    person = cbTramitador.SelectedValue.ToString();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
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
        #endregion


        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            fecha = 0;
            txtConsecutivo.ResetText();
            buscarPersona = 0;
            buscarCodigo = 0;
            btnNext.Enabled = true;
            button1.Enabled = true;
            txtCodigo.ResetText();
            PedirDatos(1, null);
        }


        //Pagina siguiente
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lista.PaginaActual < lista.TotalPaginas)
            {
                if (buscarPersona == 1)
                {
                    PedirDatos(lista.PaginaActual + 1, personaJunta);
                }
                else if (fecha == 1)
                {
                    DateTime START = dtDesde.Value;
                    DateTime END = dtHasta.Value;

                    PedirDatos(lista.PaginaActual + 1, null, 0, START.ToShortDateString(), END.ToShortDateString());
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


        //Pagina anterior
        private void button1_Click(object sender, EventArgs e)
        {
            if (lista.PaginaActual > 1)
            {
                if (buscarPersona == 1)
                {
                    PedirDatos(lista.PaginaActual - 1, personaJunta);
                }
                else if (fecha == 1)
                {
                    DateTime START = dtDesde.Value;
                    DateTime END = dtHasta.Value;

                    PedirDatos(lista.PaginaActual - 1, null, 0, START.ToShortDateString(), END.ToShortDateString());
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



        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txtConsecutivo.Text != string.Empty)
                    {
                        //var casos = await controller.CrudCaso().obtenerTodo();
                        //if (casos != string.Empty)
                        //{

                        //}
                        buscarPersona = 1;
                        personaJunta = txtConsecutivo.Text.ToUpper();
                        PedirDatos(1, txtConsecutivo.Text.ToUpper());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    buscarCodigo = int.Parse(txtCodigo.Text);
                    btnNext.Enabled = false;
                    button1.Enabled = false;
                    PedirDatos(1, null, buscarCodigo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fecha = 1;
            DateTime START = dtDesde.Value;
            DateTime END = dtHasta.Value;

            PedirDatos(1, null, 0, START.ToShortDateString(), END.ToShortDateString());
        }
    }
}
