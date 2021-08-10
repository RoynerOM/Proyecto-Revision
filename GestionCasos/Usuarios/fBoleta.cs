using Entidades;
using Negocios;
using System;
using System.Configuration;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class fBoleta : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private int TipoUsuario = 0;
        private int isNew = 0;
        private string consecutivo = null;

        readonly tBoleta boleta = new tBoleta();
        tRevision revision = new tRevision();
        readonly BoletaNegocio boletaNegocio = new BoletaNegocio();
        readonly RevisionNegocio revisionNegocio = new RevisionNegocio();
        readonly EstadoNegocio estadoNegocio = new EstadoNegocio();
        readonly showMessageDialog Alert = new showMessageDialog();
        readonly EntregaNegocio entregaNegocio = new EntregaNegocio();

        public fBoleta(int tipo, string consecutivo)
        {
            InitializeComponent();
            TipoUsuario = tipo;
            this.consecutivo = consecutivo;
        }

        //Cambio de color
        private void SetThemeColor()
        {
            if (isDark == "false")
            {

                this.BackColor = Colors.White;
                this.ForeColor = Colors.Black;
                this.gunaLinePanel1.BackColor = Colors.White;
                cbMotivo1.ForeColor = Colors.Black;
                cbMotivo2.ForeColor = Colors.Black;
                cbMotivo3.ForeColor = Colors.Black;
                cbMotivo4.ForeColor = Colors.Black;
                cbMotivo5.ForeColor = Colors.Black;
                cbMotivo6.ForeColor = Colors.Black;
                cbMotivo7.ForeColor = Colors.Black;
                cbMotivo8.ForeColor = Colors.Black;
                lblConsecutivo.ForeColor = Colors.Black;
                label1.ForeColor = Colors.Black;
                label2.ForeColor = Colors.Black;
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
            }
        }



        private void fBoleta_Load(object sender, EventArgs e)
        {
            SetThemeColor();
            dtpFechaActa.Value = DateTime.Now;
            lblConsecutivo.Text = consecutivo;
            txtOtros.Visible = false;
            btnEntrega.Enabled = false;
            btnBoleta.Enabled = false;

            //if (TipoUsuario == 0)
            //{

            //    txtObservacion.Enabled = false;
            //    txtComentario.Enabled = true;
            //}
            //else
            //{
            //    txtObservacion.Enabled = true;
            //    txtComentario.Enabled = false;
            //}
            CargarDatosForm();
        }



        private void cbMotivo8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMotivo8.Checked == true)
            {
                txtOtros.Visible = true;
            }
            else
            {
                txtOtros.Visible = false;
                txtOtros.ResetText();
            }
        }



        private void LabelColorChange()
        {
            if (txtOtros.Visible == true && txtOtros.Text == string.Empty)
            {
                cbMotivo8.ForeColor = Colors.RedFont;
            }
            if (txtFolio.Text == string.Empty)
            {
                label3.ForeColor = Colors.RedFont;
            }
            if (txtNumeroActa.Text == string.Empty)
            {
                label2.ForeColor = Colors.RedFont;
            }
        }



        private bool ValidarCampos()
        {
            LabelColorChange();
            if (txtOtros.Visible == true && txtOtros.Text == string.Empty)
            {
                cbMotivo8.ForeColor = Colors.RedFont;
                return false;
            }
            else if (txtFolio.Text == string.Empty)
            {
                label3.ForeColor = Colors.RedFont;
                return false;
            }
            else if (txtNumeroActa.Text == string.Empty)
            {
                label2.ForeColor = Colors.RedFont;
                return false;
            }
            else
            {
                return true;
            }
        }



        private void CargarDatosForm()
        {
            try
            {
                //Obtengo el caso
                revision = revisionNegocio.ObtenerPorCaso(consecutivo);
                var filtro = boletaNegocio.obtenerPorId(revision.IdCaso);

                if (filtro != null)
                {
                    btnBoleta.Enabled = true;

                    //Informacion del caso folio...
                    txtNumeroActa.Text = revision.numeroActa.ToString();
                    txtFolio.Text = revision.numeroFolio.ToString();
                    dtpFechaActa.Value = (DateTime)revision.fechaActa;

                    cbMotivo1.Checked = (bool)filtro.Motivo1;
                    cbMotivo2.Checked = (bool)filtro.Motivo2;
                    cbMotivo3.Checked = (bool)filtro.Motivo3;
                    cbMotivo4.Checked = (bool)filtro.Motivo4;
                    cbMotivo5.Checked = (bool)filtro.Motivo5;
                    cbMotivo6.Checked = (bool)filtro.Motivo6;
                    cbMotivo7.Checked = (bool)filtro.Motivo7;

                    //Carga de otros
                    if (filtro.Motivo8 != "")
                    {
                        cbMotivo8.Checked = true;
                        txtOtros.Visible = true;
                        txtOtros.Text = filtro.Motivo8;
                    }
                    txtObservacion.Text = filtro.Observacion;
                    txtComentario.Text = revision.Comentario;


                    if (revision.Estado == 4)
                    {
                        btnEntrega.Enabled = false;
                    }
                    else
                    {
                        btnEntrega.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        //Guardar Observacion
        private void btnObservacion_Click(object sender, EventArgs e)
        {
            try
            {
                tBoleta boleta = new tBoleta();
                boleta = boletaNegocio.obtenerPorId(consecutivo);
                var caso = revisionNegocio.ObtenerPorCaso(consecutivo);
                if (boleta != null)
                {
                    boleta.IdCaso = caso.IdCaso;
                    boleta.Motivo1 = cbMotivo1.Checked;
                    boleta.Motivo2 = cbMotivo2.Checked;
                    boleta.Motivo3 = cbMotivo3.Checked;
                    boleta.Motivo4 = cbMotivo4.Checked;
                    boleta.Motivo5 = cbMotivo5.Checked;
                    boleta.Motivo6 = cbMotivo6.Checked;
                    boleta.Motivo7 = cbMotivo7.Checked;

                    if (cbMotivo8.Checked == true)
                    {
                        boleta.Motivo8 = txtOtros.Text;
                    }


                    boleta.Observacion = txtObservacion.Text;
                    caso.Comentario = txtComentario.Text;
                    caso.Observacion = txtObservacion.Text;

                    if (revisionNegocio.modificar(caso) == true)
                    {
                        if (boletaNegocio.modificar(boleta) == true)
                        {
                            Alert.Success(new Alertas.Alerta(), "Observación Modificada con exito");
                        }
                        else
                        {
                            Alert.Danger(new Alertas.Alerta(), "No se pudo modificar la observación");
                        }
                    }
                }
                else
                {
                    if (ValidarCampos() == true)
                    {
                        //Buscar el caso por consecutivo
                        tBoleta newBoleta = new tBoleta();

                        newBoleta.IdCaso = revision.IdCaso;
                        newBoleta.Motivo1 = cbMotivo1.Checked;
                        newBoleta.Motivo2 = cbMotivo2.Checked;
                        newBoleta.Motivo3 = cbMotivo3.Checked;
                        newBoleta.Motivo4 = cbMotivo4.Checked;
                        newBoleta.Motivo5 = cbMotivo5.Checked;
                        newBoleta.Motivo6 = cbMotivo6.Checked;
                        newBoleta.Motivo7 = cbMotivo7.Checked;

                        if (cbMotivo8.Checked == true)
                        {
                            newBoleta.Motivo8 = txtOtros.Text;
                        }
                        else
                        {
                            newBoleta.Motivo8 = "";
                        }

                        //Observacion
                        newBoleta.Observacion = txtObservacion.Text;

                        newBoleta.FechaCreado = DateTime.Now;
                        //Fin de informacion de boleta

                        //Cambio de estado de boleta
                        tEstado state = new tEstado();
                        state.IdEstado = 3;
                        //Informacion del caso
                        //tRevision filtroCasos = revisionNegocio.ObtenerPorCaso(consecutivo);
                        state = estadoNegocio.obtenerPorId(state);
                        //Fin de obtener la informacion del estado

                        revision.FechaRevisada = DateTime.Now.ToShortDateString();
                        revision.Estado = state.IdEstado;
                        revision.tEstado = state;
                        revision.numeroActa = int.Parse(txtNumeroActa.Text);
                        revision.numeroFolio = int.Parse(txtFolio.Text);
                        revision.fechaActa = dtpFechaActa.Value;

                        revision.Comentario = txtComentario.Text;
                        revision.Observacion = txtObservacion.Text;


                        //Se actualiza la informacion del caso pasa hacer tramitador
                        if (revisionNegocio.modificar(revision) == true)
                        {
                            //Alert.Success(new Alertas.Alerta(), "Revision Modificada con exito");

                            if (isNew == 0)
                            {
                                if (boletaNegocio.guardarAsync(newBoleta) == true)
                                {
                                    Alert.Success(new Alertas.Alerta(), "Observacion Agregada con exito");
                                    btnBoleta.Enabled = true;
                                    btnEntrega.Enabled = true;
                                }
                                else
                                {
                                    Alert.Danger(new Alertas.Alerta(), "No se pudo guardar la observacion");
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void btnBoleta_Click(object sender, EventArgs e)
        {
            fReporteBoleta v = new fReporteBoleta(consecutivo);
            v.WindowState = FormWindowState.Maximized;
            v.ShowDialog();
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                tEstado state = new tEstado();
                state.IdEstado = 4;

                state = estadoNegocio.obtenerPorId(state);
                revision.Estado = state.IdEstado;
                revision.tEstado = state;

                if (revisionNegocio.modificar(revision) == true)
                {
                    Alert.Success(new Alertas.Alerta(), "Observación fue modificada");
                    btnEntrega.Enabled = false;
                }
                else
                {
                    Alert.Danger(new Alertas.Alerta(), "No se pudo modifcada la observación");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }



        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
