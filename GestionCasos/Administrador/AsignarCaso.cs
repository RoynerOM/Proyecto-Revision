using Datos;
using Entidades;
using GestionCasos.Administrador;
using Negocios;
using System;
//using Utilidades.Enumerables;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos

{
    public partial class AsignarCaso : Form
    {

        RevisionNegocio Rnegocio = new RevisionNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        showMessageDialog Alerta = new showMessageDialog();
        private Form activeForm = null;
        tRevision casosReasignado = null;
        public AsignarCaso()
        {
            InitializeComponent();
            SetThemeColor();
            CargarCombos();
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
                    CargarCombos();

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
                revision.Observacion = "No tiene observación";
                revision.Estado = 2;
                revision.numeroActa = 0;
                revision.numeroFolio = 0;
                revision.fechaActa = null;

                if (Rnegocio.guardarAsync(revision) == true)
                {
                    Alerta.Success(new Alertas.Alerta(), "Caso asignado");
                    MostrarConsecutivo();
                    txtCodigo.ResetText();
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

            try
            {
                if (txtCaso.Text != string.Empty)
                {
                    this.casosReasignado = Rnegocio.ObtenerPorCaso(txtCaso.Text.ToUpper());
                    if (this.casosReasignado != null)
                    {
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

        private async void btnReasignarCaso_ClickAsync(object sender, EventArgs e)
        {

            btnGuardar.Enabled = true;
            try
            {
                tRecepcion t = new tRecepcion();
                tPersona tramitador = new tPersona();         
                tramitador = await persona.obtenerPorIdAsync(cbAsignados.SelectedValue.ToString());
                casosReasignado.Fecha = dtpFecha.Value;
                casosReasignado.Tramitador = tramitador.Cedula;
                casosReasignado.tPersona = tramitador;


                if (Rnegocio.modificar(casosReasignado) == true)
                {
                    Alerta.Success(new Alertas.Alerta(), "Caso reasignado a: " + cbAsignados.Text);
                    MostrarConsecutivo();
                    txtCodigo.ResetText();
                    txtCaso.ResetText();
                    btnReasignarCaso.Enabled = false;
                }
                else
                {
                    Alerta.Danger(new Alertas.Alerta(), "Error al reasignar caso");
                }

                btnReasignarCaso.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
