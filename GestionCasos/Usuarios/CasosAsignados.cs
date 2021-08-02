using Entidades;
using GestionCasos.Administrador;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Usuarios
{
    public partial class CasosAsignados : Form
    {
        private string Cedula = null;
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private bool entrega = false;
        tRevision revision = new tRevision();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        EntregaNegocio entregaNegocio = new EntregaNegocio();
        IEnumerable<tRevision> Casos = null;
        showMessageDialog Alerta = new showMessageDialog();
        //Datos de prueba

        public CasosAsignados(bool entrega)
        {
            InitializeComponent();
            //Obtenemos la cedula desde un archivo de texto
            Cedula = File.ReadAllText("temp.txt");
            SetThemeColor();
            this.entrega = entrega;
        }


        private void CasosAsignados_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
            PedirDatos();
            CargarCombos();
        }


        public void PedirDatos()
        {
            try
            {
                //Cargarmos la tabla con los datos relacionado a la cedula de la persona actual
                Casos = revisionNegocio.obtenerTodo(revision).Where(x => x.Tramitador == Cedula);
                DatosTemp.MultiUser = false;
                CargarTabla(Casos);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        public void PedirDatos(int i = 0)
        {
            try
            {
                //Cargarmos la tabla con los datos relacionado a la cedula de la persona actual
                CargarTabla(revisionNegocio.obtenerTodo(revision));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        #region Funciones usados en el datagrid


        public void CargarTabla(IEnumerable<tRevision> lista)
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

                tabla.Rows[nRows].Cells[0].Value = item.Consecutivo;
                tabla.Rows[nRows].Cells[1].Value = item.Fecha.ToShortDateString();
                tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                tabla.Rows[nRows].Cells[3].Value = item.tInstitucion.Nombre.ToUpper();
                tabla.Rows[nRows].Cells[4].Value = item.tInstitucion.Circuito;
                tabla.Rows[nRows].Cells[5].Value = item.tRecepcion.Recepcion.ToUpper();
                tabla.Rows[nRows].Cells[6].Value = item.tPersona.NombreCompleto.ToUpper();
                tabla.Rows[nRows].Cells[8].Value = item.tEstado.Estado.ToUpper();

                tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[3].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[4].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[5].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[6].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[7].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 9);


                if (item.tEstado.Estado.ToUpper() == "PENDIENTE" || item.tEstado.Estado.ToUpper() == "EN REVISIÓN")
                {
                    tabla.Rows[nRows].Cells[8].Value = "PENDIENTE";
                    if (isDark == "false")
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Colors.RedFont;
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Colors.RedBack;
                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(248, 81, 73);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(50, 24, 32);
                    }
                }
                else if (item.tEstado.Estado.ToUpper() == "TRAMITADO")
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
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 75, 160);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(168, 209, 255);

                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(0, 120, 255);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(0, 45, 96);
                    }
                }
            }

        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            //lblScreen.Text = screenWidth.ToString();
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
                Grid.RowsDefaultCellStyle.Font = new Font(Name, 10);
            }
        }


        #endregion


        private void CargarCombos()
        {

            try
            {
                //Tramitador
                cbTramitador.DataSource = persona.obtenerTodo(new tPersona());
                cbTramitador.ValueMember = "Cedula";
                cbTramitador.DisplayMember = "NombreCompleto";

                //Estado
                cbEstado.DataSource = estadoNegocio.obtenerTodo(new tEstado());
                cbEstado.ValueMember = "id";
                cbEstado.DisplayMember = "TipoEstado";

                //Recepcion
                cbRecepcion.DataSource = recepcion.obtenerTodo(new tRecepcion());
                cbRecepcion.ValueMember = "id";
                cbRecepcion.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void SetThemeColor()
        {
            if (isDark == "false")
            {

                this.panel1.BackColor = Colors.White;
                this.panel1.ForeColor = Colors.Black;
                this.panel2.BackColor = Colors.White;
                this.panel2.ForeColor = Colors.Black;

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
            }
            else
            {

            }
        }


        #region Funciones para filtros

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbEstado.Text != string.Empty)
                {
                    if ((int)cbEstado.SelectedValue == 6)
                    {
                        if (DatosTemp.MultiUser == true)
                        {
                            PedirDatos(0);
                        }
                        else
                        {
                            PedirDatos();
                        }
                    }
                    else
                    {
                        var filtro = revisionNegocio.FilterBy((int)cbEstado.SelectedValue).Where(x => x.Tramitador == Cedula);
                        if (filtro != null)
                            CargarTabla(filtro);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void cbRecepcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbRecepcion.Text != string.Empty)
                {
                    var filtro = revisionNegocio.FilterBy((int)cbRecepcion.SelectedValue, 0).Where(x => x.Tramitador == Cedula);
                    if (filtro != null)
                        CargarTabla(filtro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void txtConsecutivo_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtConsecutivo.Text != string.Empty)
                {
                    var filtro = revisionNegocio.obtenerPorConsecutivo(txtConsecutivo.Text).Where(x => x.Tramitador == Cedula);
                    if (filtro != null)
                        CargarTabla(filtro);
                }
                else
                    PedirDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var filtro = revisionNegocio.obtenerPorContador(cbTramitador.SelectedValue.ToString());
                if (filtro != null)
                    CargarTabla(filtro);
                DatosTemp.MultiUser = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion


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

        private void tabla_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                            fBoleta comentario = new fBoleta(0, consecutivo);
                            comentario.ShowDialog();
                        }
                        else
                        {
                            tRevision r = revisionNegocio.ObtenerPorCaso(consecutivo);
                            if (r.Estado > 3)
                            {
                                tEntregaCasos entregaCasos = entregaNegocio.obtenerPorCaso(consecutivo);
                                fEntrega entrega = new fEntrega(entregaCasos, consecutivo);
                                entrega.ShowDialog();
                            }
                            else
                            {
                                Alerta.Danger(new Alertas.Alerta(), "Documento no tramitado. No se puede cargar la información de entrega, porque el documento no ha sido revisado");
                            }

                        }
                    }
                }
            }
            //Control de la excepcio
            catch (Exception ex)
            {
                var error = ex.Data;
                MessageBox.Show(error.ToString());
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            PedirDatos();
        }
    }
}
