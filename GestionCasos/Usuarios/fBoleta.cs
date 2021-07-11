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
using Negocios;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class fBoleta : Form
    {
        string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private int TipoUsuario = 0;
        t_Boleta boleta = new t_Boleta();
        t_Revision revision = new t_Revision();
        BoletaNegocio boletaNegocio = new BoletaNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();

        showMessageDialog Alert = new showMessageDialog();
        public fBoleta(int tipo)
        {
            InitializeComponent();
            TipoUsuario = tipo;
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
            lblConsecutivo.Text = revision.Consecutivo;
            var caso = revisionNegocio.obtenerPorConsecutivo(revision.Consecutivo).Where(x => x.Consecutivo == revision.Consecutivo).SingleOrDefault();

            var boletas = boletaNegocio.obtenerTodo(new t_Boleta());

            var filtro = boletas.Where(x => x.Nu_caso == caso.Id_Caso).SingleOrDefault();


            cbMotivo1.Checked = (bool)filtro.Motivo1;
            cbMotivo2.Checked = (bool)filtro.Motivo2;
            cbMotivo3.Checked = (bool)filtro.Motivo3;
            cbMotivo4.Checked = (bool)filtro.Motivo4;
            cbMotivo5.Checked = (bool)filtro.Motivo5;
            cbMotivo6.Checked = (bool)filtro.Motivo6;
            cbMotivo7.Checked = (bool)filtro.Motivo7;

            if (filtro.Motivo8 != null)
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
                    boleta.Motivo8 = txtOtros.Text;
                    boleta.Observacion = txtObservacion.Text;

                    if (TipoUsuario == 0 && txtObservacion.Text != string.Empty)
                    {
                        revision.Comentario = txtObservacion.Text;
                    }
                    else
                    {
                        revision.Observacion = txtObservacion.Text;
                    }

                    if (boletaNegocio.guardar(boleta) == true && revisionNegocio.modificar(revision) == true)
                    {

                        Alert.Success(new Alertas.Alerta(), "Observacion Agregada con exito");
                    }
                    else
                    {
                        Alert.Danger(new Alertas.Alerta(), "No se pudo guardar la observacion");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
