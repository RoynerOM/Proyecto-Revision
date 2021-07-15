using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        ContadorNegocio personaNegocio = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        //t_EntregaCasos entregaCasos = new t_EntregaCasos();

        showMessageDialog Message = new showMessageDialog();
        private int _id = 0;
        public fEntrega(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void CargarDatos()
        {

            try
            {
                if (_id != 0)
                {
                    btnGuardar.Visible = false;
                    btnPdf.Visible = true;
                }
                else
                {
                    btnGuardar.Visible = true;
                    btnPdf.Visible = false;
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
            CargarCombos();
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
            fReporteEntrega entrega = new fReporteEntrega(txtConsecutivo.Text);
            entrega.ShowDialog();
        }


        private void labelColorChange()
        {

            label3.ForeColor = Colors.Black;
            label4.ForeColor = Colors.Black;
            label6.ForeColor = Colors.Black;
            label7.ForeColor = Colors.Black;

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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /* try
             {
                 //t_EntregaCasos entregaCasos = new t_EntregaCasos();
                 if (ValidarCampos()== true)
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
                     entregaCasos.Id_Caso = int.Parse(txtConsecutivo.Text);
                     entregaCasos.FechaEntrega = DateTime.Now.ToShortDateString();

                     if (entregaNegocio.guardar(entregaCasos) == true)
                     {
                         Message.Success(new Alertas.Alerta(), "La informacion fue guardada");
                     }
                     else
                     {
                         Message.Danger(new Alertas.Alerta(), "No se pudo guaardar la informacion");
                     }
                 }
             }
             catch (Exception ex)
             {

                 Console.WriteLine(ex);
            }*/
        }
    }
}
