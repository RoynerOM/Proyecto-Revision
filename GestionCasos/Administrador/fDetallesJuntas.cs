﻿using Entidades;
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

namespace GestionCasos.Administrador
{
    public partial class fDetallesJuntas : Form
    {
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        readonly InstitucionNegocio institucionNegocio = new InstitucionNegocio();
        readonly ContadorNegocio persona = new ContadorNegocio();
        List<tInstitucion> Instituciones = null;
        private int Rol = (int)Enums.Tipo.Tramitador;
        int cantidad = 10;
        int TotalPaginas = 0;
        int aux = 0;
        int refActual = 0;
        string person = null;
        public fDetallesJuntas(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
        }


        public async void PedirDatos(int PaginaSeleccionada=0, string cedula = null,string nombre= null,int codigo = 0)
        {
            try
            {
                if (cedula != null)
                {
                    Instituciones = await institucionNegocio.obtenerTodo();
                    Instituciones = Instituciones.Where(x => x.Contador == cedula).ToList();
                }
                else if(nombre != null)
                {
                    Instituciones = await institucionNegocio.obtenerTodo();
                    Instituciones = Instituciones.Where(x => x.Nombre == nombre.ToUpper()).ToList();
                }
                else if(codigo != 0)
                {
                    Instituciones = await institucionNegocio.obtenerTodo();
                    Instituciones = Instituciones.Where(x => x.Codigo == codigo).ToList();
                }
                else
                {
                    Instituciones = await institucionNegocio.obtenerTodo();
                }

                int TotalRegistros = Instituciones.Count();
                TotalPaginas = (int)
                    Math.Ceiling(decimal.Parse(TotalRegistros.ToString()) /
                                  decimal.Parse(cantidad.ToString()));

                lblPag.Text = "Total de Páginas: " + TotalPaginas.ToString();
                refActual = PaginaSeleccionada + 1;
                lblActual.Text = "Página Actual: " + (PaginaSeleccionada+1).ToString();

                //aux = TotalPaginas;
                CargarTabla(Instituciones.OrderBy(d => d.Codigo)
                     .Skip(PaginaSeleccionada * cantidad)
                     .Take(cantidad).ToList());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        ////Filtro por Contador
        //public void FilterByTramitador(string valor)
        //{
        //    try
        //    {
        //        var filtro = Instituciones.Where(x => x.Contador == valor);
        //        if (filtro != null)
        //        {
        //            CargarTabla(filtro);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}


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
                gunaLabel3.ForeColor = Colors.Black;
                gunaLabel4.ForeColor = Colors.Black;
                lblPag.ForeColor = Colors.Black;
                lblActual.ForeColor = Colors.Black;
            }
        }


        public void CargarTabla(List<tInstitucion> lista)
        {
            try
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
                    tabla.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    tabla.Rows[nRows].Cells[0].Value = item.Codigo;
                    tabla.Rows[nRows].Cells[1].Value = item.Circuito;
                    tabla.Rows[nRows].Cells[2].Value = item.tTipoInstitucion.NombreTipo;
                    tabla.Rows[nRows].Cells[3].Value = item.Nombre;
                    tabla.Rows[nRows].Cells[4].Value = item.CedulaJuridica;
                    tabla.Rows[nRows].Cells[5].Value = item.DiaRuta;
                    tabla.Rows[nRows].Cells[6].Value = item.CuentaLey;
                    tabla.Rows[nRows].Cells[7].Value = item.tPersona.NombreCompleto.ToUpper();
                    tabla.Rows[nRows].Cells[8].Value = item.Responsable.ToUpper();
                    tabla.Rows[nRows].Cells[9].Value = item.Contacto;

                    tabla.Rows[nRows].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[7].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tabla.Rows[nRows].Cells[9].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                    tabla.Rows[nRows].Cells[0].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[1].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[2].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[3].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[4].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[5].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[6].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[7].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[8].Style.Font = new Font((string)"Segoe UI Semibold", 9);
                    tabla.Rows[nRows].Cells[9].Style.Font = new Font((string)"Segoe UI Semibold", 9);
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


        public async void CargarCombos()
        {
            try
            {
                //Tramitador
                cbTramitador.DataSource = await persona.obtenerTodo();
                cbTramitador.ValueMember = "Cedula";
                cbTramitador.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        //txtNombre
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (txtNombre.Text != null)
                {
                    PedirDatos(aux, null, txtNombre.Text, 0);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
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


        private void panel1_Resize(object sender, EventArgs e)
        {
            var screenWidth = panel1.Width;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (screenWidth < 1440)
            {
                tabla.Columns[0].Width = 90;
                tabla.Columns[1].Width = 60;
                tabla.Columns[2].Width = 90;
                tabla.Columns[3].Width = 300;
                tabla.Columns[4].Width = 120;
                tabla.Columns[5].Width = 140;
                tabla.Columns[6].Width = 140;
                tabla.Columns[7].Width = 300;
                tabla.Columns[8].Width = 300;
                tabla.Columns[9].Width = 100;

            }
            else
            {
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        //private void txtCedulaJuridica_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtCodigo.Text.Length > 6)
        //        {
        //            var filtro = Instituciones.Where(x => x.Codigo == int.Parse(txtCodigo.Text));
        //            CargarTabla(filtro);
        //        }
        //        else
        //        {
        //            PedirDatos();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}


        //cbTramitador
        private void cbTramitador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PedirDatos(aux,cbTramitador.SelectedValue.ToString(),null,0);
                person = cbTramitador.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    int fila = e.RowIndex;

                    int codigo = (int)tabla.Rows[fila].Cells[0].Value;

                    DatosTemp.tInstitucion = Instituciones.Where(x => x.Codigo == codigo).SingleOrDefault();

                    OpenChildForm(new fInstituciones(Rol));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            TotalPaginas = 0;
            aux = 0;
            person = null;
            PedirDatos(aux,null,null,0);
            
        }

        //Boton de siguiente
        private void btnNext_Click(object sender, EventArgs e) {

            aux++;
            if (aux >= TotalPaginas)
            {
                aux = TotalPaginas;
            }
            else
            {
                if (txtCodigo.Text != string.Empty)
                {
                    PedirDatos(aux, null, null, 0);
                }
                else if (txtNombre.Text != string.Empty)
                {
                    PedirDatos(aux, null, txtNombre.Text.ToUpper());
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


        //Boton de Anterior
        private void button1_Click(object sender, EventArgs e)  
        {
            aux--;
            if (aux < 0)
            {
                aux = 0;
                
            }
            else
            {
                if (txtCodigo.Text != string.Empty)
                {
                    PedirDatos(aux, null,null,0);
                }else if (txtNombre.Text != string.Empty)
                {
                    PedirDatos(aux,null,txtNombre.Text.ToUpper(),0);
                }else if (person != null)
                {
                    PedirDatos(aux,cbTramitador.SelectedValue.ToString().ToUpper(),null,0);
                }
                else
                {
                    PedirDatos(aux);
                }
            }
            Console.WriteLine("Prev: " + aux);
            Console.WriteLine(TotalPaginas);
        }

        //Codigo
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                PedirDatos(0, null, null, int.Parse(txtCodigo.Text));
            }
        }
    }
}
