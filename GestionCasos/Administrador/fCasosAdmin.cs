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
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos
{

    public partial class fCasosAdmin : Form
    {

        tRevision revision = new tRevision();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        EntregaNegocio entregaNegocio = new EntregaNegocio();
        showMessageDialog Alerta = new showMessageDialog();
        IEnumerable<tRevision> Casos = null;
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private bool entrega = false;

        int cantidad = 5;
        int TotalPaginas = 0;
        int aux = 0;
        string person = null;
        int medio = 0;
        int es = 0;
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


        public void PedirDatos(int PaginaSeleccionada = 0, string tramitador = null, string caso = null, int estado = 0, int recepcion = 0)
        {
            try
            {
                if (tramitador != null)
                {
                    Casos = revisionNegocio.obtenerTodo(new tRevision()).Where(x => x.Tramitador == tramitador).ToList();
                }
                else if (caso != null)
                {
                    Casos = revisionNegocio.obtenerTodo(new tRevision()).Where(x => x.Consecutivo == caso.ToUpper()).ToList();
                }
                else if (estado != 0)
                {
                    Casos = revisionNegocio.obtenerTodo(new tRevision()).Where(x => x.Estado == estado).ToList();
                }
                else if (recepcion != 0)
                {
                    Casos = revisionNegocio.obtenerTodo(new tRevision()).Where(x => x.Recepcion == recepcion).ToList();
                }
                else
                {
                    Casos = revisionNegocio.obtenerTodo(new tRevision());
                }

                int TotalRegistros = Casos.Count();
                TotalPaginas = (int)
                    Math.Ceiling(decimal.Parse(TotalRegistros.ToString()) /
                                  decimal.Parse(cantidad.ToString()));

                lblPag.Text = "Total de Páginas: " + TotalPaginas.ToString();
                lblActual.Text = "Página Actual: " + (PaginaSeleccionada + 1).ToString();

                //aux = TotalPaginas;
                CargarTabla(Casos.OrderBy(d => d.Consecutivo)
                     .Skip(PaginaSeleccionada * cantidad)
                     .Take(cantidad).ToList());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }


        public void CargarTabla(IEnumerable<tRevision> lista)
        {
            try
            {
                tabla.Columns[3].HeaderText = "Junta";
                tabla.Rows.Clear();
                foreach (var item in lista)
                {
                    int nRows = tabla.Rows.Add();

                    #region Cabecera de la tabla
                    tabla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    #endregion


                    tabla.Rows[nRows].Cells[0].Value = item.Consecutivo;
                    tabla.Rows[nRows].Cells[1].Value = item.Fecha.ToShortDateString();
                    tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[3].Value = item.tInstitucion.Nombre.ToUpper();
                    tabla.Rows[nRows].Cells[4].Value = item.tInstitucion.Circuito;
                    tabla.Rows[nRows].Cells[5].Value = item.tRecepcion.Recepcion.ToUpper();
                    tabla.Rows[nRows].Cells[6].Value = item.tPersona.NombreCompleto.ToUpper();
                    tabla.Rows[nRows].Cells[8].Value = item.tEstado.Estado.ToUpper();


                    #region Centrado de texto de las celdas
                    tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    #endregion


                    #region Tipo de fuente de las tabla
                    tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[3].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[4].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[5].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[6].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[7].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    #endregion



                    if (item.tEstado.Estado.ToUpper() == "TRAMITADO")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.GreenFont;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.GreenBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);
                        }
                    }
                    else if (item.tEstado.Estado.ToUpper() == "ENTREGADO")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 75, 160);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(168, 209, 255);
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 120, 255);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(0, 45, 96);
                        }
                    }
                    else if (item.tEstado.Estado.ToUpper() == "POR ENTREGAR")
                    {
                        if (isDark == "false")
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.PurpleFore;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.PurpleBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.PurpleBack;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.PurpleBack2;
                        }
                    }
                    else
                    {
                        if (isDark == "false")
                        {

                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.OrangeFont;
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.OrangeBack;
                        }
                        else
                        {
                            tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(227, 179, 65);
                            tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(66, 56, 34);
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
            if (screenWidth <= 1200)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                tabla.Columns[0].Width = 90;
                tabla.Columns[1].Width = 100;
                tabla.Columns[2].Width = 80;
                tabla.Columns[3].Width = 200;
                tabla.Columns[4].Width = 70;
                tabla.Columns[5].Width = 100;
                tabla.Columns[6].Width = 220;
                tabla.Columns[7].Width = 120;
                tabla.Columns[8].Width = 100;
            }
            else if (screenWidth > 200 && screenWidth <= 1250)
            {
                tabla.Columns[0].Width = 95;
                tabla.Columns[1].Width = 105;
                tabla.Columns[2].Width = 80;
                tabla.Columns[3].Width = 230;
                tabla.Columns[4].Width = 70;
                tabla.Columns[5].Width = 105;
                tabla.Columns[6].Width = 240;
                tabla.Columns[7].Width = 120;
                tabla.Columns[8].Width = 105;
            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                Grid.RowsDefaultCellStyle.Font = new Font(Name, 9);
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
                gunaLabel2.ForeColor = Colors.Black;
                gunaLabel3.ForeColor = Colors.Black;
                gunaLabel4.ForeColor = Colors.Black;
                lblPag.ForeColor = Colors.Black;
                lblActual.ForeColor = Colors.Black;
            }
            else
            {

            }
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            fBoleta comentario = new fBoleta(1, consecutivo);
                            comentario.ShowDialog();
                        }
                        else
                        {
                            tRevision r = revisionNegocio.ObtenerPorCaso(consecutivo);
                            if (r.Estado >= 3)
                            {
                                tEntregaCasos entregaCasos = entregaNegocio.obtenerPorCaso(consecutivo);
                                fEntrega entrega = new fEntrega(entregaCasos, consecutivo);
                                entrega.ShowDialog();
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


        public void CargarCombos()
        {
            try
            {
                //Tramitador
                cbTramitador.DataSource = persona.obtenerTodo(new tPersona());
                cbTramitador.ValueMember = "Cedula";
                cbTramitador.DisplayMember = "NombreCompleto";

                //Estado
                cbEstado.DataSource = estadoNegocio.obtenerTodo(new tEstado());
                cbEstado.ValueMember = "IdEstado";
                cbEstado.DisplayMember = "Estado".ToUpper();

                //Recepcion
                cbRecepcion.DataSource = recepcion.obtenerTodo(new tRecepcion());
                cbRecepcion.ValueMember = "id";
                cbRecepcion.DisplayMember = "Recepcion".ToUpper();
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
            try
            {
                PedirDatos(aux, cbTramitador.SelectedValue.ToString(), null, 0);
                person = cbTramitador.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Combo de Estado
        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PedirDatos(aux, null, null, (int)cbEstado.SelectedValue, 0);
                es = (int)cbEstado.SelectedValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //Filtro de recepcion
        private void cbRecepcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PedirDatos(aux, null, null, 0, (int)cbRecepcion.SelectedValue);
                medio = (int)cbRecepcion.SelectedValue;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //Filtro por consecutivo
        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtConsecutivo.Text != string.Empty)
                {
                    PedirDatos(aux, null, txtConsecutivo.Text.ToUpper(), 0, 0);
                }
                else
                {
                    PedirDatos();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
        #endregion


        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    int fila = e.RowIndex;

            //    string consecutivo = tabla.Rows[fila].Cells[0].Value.ToString();


            //    tRevision revisionDatos = Casos.Where(x => x.Consecutivo == consecutivo).SingleOrDefault();
            //    //Se pasan los datos
            //    PasarDatosEvent(revisionDatos);

            //    this.Close();

            //}
        }


        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            TotalPaginas = 0;
            aux = 0;
            person = null;
            PedirDatos(aux,null,null,0,0);
            
        }

        private void tabla_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            aux++;
            if (aux >= TotalPaginas)
            {
                aux = TotalPaginas;
            }
            else
            {
                if (txtConsecutivo.Text != string.Empty)
                {
                    PedirDatos(aux, null, txtConsecutivo.Text.ToUpper(), 0, 0);
                }
                else if (medio != 0)
                {
                    PedirDatos(aux, null, null, 0, (int)cbRecepcion.SelectedValue);
                }
                else if (es != 0)
                {
                    PedirDatos(aux, null, null, (int)cbEstado.SelectedValue, 0);
                }
                else if (person != null)
                {
                    PedirDatos(aux, cbTramitador.SelectedValue.ToString().ToUpper());
                }
                else
                {
                    PedirDatos(aux);
                }
            }

            Console.WriteLine("Next: " + aux);
            Console.WriteLine(TotalPaginas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux--;
            if (aux < 0)
            {
                aux = 0;
            }
            else
            {
                if (txtConsecutivo.Text != string.Empty)
                {
                    PedirDatos(aux, null, txtConsecutivo.Text.ToUpper(), 0, 0);
                }
                else if (medio != 0)
                {
                    PedirDatos(aux, null, null, 0, (int)cbRecepcion.SelectedValue);
                }
                else if (es != 0)
                {
                    PedirDatos(aux, null, null, (int)cbEstado.SelectedValue, 0);
                }
                else if (person != null)
                {
                    PedirDatos(aux, cbTramitador.SelectedValue.ToString().ToUpper());
                }
                else
                {
                    PedirDatos(aux);
                }
            }
            Console.WriteLine("Prev: " + aux);
            Console.WriteLine(TotalPaginas);
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txtConsecutivo.Text != null)
                    {
                        PedirDatos(aux, null, txtConsecutivo.Text.ToUpper(), 0, 0);
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
