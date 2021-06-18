using Entidades;
using System;
using System.Windows.Forms;
using Negocios;
using Utilidades;
using System.Configuration;
using System.Drawing;

namespace GestionCasos.Administrador
{
    public partial class fContador : Form
    {
        t_Contador contador = new t_Contador();
        ContadorNegocio negocio = new ContadorNegocio();

        //Alertas
        showMessageDialog Message = new showMessageDialog();
        Alertas.Alerta Alerta = new Alertas.Alerta();
        public fContador()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void fContador_Load(object sender, EventArgs e)
        {
            SetThemeColor();
        }
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                this.panel1.BackColor = Color.White; 
                this.panel1.ForeColor = Color.FromArgb(9, 12,16);

                label1.ForeColor = Color.FromArgb(9, 12, 16);
                label2.ForeColor = Color.FromArgb(9, 12, 16);
                label3.ForeColor = Color.FromArgb(9, 12, 16);
                label4.ForeColor = Color.FromArgb(9, 12, 16);
                label5.ForeColor = Color.FromArgb(9, 12, 16);

            }
            else
            {

            }
        }


        private void fContador_Resize(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcion de guardar un contador
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos los campos
                if (ValidarCampos() == true)
                {
                    //Cargarmos el modelo con los datos del formulario
                    contador.Cedula = txtCedula.Text;
                    contador.Nombre = txtNombre.Text.ToUpper();
                    contador.Apellido1 = txtApellido1.Text.ToUpper();
                    contador.Apellido2 = txtApellido2.Text.ToUpper();

                    //Ejecutamos el metodo de guardar y le mandamos el modelo contador ya cargado de datos
                    if (negocio.guardar(contador) == true)
                    {
                        //En caso de que se ejecute correctamente
                        Message.Success(new Alertas.Alerta(), "El contador se guardo correctamente");
                        LimpiarCampos();
                    }
                    else
                    {
                        //En caso de que se ocurra un error
                        Message.Danger(new Alertas.Alerta(), "No se pudo guardar");
                    }
                }
            }
            catch(Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }

        //Metodo de Buscar un contador
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Text != string.Empty)
                {
                    contador.Cedula = txtCedula.Text.Trim();
                    var datosEncotrados = negocio.obtenerPorId(contador);
                    if (datosEncotrados != null)
                    {
                        txtNombre.Text = datosEncotrados.Nombre;
                        txtApellido1.Text = datosEncotrados.Apellido1;
                        txtApellido2.Text = datosEncotrados.Apellido2;
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se encontro el contador, por favor ingrese una cedula valida");
                    }
                }
                else
                {
                    Message.Warning(new Alertas.Alerta(), "Debe de ingresar una cedula antes de buscar un contador");
                }
            }catch(Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }

        //Validaciones de los campo del formualarios
        public bool ValidarCampos()
        {
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


        public void LimpiarCampos()
        {
            txtCedula.ResetText();
            txtNombre.ResetText();
            txtApellido1.ResetText();
            txtApellido2.ResetText();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (ValidarCampos()==true)
                {
                    contador.Cedula = txtCedula.Text;

                    var datos = negocio.obtenerPorId(contador);
                    datos.Nombre = txtNombre.Text.ToUpper();
                    datos.Apellido1 = txtApellido1.Text.ToUpper();
                    datos.Apellido2 = txtApellido2.Text.ToUpper();

                    if (negocio.modificar(datos)==true)
                    {
                        Message.Success(new Alertas.Alerta(), "El contador fue modificado con exito");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                if (ValidarCampos() == true)
                {
                    contador.Cedula = txtCedula.Text;

                    var datos = negocio.obtenerPorId(contador);
                   
                    if (negocio.modificar(datos) == true)
                    {
                        Message.Success(new Alertas.Alerta(), "El contador fue eliminado con exito");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
