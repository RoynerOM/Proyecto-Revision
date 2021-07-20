using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Transitions;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class CasosAsignados : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private string Cedula = null;
        private Form activeForm = null;
        t_Revision revision = new t_Revision();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        IEnumerable<t_Revision> Casos = null;
        //Datos de prueba

        public CasosAsignados()
        {
            InitializeComponent();
            //Obtenemos la cedula desde un archivo de texto
            Cedula = File.ReadAllText("temp.txt");
        }


        public void PedirDatos()
        {
            //Cargarmos la tabla con los datos relacionado a la cedula de la persona actual
            Casos = revisionNegocio.obtenerTodo(revision).Where(x => x.Tramitador == "5-0435-0765");
            CargarTabla(Casos);
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
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 10);

                if (item.Estado1.TipoEstado.ToUpper() == "PENDIENTE" || item.Estado1.TipoEstado.ToUpper() == "EN REVISION")
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
                else if (item.Estado1.TipoEstado.ToUpper() == "TRAMITADO")
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
            if (screenWidth >= 990)
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {

                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }



        private void CasosAsignados_Load(object sender, EventArgs e)
        {
            PedirDatos();
            SetThemeColor();
            CargarCombos();
        }


        void CargarCombos()
        {

            //Estado
            cbEstado.DataSource = estadoNegocio.obtenerTodo(new Estado());
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "TipoEstado";

            //Recepcion
            cbRecepcion.DataSource = recepcion.obtenerTodo(new t_Recepcion());
            cbRecepcion.ValueMember = "id";
            cbRecepcion.DisplayMember = "Nombre";
        }


        //Filtro por Consecutivo
        public void FilterByConsecutivo(string consecutivo)
        {
            IEnumerable<t_Revision> filtro = revisionNegocio.obtenerPorConsecutivo(consecutivo).Where(x=> x.Tramitador == "5-0435-0765");
            CargarTabla(filtro);
        }


        //Filtro por Estado
        public void FilterByEstate(string valor)
        {
            var filtro = Casos.Where(x => x.Estado1.TipoEstado == valor);
            CargarTabla(filtro);
        }


        //Filtro por Recepcion
        public void FilterByRecepcion(int valor)
        {
            var filtro = Casos.Where(x => x.Recepcion == valor);
            CargarTabla(filtro);
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
            }
            else
            {

            }
        }


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


        private void cbRecepcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbRecepcion.Text != string.Empty)
            {
                FilterByRecepcion((int)cbRecepcion.SelectedValue);
                cbRecepcion.ResetText();
            }
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        DatosTemp.t_Revision = Casos.Where(x => x.Consecutivo == consecutivo).SingleOrDefault();
                        fBoleta comentario = new fBoleta(0);
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
    }
}
