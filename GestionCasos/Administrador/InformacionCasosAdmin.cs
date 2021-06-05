using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace GestionCasos
{
    public partial class InformacionCasosAdmin : Form
    {
        //Datos de prueba
        List<CasosFalsos> casos = new List<CasosFalsos>() { 
        new CasosFalsos(){ Caso="R-0001",Fecha="2020/02/10",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Correo Electronico",Persona="JOSUE JARA ESCOBAR",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0002",Fecha="2021/02/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Whatsapp",Persona="BAYRON HERNÁNDEZ DÍAZ",Comentario="No tiene comentario",Estado= true},
        new CasosFalsos(){ Caso="R-0003",Fecha="2021/04/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Oficina",Persona="ALONSO CASTILLO LEDEZMA",Comentario="Documentos incompletos y mal estructurado",Estado= true},
        new CasosFalsos(){ Caso="R-0004",Fecha="2021/01/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Mensajero",Persona="YEIMY BARRANTES ARTAVIA",Comentario="Todos los documentos revisados",Estado= true},
        new CasosFalsos(){ Caso="R-0005",Fecha="2020/02/10",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Correo Electronico",Persona="JENIFFER ARROYO CAJINA",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0006",Fecha="2021/02/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Whatsapp",Persona="SHIRLENY VEGA ESPINOZA",Comentario="No tiene comentario",Estado= false},
        new CasosFalsos(){ Caso="R-0007",Fecha="2021/04/05",Codigo=01,Junta="Teodoro picado institucion o junta",Circuito=01,Recepcion="Oficina",Persona="GLORIANNA ACEVEDO LEDEZMA",Comentario="Documentos incompletos y mal estructurado",Estado= true},
        };


        public InformacionCasosAdmin()
        {
            InitializeComponent();
            
        }

        #region Filtrar por nombre
        private void FiltroPorNombre(string persona)
        {
            tabla.Rows.Clear();
            foreach (var item in casos)
            {
                
                if (item.Persona == persona)
                {
                    int nRows = tabla.Rows.Add();
                    tabla.Rows[nRows].Cells[0].Value = item.Caso;
                    tabla.Rows[nRows].Cells[1].Value = item.Fecha;
                    tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[3].Value = item.Junta;
                    tabla.Rows[nRows].Cells[4].Value = item.Circuito;
                    tabla.Rows[nRows].Cells[5].Value = item.Recepcion;
                    tabla.Rows[nRows].Cells[6].Value = item.Persona;
                    tabla.Rows[nRows].Cells[8].Value = item.Estado == false ? "Pendiente" : "Revisado";

                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (item.Estado == false)
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(248, 81, 73);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(50, 24, 32);
                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);
                    }
                }

                
            }

        }
        #endregion


        #region Filtrar por estado
        private void FiltroPorEstado(bool estado)
        {
            tabla.Rows.Clear();
            foreach (var item in casos)
            {

                if (item.Estado == estado)
                {
                    int nRows = tabla.Rows.Add();
                    tabla.Rows[nRows].Cells[0].Value = item.Caso;
                    tabla.Rows[nRows].Cells[1].Value = item.Fecha;
                    tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[3].Value = item.Junta;
                    tabla.Rows[nRows].Cells[4].Value = item.Circuito;
                    tabla.Rows[nRows].Cells[5].Value = item.Recepcion;
                    tabla.Rows[nRows].Cells[6].Value = item.Persona;
                    tabla.Rows[nRows].Cells[8].Value = item.Estado == false ? "Pendiente" : "Revisado";

                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (item.Estado == false)
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(248, 81, 73);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(50, 24, 32);
                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);
                    }
                }


            }

        }
        #endregion


        #region Filtrar por Recepcion
        private void FiltroPorRecepcion(string recepcion)
        {
            tabla.Rows.Clear();
            foreach (var item in casos)
            {

                if (item.Recepcion == recepcion)
                {
                    int nRows = tabla.Rows.Add();
                    tabla.Rows[nRows].Cells[0].Value = item.Caso;
                    tabla.Rows[nRows].Cells[1].Value = item.Fecha;
                    tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[3].Value = item.Junta;
                    tabla.Rows[nRows].Cells[4].Value = item.Circuito;
                    tabla.Rows[nRows].Cells[5].Value = item.Recepcion;
                    tabla.Rows[nRows].Cells[6].Value = item.Persona;
                    tabla.Rows[nRows].Cells[8].Value = item.Estado == false ? "Pendiente" : "Revisado";

                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (item.Estado == false)
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(248, 81, 73);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(50, 24, 32);
                    }
                    else
                    {
                        tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                        tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);
                    }
                }


            }

        }
        #endregion

        private void FormStyle_Load(object sender, EventArgs e)
        {
           PintarTatjetas();
        }

        private void PintarTatjetas()
        {
            tabla.Rows.Clear();
            foreach (var item in casos)
            {
                int nRows = tabla.Rows.Add();
                tabla.Rows[nRows].Cells[0].Value = item.Caso;
                tabla.Rows[nRows].Cells[1].Value = item.Fecha;
                tabla.Rows[nRows].Cells[2].Value = item.Codigo;
                tabla.Rows[nRows].Cells[3].Value = item.Junta.ToUpper();
                tabla.Rows[nRows].Cells[4].Value = item.Circuito;
                tabla.Rows[nRows].Cells[5].Value = item.Recepcion;
                tabla.Rows[nRows].Cells[6].Value = item.Persona;
                tabla.Rows[nRows].Cells[8].Value = item.Estado == false ? "Pendiente" : "Revisado";

                tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
                
                if (item.Estado == false)
                {
                    tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(248, 81, 73);
                    tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(50, 24, 32);
                }
                else
                {
                    tabla.Rows[nRows].Cells[8].Style.ForeColor = Color.FromArgb(46, 160, 67);
                    tabla.Rows[nRows].Cells[8].Style.BackColor = Color.FromArgb(11, 38, 40);
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

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Codigo a evaluar
                //Convertir el objeto en un dataGrid
                var Grid = (DataGridView)sender;
                //Se evalua si la celda seleccionada es de tipo boton
                if (Grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0)
                {
                    MessageBox.Show(casos[e.RowIndex].Comentario);
                }
            }
            //Control de la excepcio
            catch (Exception ex)
            {
                var error = ex.Data;
                MessageBox.Show(error.ToString());
            }
        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox3.Text != string.Empty)
            {
                FiltroPorNombre(gunaComboBox3.Text.Trim());
                gunaComboBox3.ResetText();
            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox2.Text != string.Empty)
            {
                FiltroPorRecepcion(gunaComboBox2.Text.Trim());
                gunaComboBox2.ResetText();
            }
        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (gunaComboBox1.Text != string.Empty)
            {
                if(gunaComboBox1.Text == "Todos")
                {
                    PintarTatjetas();
                }
                else
                {
                    bool estado = gunaComboBox1.Text == "Revisado" ? true : false;
                    FiltroPorEstado(estado);
                    gunaComboBox1.ResetText();
                }
            }
        }

        private void tabla_Resize(object sender, EventArgs e)
        {
            var Grid = (DataGridView)sender;


            var width = tabla.Width;

            if (width <=1300)
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
