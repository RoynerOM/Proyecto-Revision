using Entidades;
using Negocios;
using System;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fContador : Form
    {
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        t_Persona contador = new t_Persona();
        ContadorNegocio negocio = new ContadorNegocio();

        //Alertas
        showMessageDialog Message = new showMessageDialog();
        Alertas.Alerta Alerta = new Alertas.Alerta();
        private int Rol = (int)Enums.Tipo.Tramitador;

        public fContador(int Rol)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Rol = Rol;
            SetThemeColor();

        }


        private void CargarCombos()
        {
            cbTipo.DataSource = Enum.GetValues(typeof(Enums.TipoCedula));
            cbTipoPersona.DataSource = Enum.GetValues(typeof(Enums.Tipo));
        }


        private void FuncionesPermitidas()
        {
            //Usuario Tramitador
            if (Rol == (int)Enums.Tipo.Tramitador)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }


        private void fContador_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            CargarCombos();
            CargarDatosForm();
            FuncionesPermitidas();
            OpenChildForm(new fLoader(1, hilo));
        }

        //Cambio de color
        private void SetThemeColor()
        {
            if (isDark == "false")
            {
                this.panel1.BackColor = Color.White;
                this.panel1.ForeColor = Colors.Black;

                label1.ForeColor = Colors.Black;
                label2.ForeColor = Colors.Black;
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label5.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
                label8.ForeColor = Colors.Black;
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


        private bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        //Funcion de guardar un contador
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos los campos
                if (ValidarCampos() == true)
                {
                    t_Trabajador trabajador = new t_Trabajador();
                    t_Mensajero m = new t_Mensajero();
                    contador.Cedula = txtCedula.Text;
                    if (negocio.obtenerPorId(contador) == null)
                    {
                        //Cargarmos el modelo con los datos del formulario
                        contador.TipoId = cbTipo.SelectedIndex;
                        contador.Cedula = txtCedula.Text;
                        contador.Carnet = txtCarne.Text;
                        contador.Nombre = txtNombre.Text.ToUpper();
                        contador.Apellido1 = txtApellido1.Text.ToUpper();
                        contador.Apellido2 = txtApellido2.Text.ToUpper();
                        contador.Correo = txtCorreo.Text;

                        trabajador.Cedula = contador.Cedula;
                        trabajador.Tipo = (int)cbTipoPersona.SelectedValue;
                        trabajador.Estado = true;

                        m.Cedula = txtCedula.Text;
                        m.Nombre = txtNombre.Text.ToUpper();
                        m.Apellido1 = txtApellido1.Text.ToUpper();
                        m.Apellido2 = txtApellido2.Text.ToUpper();

                        //Ejecutamos el metodo de guardar y le mandamos el modelo contador ya cargado de datos
                        if (negocio.guardar(contador) == true && negocio.guardar(m) == true)
                        {
                            if (negocio.GuardarTrabajador(trabajador) == true)
                            {
                                //En caso de que se ejecute correctamente
                                Message.Success(new Alertas.Alerta(), "El contador se guardo correctamente");
                                LimpiarCampos();
                            }

                        }
                        else
                        {
                            //En caso de que se ocurra un error
                            Message.Danger(new Alertas.Alerta(), "No se pudo guardar");
                        }
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "Error al guardar. La persona ya existe ");
                    }
                }
            }
            catch (Exception ex)
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
                var contador = new t_Persona();
                if (txtCedula.Text != string.Empty)
                {
                    contador.Cedula = txtCedula.Text.Trim();
                    var datosEncotrados = negocio.obtenerPorId(contador);
                    if (datosEncotrados != null)
                    {
                        txtNombre.Text = datosEncotrados.Nombre;
                        txtApellido1.Text = datosEncotrados.Apellido1;
                        txtApellido2.Text = datosEncotrados.Apellido2;
                        txtCarne.Text = datosEncotrados.Carnet;
                        cbTipo.SelectedIndex = (int)datosEncotrados.TipoId;
                        txtCorreo.Text = datosEncotrados.Correo;
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
            }
            catch (Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }

        //Validaciones de los campo del formualarios
        //Falta camboar el color del texto cuando este vacio
        private void labelColorChange()
        {
            if (isDark == "false")
            {
                label1.ForeColor = Colors.Black;
                label2.ForeColor = Colors.Black;
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label5.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label8.ForeColor = Colors.Black;
            }
            else
            {
                label1.ForeColor = Colors.White;
                label2.ForeColor = Colors.White;
                label3.ForeColor = Colors.White;
                label4.ForeColor = Colors.White;
                label5.ForeColor = Colors.White;
                label6.ForeColor = Colors.White;
                label8.ForeColor = Colors.White;
            }

            if (txtCedula.Text.Length < 8)
            {
                label1.ForeColor = Colors.RedFont;
            }
            if (txtNombre.Text == string.Empty)
            {
                label2.ForeColor = Colors.RedFont;
            }
            if (txtApellido1.Text == string.Empty)
            {
                label3.ForeColor = Colors.RedFont;
            }
            if (txtApellido2.Text == string.Empty)
            {
                label4.ForeColor = Colors.RedFont;
            }
            if (txtCarne.Text == string.Empty)
            {
                label6.ForeColor = Colors.RedFont;
            }
            if (validarEmail(txtCorreo.Text) == false)
            {
                label8.ForeColor = Colors.RedFont;
            }
        }


        public bool ValidarCampos()
        {
            labelColorChange();

            if (txtCedula.Text.Length < 8)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Cédula no puede ser vacío");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Nombre no puede ser vacío");
                return false;
            }
            else if (txtApellido1.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Primer Apellido no puede ser vacío");
                return false;
            }
            else if (txtApellido2.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Segundo Apellido no puede ser vacío");
                return false;
            }
            else if (txtCarne.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Carnet no puede ser vacío");
                return false;
            }
            else if (validarEmail(txtCorreo.Text) == false)
            {
                Message.Danger(new Alertas.Alerta(), "Debe ingresar un correo válido");
                return false;
            }
            else
            {
                return true;
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public void LimpiarCampos()
        {
            txtCedula.ResetText();
            txtNombre.ResetText();
            txtApellido1.ResetText();
            txtApellido2.ResetText();
            txtCarne.ResetText();
            txtCorreo.ResetText();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Actualizar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampos() == true)
                {
                    contador.Cedula = txtCedula.Text;

                    var datos = negocio.obtenerPorId(contador);
                    datos.Nombre = txtNombre.Text.ToUpper();
                    datos.Apellido1 = txtApellido1.Text.ToUpper();
                    datos.Apellido2 = txtApellido2.Text.ToUpper();

                    if (negocio.modificar(datos) == true)
                    {
                        Message.Success(new Alertas.Alerta(), "El contador fue modificado con exito");
                        DatosTemp.t_Persona = null;
                        LimpiarCampos();
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se pudo modificar");
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

                    if (negocio.eliminar(datos) == true)
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


        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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


        private void CargarDatosForm()
        {
            if (DatosTemp.t_Persona != null)
            {
                txtCedula.Text = DatosTemp.t_Persona.Cedula;
                txtNombre.Text = DatosTemp.t_Persona.Nombre;
                txtApellido1.Text = DatosTemp.t_Persona.Apellido1;
                txtApellido2.Text = DatosTemp.t_Persona.Apellido2;
                txtCarne.Text = DatosTemp.t_Persona.Carnet;
                txtCorreo.Text = DatosTemp.t_Persona.Correo;
                cbTipo.SelectedIndex = (int)DatosTemp.t_Persona.TipoId;
            }
        }


        private void btnDetalles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesPersonas(Rol));
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    var contador = new t_Persona();
                    if (txtCedula.Text != string.Empty)
                    {
                        contador.Cedula = txtCedula.Text.Trim();
                        var datosEncotrados = negocio.obtenerPorId(contador);
                        if (datosEncotrados != null)
                        {
                            txtNombre.Text = datosEncotrados.Nombre;
                            txtApellido1.Text = datosEncotrados.Apellido1;
                            txtApellido2.Text = datosEncotrados.Apellido2;
                            txtCarne.Text = datosEncotrados.Carnet;
                            cbTipo.SelectedIndex = (int)datosEncotrados.TipoId;
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
                }
                catch (Exception ex)
                {
                    //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
