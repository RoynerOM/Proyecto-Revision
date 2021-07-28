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
using GestionCasos.Reportes;
using Negocios;
using Utilidades;

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
        private t_EntregaCasos entregaCasos = null;
        

        public fEntrega(t_EntregaCasos id)
        {
            InitializeComponent();
            entregaCasos = id;
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
                label5.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
                lblConsecutivo.ForeColor = Colors.Black;
            }
            else
            {

            }
        }
        private void CargarDatos()
        {

            try
            {
                
                if (entregaCasos != null)
                {
                    btnGuardar.Visible = false;
                    btnPdf.Visible = true;
                    lblFecha.Visible = true;

                    txtCedula.Text = entregaCasos.Cedula;
                    txtNombre.Text = entregaCasos.t_Persona.Nombre;
                    txtApellido1.Text = entregaCasos.t_Persona.Apellido1;
                    txtApellido2.Text = entregaCasos.t_Persona.Apellido2;
                    cbTipo.SelectedIndex = (int)entregaCasos.t_Persona.TipoId;
                    cbEntrega.Text = entregaCasos.t_Recepcion.Nombre;
                    lblConsecutivo.Text = entregaCasos.t_Revision.Consecutivo;
                    lblFecha.Text = "Entregado "+entregaCasos.FechaEntrega.ToLongDateString();
                    if (entregaCasos.Pago == 0)
                    {
                        cbCheque.Checked = true;
                        cbTranferencia.Checked = false;
                    }
                    else
                    {
                        cbCheque.Checked = false;
                        cbTranferencia.Checked = true;
                    }
                }
                else
                {
                    btnGuardar.Visible = true;
                    btnPdf.Visible = false;

                    lblConsecutivo.Text = DatosTemp.t_Revision.Consecutivo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public void CargarCombos()
        {
            cbTipo.SelectedIndex = 0;
            var data = recepcion.obtenerTodo(new t_Recepcion());
            //Recepcion
            cbEntrega.DataSource = data.Where(x => x.id >= 3).ToList();
            cbEntrega.ValueMember = "id";
            cbEntrega.DisplayMember = "Nombre";
        }


        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {

                t_Persona persona = new t_Persona();
                persona.Cedula = txtCedula.Text;

                if (txtCedula.Text.Length > 6)
                {

                    persona = personaNegocio.obtenerPorId(persona);
                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre;
                        txtApellido1.Text = persona.Apellido1;
                        txtApellido2.Text = persona.Apellido2;
                    }
                }

                if (txtCedula.Text.Length > 8 || txtCedula.Text != "")
                {

                    persona = personaNegocio.obtenerPorId(persona);
                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre;
                        txtApellido1.Text = persona.Apellido1;
                        txtApellido2.Text = persona.Apellido2;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                txtCedula.Mask = "0-0000-0000";
            }
            else
            {
                txtCedula.Mask = "000000000000";
            }
        }



        private void fEntrega_Load(object sender, EventArgs e)
        {
            lblFecha.Visible = false;
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
            ReporteBoletaDevolucion entrega = new ReporteBoletaDevolucion(lblConsecutivo.Text);
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
                t_EntregaCasos entregaCasos = new t_EntregaCasos();
                t_Revision revision = new t_Revision();
                if (ValidarCampos() == true)
                {
                    entregaCasos.Cedula = txtCedula.Text;
                    entregaCasos.Recepcion = (int)cbEntrega.SelectedValue;

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
                    
                    Estado estado = new Estado();
                    estado.id = 4;

                    revision = revisionNegocio.obtenerPorConsecutivo(lblConsecutivo.Text).SingleOrDefault();
                    //Cambio el estado en entregado
                    estado = estadoNegocio.obtenerPorId(estado);
                    revision.Estado = estado.id;
                    revision.Estado1 = estado;

                    entregaCasos.Id_Caso = revision.Id_Caso;
                    entregaCasos.FechaEntrega = DateTime.Now;

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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
