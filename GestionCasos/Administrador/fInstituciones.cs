using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Negocios;
using Utilidades;
using Entidades;
using System;

namespace GestionCasos.Administrador
{
    public partial class fInstituciones : Form
    {
        t_Institucion institucion = new t_Institucion();
        InstitucionNegocio negocio = new InstitucionNegocio();
        showMessageDialog message = new showMessageDialog();
        public fInstituciones()
        {
            InitializeComponent();
        }

        private void fInstituciones_Load(object sender, EventArgs e)
        {
            SetThemeColor();
        }


        //Funcion de cambiar el color de fondo
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                this.panel1.BackColor = Color.White;
                this.panel1.ForeColor = Color.FromArgb(9, 12, 16);

                label1.ForeColor = Color.FromArgb(9, 12, 16);
                label2.ForeColor = Color.FromArgb(9, 12, 16);
                label3.ForeColor = Color.FromArgb(9, 12, 16);
                label4.ForeColor = Color.FromArgb(9, 12, 16);
                label5.ForeColor = Color.FromArgb(9, 12, 16);
                label6.ForeColor = Color.FromArgb(9, 12, 16);
                label7.ForeColor = Color.FromArgb(9, 12, 16);
                label8.ForeColor = Color.FromArgb(9, 12, 16);

            }
            else
            {

            }
        }

        //Funcion de guardar
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    institucion.Codigo = int.Parse(txtCodigo.Text);
                    institucion.Cuenta_Ley = txtCuentaLey.Text;
                    institucion.Nombre = txtInstitucion.Text;
                    institucion.Contador = cbContador.SelectedValue.ToString();
                    institucion.Cuenta_Danea = txtCuentaDanea.Text;
                    institucion.Cedula_Juridica = txtCedulaJuridica.Text;
                    institucion.Circuito = (int)cbCircuito.SelectedValue;
                    institucion.Tipo = (int)cbTipo.SelectedValue;

                    if (negocio.guardar(institucion) == true)
                    {
                        message.Success(new Alertas.Alerta(), "La Junta se guardo correctamente");
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se pudo guardar la junta");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Validar campos
        public bool ValidarCampos()
        {
            if (txtCodigo.Text == string.Empty)
            {
                return false;
            }
            else if (txtCuentaLey.Text == string.Empty)
            {
                return false;
            }
            else if (txtInstitucion.Text == string.Empty)
            {
                return false;
            }
            else if (txtCuentaDanea.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Metodo de buscar
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    institucion.Codigo = int.Parse(txtCodigo.Text);
                    var datosEncotrados = negocio.obtenerPorId(institucion);
                    if (datosEncotrados != null)
                    {
                        txtCuentaLey.Text = datosEncotrados.Cuenta_Ley;
                        txtCuentaDanea.Text = datosEncotrados.Cuenta_Danea;
                        txtInstitucion.Text = datosEncotrados.Nombre;
                        txtCedulaJuridica.Text = datosEncotrados.Cedula_Juridica;
                        //cbTipo.Text = datosEncotrados.Tipo
                        cbContador.Text = datosEncotrados.t_Contador.Nombre_Completo;
                        cbCircuito.Text = datosEncotrados.Circuito.ToString();
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se encontro el contador, por favor ingrese una cedula valida");
                    }
                }
                else
                {
                    message.Warning(new Alertas.Alerta(), "Debe de ingresar una cedula antes de buscar un contador");
                }
            }
            catch (Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
