using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Transitions;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class CasosAsignados : Form
    {
        Form enUso = null;
        int ventanasAbiertas = 0;
        string isDark = ConfigurationManager.AppSettings["DarkMode"];
        t_Revision revision = new t_Revision();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        ContadorNegocio persona = new ContadorNegocio();

        RevisionNegocio revisionNegocio = new RevisionNegocio();
        //Datos de prueba

        public CasosAsignados()
        {
            InitializeComponent();
        }
       public void PedirDatos()
        {
           var lista = revisionNegocio.obtenerTodo(revision);
            CargarTabla(lista);
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
                tabla.Rows[nRows].Cells[5].Value = item.Recepcion;
                tabla.Rows[nRows].Cells[6].Value = item.t_Persona.Nombre_Completo.ToUpper();
                tabla.Rows[nRows].Cells[8].Value = item.Estado1.TipoEstado.ToUpper();

                tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 10);
                if (item.Estado1.TipoEstado.ToUpper() == "PENDIENTE")
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
                    Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
                    AgregarComentario ventana = new AgregarComentario();

                    t.add(ventana, "Top", 300);
                    t.run();
                    ventana.StartPosition = FormStartPosition.CenterScreen;
                    ventana.ShowDialog();
                }

            }
            //Control de la excepcion
            catch (Exception ex)
            {
                var error = ex.Data;
                MessageBox.Show(error.ToString());
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
            cbTramitador.DataSource = persona.obtenerTodo(new t_Persona());
            cbTramitador.ValueMember = "Cedula";
            cbTramitador.DisplayMember = "Nombre_Completo";

            //Estado
            cbEstado.DataSource = estadoNegocio.obtenerTodo(new Estado());
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "TipoEstado";
        }
        private void tabla_Resize(object sender, EventArgs e)
        {





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
    }
}
