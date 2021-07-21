using Entidades;
using GestionCasos.Usuarios;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Utilidades;
using System.Threading;
using GestionCasos.Administrador;

namespace GestionCasos
{

    public partial class fCasosAdmin : Form
    {

        t_Revision revision = new t_Revision();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();

        List<t_Revision> Casos = null;
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];



        public fCasosAdmin()
        {
            InitializeComponent();
            SetThemeColor();

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

        public void PedirDatos()
        {
            Casos = (List<t_Revision>)revisionNegocio.obtenerTodo(revision);
            CargarTabla(Casos);
        }

        //Filtro por Estado
        public void FilterByEstate(string valor)
        {
            var filtro = Casos.Where(x => x.Estado1.TipoEstado == valor);
            CargarTabla(filtro);
        }


        //Filtro por Consecutivo
        public void FilterByConsecutivo(string consecutivo)
        {
            IEnumerable<t_Revision> filtro = revisionNegocio.obtenerPorConsecutivo(consecutivo);
            CargarTabla(filtro);
        }


        //Filtro por tramitador
        public void FilterByTramitador(string valor)
        {
            var filtro = revisionNegocio.obtenerPorContador(valor);
            if (filtro != null)
            {
                CargarTabla(filtro);
            }
        }


        //Filtro por Recepcion
        public void FilterByRecepcion(int valor)
        {
            var filtro = Casos.Where(x => x.Recepcion == valor);
            CargarTabla(filtro);
        }


        public void CargarTabla(IEnumerable<t_Revision> lista)
        {
            tabla.Rows.Clear();
            foreach (var item in lista)
            {
                int nRows = tabla.Rows.Add();
                tabla.Rows[nRows].Cells[0].Value = item.Consecutivo;
                tabla.Rows[nRows].Cells[1].Value = item.Fecha.ToShortDateString();
                tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                tabla.Rows[nRows].Cells[3].Value = item.t_Institucion.Nombre.ToUpper();
                tabla.Rows[nRows].Cells[4].Value = item.t_Institucion.Circuito;
                tabla.Rows[nRows].Cells[5].Value = item.t_Recepcion.Nombre.ToUpper();
                tabla.Rows[nRows].Cells[6].Value = item.t_Persona.Nombre_Completo.ToUpper();
                tabla.Rows[nRows].Cells[8].Value = item.Estado1.TipoEstado.ToUpper();

                tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 10);

                #region Codigo comentado
                /*if (item.Estado1.TipoEstado.ToUpper() == "PENDIENTE")
                {
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
                }*/
                #endregion


                if (item.Estado1.TipoEstado.ToUpper() == "TRAMITADO")
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
                else if (item.Estado1.TipoEstado.ToUpper() == "ENTREGADO")
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

        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;

            if (screenWidth >= 1200)
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
                        DatosTemp.t_Revision = Casos.Where(x => x.Consecutivo == consecutivo).SingleOrDefault();
                        fBoleta comentario = new fBoleta(1);
                        comentario.ShowDialog();

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



       

       public void CargarCombos()
        {
            //Tramitador
            cbTramitador.DataSource = persona.obtenerTodo(new t_Persona());
            cbTramitador.ValueMember = "Cedula";
            cbTramitador.DisplayMember = "Nombre_Completo";

            //Estado
            cbEstado.DataSource = estadoNegocio.obtenerTodo(new Estado());
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "TipoEstado";

            //Recepcion
            cbRecepcion.DataSource = recepcion.obtenerTodo(new t_Recepcion());
            cbRecepcion.ValueMember = "id";
            cbRecepcion.DisplayMember = "Nombre";
        }

        //Combo de Tramitador
        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByTramitador(cbTramitador.SelectedValue.ToString());
            cbTramitador.ResetText();
        }

        //Combo de Estado
        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbEstado.Text != string.Empty)
            {
                if (cbEstado.Text == "Todos")
                {
                    PedirDatos();
                }
                else
                {
                    string estado = cbEstado.Text;
                    FilterByEstate(estado);
                    cbEstado.ResetText();
                }
            }
        }

        //Filtro de recepcion
        private void cbRecepcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbRecepcion.Text != string.Empty)
            {
                FilterByRecepcion((int)cbRecepcion.SelectedValue);
                cbRecepcion.ResetText();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            if (txtConsecutivo.Text != string.Empty)
            {
                FilterByConsecutivo(txtConsecutivo.Text);
                cbEstado.ResetText();

            }
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    int fila = e.RowIndex;

            //    string consecutivo = tabla.Rows[fila].Cells[0].Value.ToString();
               

            //    t_Revision revisionDatos = Casos.Where(x => x.Consecutivo == consecutivo).SingleOrDefault();
            //    //Se pasan los datos
            //    PasarDatosEvent(revisionDatos);

            //    this.Close();

            //}
        }
    }
}
