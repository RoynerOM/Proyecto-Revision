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
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        //Datos de prueba
        List<CasosFalsos> casos = new List<CasosFalsos>() {
        new CasosFalsos(){ Caso="R-0001",Fecha="2020/02/10",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Correo Electronico",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= "Pendiente"},
        new CasosFalsos(){ Caso="R-0002",Fecha="2021/02/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Whatsapp",Persona="BAYRON HERNÁNDEZ DÍAZ",Comentario="No tiene comentario",Estado= "Tramitado"},
        new CasosFalsos(){ Caso="R-0003",Fecha="2021/04/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Oficina",Persona="ALONSO CASTILLO LEDEZMA",Comentario="Documentos incompletos y mal estructurado",Estado= "En Revision"},
        new CasosFalsos(){ Caso="R-0004",Fecha="2021/01/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Mensajero",Persona="YEIMY BARRANTES ARTAVIA",Comentario="Todos los documentos revisados",Estado= "Tramitado"},
        new CasosFalsos(){ Caso="R-0005",Fecha="2020/02/10",Codigo=0100000,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Correo Electronico",Persona="JENIFFER ARROYO CAJINA",Comentario="No tiene comentario",Estado= "En revision"},
        };

        public CasosAsignados()
        {
            InitializeComponent();
        }

        private void PintarTatjetas()
        {
            tabla.Rows.Clear();
            foreach (var item in casos)
            {
                int nRows = tabla.Rows.Add();
                tabla.Rows[nRows].Cells[0].Value = item.Caso;
                tabla.Rows[nRows].Cells[1].Value = item.Fecha;
                tabla.Rows[nRows].Cells[2].Value = item.Junta.ToUpper();
                tabla.Rows[nRows].Cells[3].Value = item.Recepcion.ToUpper();
                tabla.Rows[nRows].Cells[4].Value = item.Comentario;
                tabla.Rows[nRows].Cells[5].Value = item.Estado.ToUpper();

                if (item.Estado.ToUpper() == "PENDIENTE")
                {
                    if (isDark == "false")
                    {
                        tabla.Rows[nRows].Cells[5].Style.ForeColor = Colors.RedFont;
                        tabla.Rows[nRows].Cells[5].Style.BackColor = Colors.RedBack;
                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[5].Style.ForeColor = Color.FromArgb(248, 81, 73);
                        tabla.Rows[nRows].Cells[5].Style.BackColor = Color.FromArgb(50, 24, 32);
                    }
                }
                else if (item.Estado.ToUpper() == "TRAMITADO")
                {
                    if (isDark == "false")
                    {
                        tabla.Rows[nRows].Cells[5].Style.ForeColor = Colors.GreenFont;
                        tabla.Rows[nRows].Cells[5].Style.BackColor = Colors.GreenBack;
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (isDark == "false")
                    {
                        tabla.Rows[nRows].Cells[5].Style.ForeColor = Colors.OrangeFont;
                        tabla.Rows[nRows].Cells[5].Style.BackColor = Colors.OrangeBack;
                    }
                    else
                    {

                    }
                }

                tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            PintarTatjetas();
            SetThemeColor();
        }
        void CargarCombos()
        {
            cbTramitador.DataSource = estadoNegocio.obtenerTodo(new Estado());
            cbTramitador.ValueMember = "id";
            cbTramitador.DisplayMember = "TipoEstado";
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
