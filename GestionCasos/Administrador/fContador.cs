using Entidades;
using System;
using System.Windows.Forms;
using Negocios;
using Utilidades;
using System.Configuration;
using System.Drawing;
using System.Threading;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fContador : Form
    {
        private Form activeForm = null;
        t_Persona contador = new t_Persona();
        ContadorNegocio negocio = new ContadorNegocio();

        //Alertas
        showMessageDialog Message = new showMessageDialog();
        Alertas.Alerta Alerta = new Alertas.Alerta();
        public fContador()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        private void CargarCombos()
        {
            cbTipo.DataSource = Enum.GetValues(typeof(Enums.TipoCedula));
            cbTipoPersona.DataSource = Enum.GetValues(typeof(Enums.Tipo));
        }
        private void fContador_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;

            OpenChildForm(new fLoader(1, hilo));

            CargarCombos();
            SetThemeColor();
            CargarDatosForm();
        }

        //Cambio de color
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
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

        //Funcion de guardar un contador
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos los campos
                if (ValidarCampos() == true)
                {
                    t_Trabajador trabajador = new t_Trabajador();
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
                        trabajador.Cedula = contador.Cedula;
                        trabajador.Tipo = (int)cbTipoPersona.SelectedValue;
                        //Ejecutamos el metodo de guardar y le mandamos el modelo contador ya cargado de datos
                        if (negocio.guardar(contador) == true)
                        {
                            if (negocio.GuardarTrabajador(trabajador)==true)
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
            }catch(Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }

        //Validaciones de los campo del formualarios
        //Falta camboar el color del texto cuando este vacio
        private void labelColorChange()
        {
            label1.ForeColor = Colors.Black;
            label2.ForeColor = Colors.Black;
            label3.ForeColor = Colors.Black;
            label4.ForeColor = Colors.Black;
            label5.ForeColor = Colors.Black;
            label6.ForeColor = Colors.Black;

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
        }


        public bool ValidarCampos()
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
            }else if (txtCarne.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de carnet no puede ser vacio");
                return false;
            }
            else if(txtCorreo.Text != string.Empty)
            {
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
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Actualizar
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
                cbTipo.SelectedIndex = (int)DatosTemp.t_Persona.TipoId;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesPersonas());
        }
    }
}
