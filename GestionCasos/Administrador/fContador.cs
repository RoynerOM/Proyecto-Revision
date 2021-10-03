using Entidades;
using GestionCasos.Singleton;
using Negocios;
using System;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fContador : Form
    {
        private Form activeForm = null;
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        tPersona contador = new tPersona();
        readonly ControllerService controller = new ControllerService();

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


        private void LimpiarCampos()
        {
            txtCedula.ResetText();
            txtNombre.ResetText();
            txtApellido1.ResetText();
            txtApellido2.ResetText();
            txtCarne.ResetText();
            txtCorreo.ResetText();
            cbTipo.SelectedIndex = 0;
            cbTipoPersona.SelectedIndex = 0;
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


        //Funcion de guardar un contador
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos los campos
                if (ValidarCampos() == true)
                {
                    tTrabajador trabajador = new tTrabajador();
                    tMensajero m = new tMensajero();
                    contador.Cedula = txtCedula.Text;
                    if (controller.CrudContador().obtenerPorId(contador) == null)
                    {
                        //Cargarmos el modelo con los datos del formulario
                        contador.TipoIdentificacion = cbTipo.SelectedIndex;
                        contador.Cedula = txtCedula.Text;
                        if (txtCarne.Text != string.Empty)
                        {
                            contador.Carnet = txtCarne.Text;
                        }
                        else
                        {
                            contador.Carnet = "-";
                        }
                        contador.Nombre = txtNombre.Text.ToUpper();
                        contador.Apellido1 = txtApellido1.Text.ToUpper();
                        contador.Apellido2 = txtApellido2.Text.ToUpper();
                        contador.Correo = txtCorreo.Text;
                        contador.Estado = true;

                        trabajador.Cedula = contador.Cedula;
                        trabajador.Tipo = (int)cbTipoPersona.SelectedValue;
                        trabajador.Activo = true;

                        m.CedulaMensajero = txtCedula.Text;
                        m.Nombre = txtNombre.Text.ToUpper();
                        m.Apellido1 = txtApellido1.Text.ToUpper();
                        m.Apellido2 = txtApellido2.Text.ToUpper();

                        //Ejecutamos el metodo de guardar y le mandamos el modelo contador ya cargado de datos
                        if (controller.CrudContador().guardarAsync(contador) == true && controller.CrudContador().guardar(m) == true)
                        {
                            if (controller.CrudContador().GuardarTrabajador(trabajador) == true)
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
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var contador = new tPersona();
                if (txtCedula.Text != string.Empty)
                {
                    contador.Cedula = txtCedula.Text.Trim();
                    var datosEncotrados = controller.CrudContador().obtenerPorId(contador);
                    if (datosEncotrados != null)
                    {
                        txtNombre.Text = datosEncotrados.Nombre;
                        txtApellido1.Text = datosEncotrados.Apellido1;
                        txtApellido2.Text = datosEncotrados.Apellido2;
                        txtCarne.Text = datosEncotrados.Carnet;
                        cbTipo.SelectedIndex = (int)datosEncotrados.TipoIdentificacion;
                        txtCorreo.Text = datosEncotrados.Correo;
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se encontró el contador, por favor ingrese una cédula válida");
                    }
                }
                else
                {
                    Message.Warning(new Alertas.Alerta(), "Debe de ingresar una cédula antes de buscar un contador");
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


        //Actualizar
        private async void btnModificar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarCampos() == true)
                {
                    tPersona p = new tPersona();
                    p= await controller.CrudContador().obtenerPorIdAsync(txtCedula.Text);
                    p.Nombre = txtNombre.Text.ToUpper();
                    p.Apellido1 = txtApellido1.Text.ToUpper();
                    p.Apellido2 = txtApellido2.Text.ToUpper();
                    p.Correo = txtCorreo.Text;
                    p.Estado = true;

                    if (controller.CrudContador().modificar(p) == true)
                    {
                        Message.Success(new Alertas.Alerta(), "El contador fue modificado con éxito");
                        DatosTemp.tPersona = null;
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


        private async void BtnEliminar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    var datos = await controller.CrudContador().obtenerPorIdAsync(txtCedula.Text);

                    if (controller.CrudContador().eliminar(datos) == true)
                    {
                        Message.Success(new Alertas.Alerta(), "El contador fue eliminado con éxito");
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
            try
            {
                if (DatosTemp.tPersona != null)
                {
                    txtCedula.Text = DatosTemp.tPersona.Cedula;
                    txtNombre.Text = DatosTemp.tPersona.Nombre;
                    txtApellido1.Text = DatosTemp.tPersona.Apellido1;
                    txtApellido2.Text = DatosTemp.tPersona.Apellido2;
                    txtCarne.Text = DatosTemp.tPersona.Carnet;
                    txtCorreo.Text = DatosTemp.tPersona.Correo;
                    cbTipo.SelectedIndex = (int)DatosTemp.tPersona.TipoIdentificacion;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesPersonas(Rol));
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    var contador = new tPersona();
                    if (txtCedula.Text != string.Empty)
                    {
                        contador.Cedula = txtCedula.Text.Trim();
                        var datosEncotrados = controller.CrudContador().obtenerPorId(contador);
                        if (datosEncotrados != null)
                        {
                            txtNombre.Text = datosEncotrados.Nombre;
                            txtApellido1.Text = datosEncotrados.Apellido1;
                            txtApellido2.Text = datosEncotrados.Apellido2;
                            txtCarne.Text = datosEncotrados.Carnet;
                            cbTipo.SelectedIndex = (int)datosEncotrados.TipoIdentificacion;
                        }
                        else
                        {
                            Message.Danger(new Alertas.Alerta(), "No se encontró el contador, por favor ingrese una cédula válida");
                        }
                    }
                    else
                    {
                        Message.Warning(new Alertas.Alerta(), "Debe de ingresar una cédula antes de buscar un contador");
                    }
                }
                catch (Exception ex)
                {
                    //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
