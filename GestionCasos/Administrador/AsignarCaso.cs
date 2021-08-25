using Datos;
using Entidades;
using GestionCasos.Administrador;
using Negocios;
using System;
using System.Collections.Generic;
//using Utilidades.Enumerables;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos

{

    public partial class AsignarCaso : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=192.168.100.76;Initial Catalog=BDJuntas;User ID=sa;Password=123456;");
        RevisionNegocio Rnegocio = new RevisionNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        showMessageDialog Alerta = new showMessageDialog();
        private Form activeForm = null;
        tRevision casosReasignado = null;
        int codigoAux = 0;//validar si el codigo se reasignara
        string contadorAux = null;


        public AsignarCaso()
        {
            InitializeComponent();
            SetThemeColor();
        }

        //Modificado
        private async void CargarCombos()
        {
            try
            {
                cbAsignados.DataSource = await persona.obtenerTodo();
                cbAsignados.DisplayMember = "NombreCompleto";
                cbAsignados.ValueMember = "Cedula";

                //Modificado
                cbTipoRecepcion.DataSource = await recepcion.obtenerTodo();
                cbTipoRecepcion.ValueMember = "id";
                cbTipoRecepcion.DisplayMember = "Recepcion";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        //private void CargarCombosAux()
        //{
        //    List<ListaAux> lista = new List<ListaAux>
        //    {
        //        new ListaAux{id = 1, nombre = "-"}

        //    };

        //    cbTipoRecepcion.DataSource = lista;
        //    cbTipoRecepcion.ValueMember = "id";
        //    cbTipoRecepcion.DisplayMember = "nombre";


        //    cbAsignados.DataSource = lista;
        //    cbAsignados.ValueMember = "id";
        //    cbAsignados.DisplayMember = "nombre";


        //}

        //Modificado
        private void MostrarConsecutivo()
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {
                    var id = context.tRevision.Max(x => x.IdCaso) + 1;
                    string cons = "R-" + id.ToString();
                    txtConsecutivo.Text = cons;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AsignarCaso_Load(object sender, EventArgs e)
        {
            this.dtpFecha.Value = DateTime.Now;
            this.btnReasignarCaso.Enabled = false;
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
            //Actualizar();
            MostrarConsecutivo();
            CargarCombos();

        }

        //Cambio de colores
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                this.BackColor = Colors.White;
                this.panel1.BackColor = Colors.White;
                this.panel2.BackColor = Colors.Blue;

                lbConsecutivo.ForeColor = Colors.DarkBack;
                lbCodigo.ForeColor = Colors.DarkBack;
                lbCircuiton.ForeColor = Colors.DarkBack;
                lbFecha.ForeColor = Colors.DarkBack;
                lbJunta.ForeColor = Colors.DarkBack;
                lbMedioReceptivo.ForeColor = Colors.DarkBack;
                lbAsignado.ForeColor = Colors.DarkBack;
                label1.ForeColor = Colors.Black;
            }
        }


        private void AsignarCaso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    using (var context = new BDJuntasEntities())
                    {
                        if (txtCodigo.Text != string.Empty)
                        {
                            int cod = int.Parse(txtCodigo.Text);

                            var codigo = context.tInstitucion.FirstOrDefault(x => x.Codigo == cod);

                            if (codigo != null)
                            {
                                txtJuntaAdm.Text = codigo.Nombre;
                                txtCircuito.Text = codigo.Circuito.ToString();
                                //CargarCombos();
                                
                            }
                            else
                            {
                                Alerta.Danger(new Alertas.Alerta(), $"El código {txtCodigo.Text} no existe");
                            }
                        }
                        else
                        {
                            Alerta.Danger(new Alertas.Alerta(), $"Falta llenar el código");
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }

        //Metodo de guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tRevision revision = new tRevision();

                revision.Codigo = int.Parse(txtCodigo.Text);
                revision.Fecha = dtpFecha.Value;
                revision.Tramitador = cbAsignados.SelectedValue.ToString();
                revision.Recepcion = (int)cbTipoRecepcion.SelectedValue;
                revision.Comentario = "No tiene comentario";
                revision.Estado = 1;
                revision.numeroActa = "";
                revision.numeroFolio = "";
                revision.fechaActa = null;

                if (Rnegocio.guardarAsync(revision) == true)
                {
                    Alerta.Success(new Alertas.Alerta(), "Caso asignado");
                    MostrarConsecutivo();
                    limpiarCampos();
                    //CargarCombosAux();
                }
                else
                {
                    Alerta.Danger(new Alertas.Alerta(), "Error al asignar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void limpiarCampos()
        {
            txtCodigo.ResetText();
            txtCircuito.Clear();
            txtJuntaAdm.Clear();
            txtCaso.Clear();
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

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {

            btnGuardar.Enabled = false;
            txtConsecutivo.Visible = false;
            lbConsecutivo.Visible = false;
            //CargarCombos();

            try
            {
                if (txtCaso.Text != string.Empty)
                {
                    this.casosReasignado = Rnegocio.ObtenerPorCaso(txtCaso.Text.ToUpper());
                    if (this.casosReasignado != null)
                    {
                        codigoAux = casosReasignado.Codigo;
                        contadorAux = casosReasignado.Tramitador;
                        btnReasignarCaso.Enabled = true;
                        txtCodigo.Text = casosReasignado.tInstitucion.Codigo.ToString();
                        txtJuntaAdm.Text = casosReasignado.tInstitucion.Nombre;
                        txtCircuito.Text = casosReasignado.tInstitucion.Circuito.ToString();
                        cbTipoRecepcion.Text = casosReasignado.tRecepcion.Recepcion;
                        cbAsignados.Text = casosReasignado.tPersona.NombreCompleto;
                        this.btnReasignarCaso.Enabled = true;
                    }
                    else
                    {
                        Alerta.Danger(new Alertas.Alerta(), "El caso ingresado no existe. Favor ingrese uno válido");
                    }
                }
                else
                {
                    Alerta.Danger(new Alertas.Alerta(), "Debe ingresar un caso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnReasignarCaso_ClickAsync(object sender, EventArgs e)
        {

            btnGuardar.Enabled = true;
            try
            {
                int flag = 0;
                string reasignar = "Update tRevision set Tramitador = '" + cbAsignados.SelectedValue.ToString() +"', Codigo = "+ int.Parse(txtCodigo.Text) + "  where Consecutivo = '"+ txtCaso.Text.ToUpper() + "'";
                SqlCommand cmd = new SqlCommand(reasignar ,conexion);
                conexion.Open();
                flag = cmd.ExecuteNonQuery();

                if (flag == 1)
                {
                    conexion.Close();
                    if (codigoAux == int.Parse(txtCodigo.Text))
                    {
                        Alerta.Success(new Alertas.Alerta(), "Caso reasignado a: " + cbAsignados.Text);


                    }
                    else if (codigoAux != int.Parse(txtCodigo.Text))
                    {
                        Alerta.Success(new Alertas.Alerta(), "Caso reasignado a la institución: " + txtCodigo.Text);
                        if (contadorAux == cbAsignados.SelectedValue.ToString())
                        {
                            Alerta.Success(new Alertas.Alerta(), "Caso reasignado a: " + cbAsignados.Text);
                        }
                    }
                    else
                    {
                        Alerta.Success(new Alertas.Alerta(), "Caso reasignado");
                    }

                    MostrarConsecutivo();
                    limpiarCampos();
                    txtConsecutivo.Visible = true;
                    lbConsecutivo.Visible = true;
                    btnReasignarCaso.Enabled = false;
                }
                else if (flag == 0)
                {
                    Alerta.Danger(new Alertas.Alerta(), "Error al reasignar caso");
                    conexion.Close();

                }
                else
                {
                    btnReasignarCaso.Enabled = false;
                }

                #region CodigoEntyty

                //tRecepcion t = new tRecepcion();
                //tPersona tramitador = new tPersona();         
                //tramitador = await persona.obtenerPorIdAsync(cbAsignados.SelectedValue.ToString());
                //casosReasignado.Fecha = dtpFecha.Value;
                //casosReasignado.Tramitador = tramitador.Cedula;
                //casosReasignado.tPersona = tramitador;


                //if (Rnegocio.modificar(casosReasignado) == true)
                //{
                //    Alerta.Success(new Alertas.Alerta(), "Caso reasignado a: " + cbAsignados.Text);
                //    MostrarConsecutivo();
                //    limpiarCampos();
                //    CargarCombosAux();
                //    txtConsecutivo.Visible = true;
                //    lbConsecutivo.Visible = true;
                //    btnReasignarCaso.Enabled = false;
                //}
                //else
                //{
                //    Alerta.Danger(new Alertas.Alerta(), "Error al reasignar caso");
                //    txtConsecutivo.Visible = true;
                //    lbConsecutivo.Visible = true;
                //    limpiarCampos();
                //    CargarCombosAux();
                //}

                # endregion

                btnReasignarCaso.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtCaso_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnGuardar.Enabled = false;
            txtConsecutivo.Visible = false;
            lbConsecutivo.Visible = false;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCaso.Text != string.Empty)
                    {
                        this.casosReasignado = Rnegocio.ObtenerPorCaso(txtCaso.Text.ToUpper());
                        if (this.casosReasignado != null)
                        {
                            codigoAux = casosReasignado.Codigo;
                            contadorAux = casosReasignado.Tramitador;
                            btnReasignarCaso.Enabled = true;
                            txtCodigo.Text = casosReasignado.tInstitucion.Codigo.ToString();
                            txtJuntaAdm.Text = casosReasignado.tInstitucion.Nombre;
                            txtCircuito.Text = casosReasignado.tInstitucion.Circuito.ToString();
                            cbTipoRecepcion.Text = casosReasignado.tRecepcion.Recepcion;
                            cbAsignados.Text = casosReasignado.tPersona.NombreCompleto;
                            this.btnReasignarCaso.Enabled = true;
                        }
                        else
                        {
                            Alerta.Danger(new Alertas.Alerta(), "El caso ingresado no existe. Favor ingrese uno válido");
                        }
                    }
                    else
                    {
                        Alerta.Danger(new Alertas.Alerta(), "Debe ingresar un caso");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        
        private void cbAsignados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            contadorAux = cbAsignados.SelectedValue.ToString();
        }
    }
}
