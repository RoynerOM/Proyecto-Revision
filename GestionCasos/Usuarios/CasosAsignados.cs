using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
namespace GestionCasos.Usuarios
{
    public partial class CasosAsignados : Form
    {
        Form enUso = null;
        int ventanasAbiertas = 0;

        //Datos de prueba
        List<CasosFalsos> casos = new List<CasosFalsos>() {
        new CasosFalsos(){ Caso="R-0001",Fecha="2020/02/10",Junta="Teodoro picado institucion o junta",Recepcion="Correo Electronico",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0002",Fecha="2021/02/05",Junta="Teodoro picado institucion o junta",Recepcion="Whatsapp",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= true},
        new CasosFalsos(){ Caso="R-0003",Fecha="2021/04/05",Junta="Teodoro picado institucion o junta",Recepcion="Oficina",Persona="JOSUE JARA ESCOBAR",Comentario="Documentos incompletos y mal estructurado",Estado= true},
        new CasosFalsos(){ Caso="R-0004",Fecha="2021/01/05",Junta="Teodoro picado institucion o junta",Recepcion="Mensajero",Persona="JOSUE JARA ESCOBAR",Comentario="Todos los documentos revisados",Estado= true},
        new CasosFalsos(){ Caso="R-0005",Fecha="2020/02/10",Junta="Teodoro picado institucion o junta",Recepcion="Correo Electronico",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0005",Fecha="2020/02/10",Junta="Teodoro picado institucion o junta",Recepcion="Correo Electronico",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0006",Fecha="2021/02/05",Junta="Teodoro picado institucion o junta",Recepcion="Whatsapp",Persona="SHIRLENY VEGA ESPINOZA",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0007",Fecha="2021/04/05",Junta="Teodoro picado institucion o junta",Recepcion="Oficina",Persona="GLORIANNA ACEVEDO LEDEZMA",Comentario="Documentos incompletos y mal estructurado",Estado= true},
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
                tabla.Rows[nRows].Cells[5].Value = item.Estado == false ? "Pendiente".ToUpper() : "Revisado".ToUpper();

                if (item.Estado == false)
                {
                    tabla.Rows[nRows].Cells[5].Style.ForeColor = Color.FromArgb(248, 81, 73);
                    tabla.Rows[nRows].Cells[5].Style.BackColor = Color.FromArgb(50, 24, 32);
                }
                else
                {
                    tabla.Rows[nRows].Cells[5].Style.ForeColor = Color.FromArgb(46, 160, 67);
                    tabla.Rows[nRows].Cells[5].Style.BackColor = Color.FromArgb(11, 38, 40);
                }
            }

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            if (screenWidth >= 855)
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


                    //Verificar de que un formulario este en uso
                    if (VentanasAbiertas.Form != null)
                    {
                        MessageBox.Show("Este formulario ya esta en uso");
                    }
                    else
                    {
                        t.add(ventana, "Top", 300);
                        t.run();
                        ventana.StartPosition = FormStartPosition.CenterScreen;
                        ventana.Show();
                    }

                    //Abrir el formulario para agregar un comentario
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
        }

        private void tabla_Resize(object sender, EventArgs e)
        {





        }
    }
}
