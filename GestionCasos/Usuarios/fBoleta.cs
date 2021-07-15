using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using GestionCasos.Administrador;
using Negocios;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class fBoleta : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private int TipoUsuario = 0;
        t_Boleta boleta = new t_Boleta();
        t_Revision revision = new t_Revision();
        BoletaNegocio boletaNegocio = new BoletaNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        private int isNew = 0;
        showMessageDialog Alert = new showMessageDialog();
        public fBoleta(int tipo)
        {
            InitializeComponent();
            TipoUsuario = tipo;
            DatosTemp.t_Boleta = null;
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
            else
            {

            }
        }

        private void fBoleta_Load(object sender, EventArgs e)
        {
            SetThemeColor();

            txtOtros.Visible = false;

            revision = DatosTemp.t_Revision;
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

        bool ValidarCampos()
        {
            if (txtOtros.Visible == true && txtOtros.Text == string.Empty)
            {
                cbMotivo8.ForeColor = Colors.RedFont;
                return false;
            }
            else if (txtObservacion.Text == string.Empty)
            {
                guna2GroupBox2.ForeColor = Colors.RedFont;
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
                if (revision != null)
                {
                    isNew = 0;
                    lblConsecutivo.Text = revision.Consecutivo;
                    var caso = revisionNegocio.obtenerPorConsecutivo(revision.Consecutivo).Where(x => x.Consecutivo == revision.Consecutivo).SingleOrDefault();

                    var boletas = boletaNegocio.obtenerTodo(new t_Boleta());

                    var filtro = boletas.Where(x => x.Nu_caso == caso.Id_Caso).SingleOrDefault();

                    if (filtro != null)
                    {
                        boleta = filtro;
                        isNew = 1;
                        cbMotivo1.Checked = (bool)filtro.Motivo1;
                        cbMotivo2.Checked = (bool)filtro.Motivo2;
                        cbMotivo3.Checked = (bool)filtro.Motivo3;
                        cbMotivo4.Checked = (bool)filtro.Motivo4;
                        cbMotivo5.Checked = (bool)filtro.Motivo5;
                        cbMotivo6.Checked = (bool)filtro.Motivo6;
                        cbMotivo7.Checked = (bool)filtro.Motivo7;

                        if (filtro.Motivo8 != "Ninguno")
                        {
                            cbMotivo8.Checked = true;
                            txtOtros.Visible = true;
                            txtOtros.Text = filtro.Motivo8;
                        }
                        if (TipoUsuario == 0)
                        {
                            txtObservacion.Text = revision.Comentario;
                        }
                        else
                        {
                            txtObservacion.Text = revision.Observacion;
                        }
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

                if (ValidarCampos() == true)
                {
                    //Buscar el caso por consecutivo


                    boleta.Nu_caso = revision.Id_Caso;
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
                    else
                    {
                        boleta.Motivo8 = "Ninguno";
                    }
                    boleta.Observacion = txtObservacion.Text;
                    boleta.Revisado_Por = revision.Tramitador;

                    if (TipoUsuario == 0 && txtObservacion.Text != string.Empty)
                    {
                        revision.Comentario = txtObservacion.Text;
                    }
                    else
                    {
                        revision.Observacion = txtObservacion.Text;
                    }

                    Estado state = new Estado();
                    state.id = 2;

                    t_Revision filtroCasos = revisionNegocio.obtenerPorConsecutivo(revision.Consecutivo).SingleOrDefault();
                    Estado filtroEstado = estadoNegocio.obtenerPorId(state);

                    filtroCasos.FechaRevisada = DateTime.Now.ToShortDateString();
                    filtroCasos.Estado = 2;
                    filtroCasos.Estado1 = filtroEstado;
                    //filtroCasos.Acta = int.Parse(txtNumeroActa.Text);
                    //filtroCasos.Folio = int.Parse(txtFolio.Text);
                    //filtroCasos.fechaActa = dtpFechaActa.Value.ToShortDateString();
                    if (revisionNegocio.modificar(filtroCasos) == true)
                    {
                        //Alert.Success(new Alertas.Alerta(), "Revision Modificada con exito");

                        if (isNew == 0)
                        {
                            if (boletaNegocio.guardar(boleta) == true)
                            {
                                Alert.Success(new Alertas.Alerta(), "Observacion Agregada con exito");
                                DatosTemp.t_Boleta = null;

                            }
                            else
                            {
                                Alert.Danger(new Alertas.Alerta(), "No se pudo guardar la observacion");
                            }
                        }
                        else
                        {
                            t_Boleta filtroBoleta = boletaNegocio.obtenerPorId(boleta);

                            filtroBoleta.Motivo1 = cbMotivo1.Checked;
                            filtroBoleta.Motivo2 = cbMotivo2.Checked;
                            filtroBoleta.Motivo3 = cbMotivo3.Checked;
                            filtroBoleta.Motivo4 = cbMotivo4.Checked;
                            filtroBoleta.Motivo5 = cbMotivo5.Checked;
                            filtroBoleta.Motivo6 = cbMotivo6.Checked;
                            filtroBoleta.Motivo7 = cbMotivo7.Checked;

                            if (cbMotivo8.Checked == true)
                            {
                                filtroBoleta.Motivo8 = txtOtros.Text;
                            }
                            else
                            {
                                filtroBoleta.Motivo8 = "Ninguno";
                            }
                            filtroBoleta.Observacion = txtObservacion.Text;
                            filtroBoleta.Revisado_Por = revision.Tramitador;


                            if (boletaNegocio.modificar(filtroBoleta) == true)
                            {
                                Alert.Success(new Alertas.Alerta(), "Observacion Agregada con exito");
                                DatosTemp.t_Boleta = null;

                            }
                            else
                            {
                                Alert.Danger(new Alertas.Alerta(), "No se pudo guardar la observacion");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }


        //Llamar al formulario de entrega
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                /*fEntrega entrega;
                // var consulta = entregaNegocio.obtenerPorConsecutivo(lblConsecutivo.Text);
                if (consulta != null)
                {
                    entrega = new fEntrega(consulta.Id);
                }
                else
                {
                    entrega = new fEntrega(0);
                }

                entrega.ShowDialog();*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
