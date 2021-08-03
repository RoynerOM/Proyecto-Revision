using Entidades;
using Negocios;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fEntrega : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        ContadorNegocio personaNegocio = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        EntregaNegocio entregaNegocio = new EntregaNegocio();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        showMessageDialog Message = new showMessageDialog();
        tEntregaCasos entrega = new tEntregaCasos();
        private string consecutivo = null;
        bool state = false;

        public fEntrega(tEntregaCasos id, string consecutivo)
        {
            InitializeComponent();
            //entrega = id;
            this.consecutivo = consecutivo;
            SetThemeColor();
        }

        //Cambio de color
        private void SetThemeColor()
        {
            if (isDark == "false")
            {

                this.BackColor = Colors.White;
                this.ForeColor = Colors.Black;
                this.gunaLinePanel1.BackColor = Colors.White;

                cbCheque.ForeColor = Colors.Black;
                cbTranferencia.ForeColor = Colors.Black;

                label1.ForeColor = Colors.Black;
                label2.ForeColor = Colors.Black;
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
                label9.ForeColor = Colors.Black;
                lblConsecutivo.ForeColor = Colors.Black;
            }
        }

        private void CargarDatos()
        {
            try
            {
                entrega = entregaNegocio.obtenerPorCaso(consecutivo);

                if (entrega != null)
                {
                    btnPdf.Visible = true;
                    lblFecha.Visible = true;

                    txtCedula.Text = entrega.tMensajero.CedulaMensajero;
                    txtNombre.Text = entrega.tMensajero.Nombre;
                    txtApellido1.Text = entrega.tMensajero.Apellido1;
                    txtApellido2.Text = entrega.tMensajero.Apellido2;
                    txtCedula.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido1.Enabled = false;
                    txtApellido2.Enabled = false;
                    cbEntrega.Text = entrega.Recepcion == 4 ? "OFICINA" : "MENSAJERO";
                    lblConsecutivo.Text = consecutivo;


                    if (entrega.Pago == 0)
                    {
                        cbCheque.Checked = true;
                        cbTranferencia.Checked = false;
                    }
                    else
                    {
                        cbCheque.Checked = false;
                        cbTranferencia.Checked = true;
                    }

                    lblFecha.Text = "Entregado " + entrega.FechaEntrega.ToLongDateString();
                    txtObservacion.Text = entrega.Observacion;
                }
                else
                {
                    btnPdf.Visible = false;

                    lblConsecutivo.Text = consecutivo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void CargarCombos()
        {
            try
            {
                var data = recepcion.obtenerTodo(new tRecepcion());
                if (data != null)
                {
                    //Recepcion
                    cbEntrega.DataSource = data.Where(x => x.id >= 3).ToList();
                    cbEntrega.ValueMember = "id";
                    cbEntrega.DisplayMember = "Recepcion";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {

                viewTrabajador persona = new viewTrabajador();
                persona = personaNegocio.obtenerTrabadorBy(txtCedula.Text);
                if (txtCedula.Text.Length > 6)
                {

                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre.ToUpper();
                        txtApellido1.Text = persona.Apellido1.ToUpper();
                        txtApellido2.Text = persona.Apellido2.ToUpper();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void fEntrega_Load(object sender, EventArgs e)
        {
            lblFecha.Visible = false;
            txtCedula.Mask = "0-0000-0000";
            CargarCombos();
            CargarDatos();
        }



        private void cbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheque.Checked == true)
            {
                cbTranferencia.Checked = false;
            }
        }



        private void cbTranferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTranferencia.Checked == true)
            {
                cbCheque.Checked = false;
            }
        }



        private void btn_Click(object sender, EventArgs e)
        {
            ReporteEntregaDeCasos entrega = new ReporteEntregaDeCasos();
            entrega.WindowState = FormWindowState.Maximized;
            entrega.ShowDialog();
        }


        private void labelColorChange()
        {

            if (isDark == "false")
            {
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
                label9.ForeColor = Colors.Black;
            }
            else
            {
                label3.ForeColor = Colors.White;
                label4.ForeColor = Colors.White;
                label6.ForeColor = Colors.White;
                label7.ForeColor = Colors.White;
                label9.ForeColor = Colors.White;
            }

            if (txtCedula.Text.Length < 8)
            {
                label7.ForeColor = Colors.RedFont;
            }
            if (txtNombre.Text == string.Empty)
            {
                label6.ForeColor = Colors.RedFont;
            }
            if (txtApellido1.Text == string.Empty)
            {
                label3.ForeColor = Colors.RedFont;
            }
            if (txtApellido2.Text == string.Empty)
            {
                label4.ForeColor = Colors.RedFont;
            }

        }


        private bool ValidarCampos()
        {
            labelColorChange();

            if (txtCedula.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de cedula no puede ser vacio");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Nombre no puede ser vacio");
                return false;
            }
            else if (txtApellido1.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de primer apellido no puede ser vacio");
                return false;
            }
            else if (txtApellido2.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de segundo apellido no puede ser vacio");
                return false;
            }
            else
            {
                return true;
            }
        }


        //Guardar informacion de entrega
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tEntregaCasos entregaCasos = new tEntregaCasos();
                tRevision revision = new tRevision();
                tMensajero m = new tMensajero();
                tEntregaCasos ec = new tEntregaCasos();

                //Se inserta la persona en caso de que no exista
                m.CedulaMensajero = txtCedula.Text;
                m.Nombre = txtNombre.Text.ToUpper();
                m.Apellido1 = txtApellido1.Text.ToUpper();
                m.Apellido2 = txtApellido2.Text.ToUpper();

                personaNegocio.guardar(m);


                if (ValidarCampos() == true)
                {
                    //En caso de que exista se actualiza
                    ec = entregaNegocio.obtenerPorCaso(consecutivo);

                    if (ec != null)
                    {
                        if (cbCheque.Checked == true)
                        {
                            //Por cheque
                            ec.Pago = 0;
                        }
                        else
                        {
                            //Por Transferencia
                            ec.Pago = 1;
                        }
                        ec.Observacion = txtObservacion.Text;

                        if (entregaNegocio.modificar(ec) == true)
                        {
                            Message.Success(new Alertas.Alerta(), "La información de entrega fue modificada");
                            btnPdf.Visible = true;
                        }
                        else
                        {
                            Message.Danger(new Alertas.Alerta(), "Error al modificar");
                        }
                    }
                    //En caso contrario se guarda
                    else
                    {
                        //var r = recepcion.obtenerTodo(new tRecepcion()).Where(x => x.id == (int)cbEntrega.SelectedValue).SingleOrDefault();

                        entregaCasos.Mensajero = int.Parse(txtCedula.Text);
                        entregaCasos.Recepcion = (int)cbEntrega.SelectedValue;
                        //entregaCasos.tRecepcion = r;

                        if (cbCheque.Checked == true)
                        {
                            //Por cheque
                            entregaCasos.Pago = 0;
                        }
                        else
                        {
                            //Por Transferencia
                            entregaCasos.Pago = 1;
                        }

                        tEstado estado = new tEstado();
                        estado.IdEstado = 5;
                        estado = estadoNegocio.obtenerPorId(estado);
                        revision = revisionNegocio.ObtenerPorCaso(consecutivo);
                        //Cambio el estado en entregado
                        revision.Estado = estado.IdEstado;
                        revision.tEstado = estado;

                        entregaCasos.Caso = revision.IdCaso;
                        entregaCasos.FechaEntrega = DateTime.Now;
                        entregaCasos.Observacion = txtObservacion.Text;

                        if (revisionNegocio.modificar(revision) == true && entregaNegocio.guardar(entregaCasos) == true)
                        {
                            Message.Success(new Alertas.Alerta(), "La informacion de entrega fue guardada");
                            btnPdf.Visible = true;
                        }
                        else
                        {
                            Message.Danger(new Alertas.Alerta(), "No se pudo guardar la informacion de la entrega");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {


            if (txtCedula.Mask == "0-0000-0000")
            {
                txtCedula.Mask = "000000000000";
            }
            else
            {
                txtCedula.Mask = "0-0000-0000";
            }
        }

        private void cbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
