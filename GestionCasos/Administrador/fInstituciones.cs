using Entidades;
using Negocios;
using System;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fInstituciones : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        t_Institucion institucion = new t_Institucion();
        ContadorNegocio persona = new ContadorNegocio();
        DireccionRegionalNegocio regional = new DireccionRegionalNegocio();
        InstitucionNegocio negocio = new InstitucionNegocio();
        showMessageDialog message = new showMessageDialog();
        private Form activeForm;
        private int Rol;
        public fInstituciones(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();
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


        private void fInstituciones_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            FuncionesPermitidas();
            OpenChildForm(new fLoader(1, hilo));
            CargarCombos();
            CargarDatosForm();

        }


        private void CargarCombos()
        {
            try
            {
                //Combo box de circuito
                cbCircuito.DataSource = regional.obtenerTodo(new t_Direccion_Regional());
                cbCircuito.DisplayMember = "Circuito";
                cbCircuito.ValueMember = "Circuito";

                //Combo box de Contador
                cbContador.DataSource = persona.obtenerTrabador((int)Enums.Tipo.Contador);
                cbContador.ValueMember = "Cedula";
                cbContador.DisplayMember = "Nombre_Completo";


                cbTipo.DataSource = Enum.GetValues(typeof(Enums.TipoEscuela));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
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
                label9.ForeColor = Colors.Black;
                label10.ForeColor = Colors.Black;

            }
            else
            {

            }
        }


        private void CargarDatosForm()
        {
            institucion = negocio.obtenerPorId(DatosTemp.t_Institucion);
            if (institucion != null)
            {
                txtCodigo.Text = institucion.Codigo.ToString();
                txtInstitucion.Text = institucion.Nombre;
                txtCedulaJuridica.Text = institucion.Cedula_Juridica;
                txtCuentaDanea.Text = institucion.Cuenta_Danea;
                txtCuentaLey.Text = institucion.Cuenta_Ley;
                txtContacto.Text = institucion.Contacto;
                txtTelefono.Text = institucion.Telefono;
                cbCircuito.Text = institucion.Circuito.ToString();
                cbContador.Text = institucion.t_Persona.Nombre_Completo;
                cbTipo.Text = institucion.t_Tipo_Institucion.NombreTipo;
            }
        }

        void labelColorChnage()
        {
            if (isDark == "false")
            {
                label1.ForeColor = Colors.Black;
                label2.ForeColor = Colors.Black;
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label5.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
                label8.ForeColor = Colors.Black;
                label9.ForeColor = Colors.Black;
                label10.ForeColor = Colors.Black;
            }
            else
            {
                label1.ForeColor = Colors.White;
                label2.ForeColor = Colors.White;
                label3.ForeColor = Colors.White;
                label4.ForeColor = Colors.White;
                label5.ForeColor = Colors.White;
                label6.ForeColor = Colors.White;
                label7.ForeColor = Colors.White;
                label8.ForeColor = Colors.White;
                label9.ForeColor = Colors.White;
                label10.ForeColor = Colors.White;
            }


            if (txtCodigo.Text == string.Empty)
            {
                label1.ForeColor = Colors.RedFont;
            }
            if (txtCuentaLey.Text.Length < 17)
            {
                label8.ForeColor = Colors.RedFont;
            }
            if (txtInstitucion.Text == string.Empty)
            {
                label4.ForeColor = Colors.RedFont;
            }
            if (txtCuentaDanea.Text.Length < 17)
            {
                label7.ForeColor = Colors.RedFont;
            }
            if (txtCedulaJuridica.Text.Length < 7)
            {
                label6.ForeColor = Colors.RedFont;
            }
        }


        //Validar campos
        public bool ValidarCampos()
        {
            labelColorChnage();
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
            else if (txtCedulaJuridica.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Guardar
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampos() == true)
                {
                    institucion.Codigo = int.Parse(txtCodigo.Text);
                    institucion = negocio.obtenerPorId(institucion);
                    if (institucion == null)
                    {
                        institucion.Codigo = int.Parse(txtCodigo.Text);
                        institucion.Cuenta_Ley = txtCuentaLey.Text;
                        institucion.Nombre = txtInstitucion.Text;
                        institucion.Contador = (string)cbContador.SelectedValue;
                        institucion.Cuenta_Danea = txtCuentaDanea.Text;
                        institucion.Cedula_Juridica = txtCedulaJuridica.Text;
                        institucion.Circuito = (int)cbCircuito.SelectedValue;
                        institucion.Tipo = (int)cbTipo.SelectedValue;
                        institucion.Contacto = txtContacto.Text;
                        institucion.Telefono = txtTelefono.Text;

                        if (negocio.guardar(institucion) == true)
                        {
                            message.Success(new Alertas.Alerta(), "La Junta se guardo correctamente");
                        }
                        else
                        {
                            message.Danger(new Alertas.Alerta(), "No se pudo guardar la junta");
                        }
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se pudo guardar. Institucion o junta ya existe");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Buscar
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var institucion = new t_Institucion();
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
                        cbTipo.Text = Enum.GetName(typeof(Enums.TipoEscuela), datosEncotrados.Tipo);
                        cbContador.Text = datosEncotrados.t_Persona.Nombre_Completo;
                        cbCircuito.Text = datosEncotrados.Circuito.ToString();
                        txtContacto.Text = datosEncotrados.Contacto;
                        txtTelefono.Text = datosEncotrados.Telefono;
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se encontro la institucion o junta, por favor ingrese una codigo valido");
                    }
                }
                else
                {
                    message.Warning(new Alertas.Alerta(), "Debe de ingresar un codigo antes de buscar una institucion");
                }
            }
            catch (Exception ex)
            {
                //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                Console.WriteLine(ex.Message);
            }
        }


        //Eliminar
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    institucion.Codigo = int.Parse(txtCodigo.Text);

                    var datos = negocio.obtenerPorId(institucion);

                    if (negocio.eliminar(datos) == true)
                    {
                        message.Success(new Alertas.Alerta(), "El contador fue eliminado con exito");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            txtCuentaLey.ResetText();
            txtCuentaDanea.ResetText();
            txtInstitucion.ResetText();
            txtCedulaJuridica.ResetText();
            cbTipo.ResetText();
            cbContador.ResetText();
            cbCircuito.ResetText();
        }


        //Modificar
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                t_Persona p = new t_Persona();
                if (ValidarCampos() == true)
                {
                    institucion.Cuenta_Ley = txtCuentaLey.Text;
                    institucion.Nombre = txtInstitucion.Text;
                    institucion.Cuenta_Danea = txtCuentaDanea.Text;
                    institucion.Cedula_Juridica = txtCedulaJuridica.Text;
                    //institucion.Circuito = (int)cbCircuito.SelectedValue;
                    //institucion.Tipo = (int)cbTipo.SelectedValue;

                    p.Cedula = cbContador.SelectedValue.ToString();
                    p = persona.obtenerPorId(p);
                    institucion.Contador = p.Cedula;
                    institucion.t_Persona = p;
                    if (negocio.modificar(institucion) == true)
                    {
                        message.Success(new Alertas.Alerta(), "La Junta modificada correctamente");
                        LimpiarCampos();
                        DatosTemp.t_Institucion = null;
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se pudo modificar la junta");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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


        private void btnDetalles_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fDetallesJuntas(Rol));
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


                try
                {
                    var institucion = new t_Institucion();
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
                            cbTipo.Text = Enum.GetName(typeof(Enums.TipoEscuela), datosEncotrados.Tipo);
                            cbContador.Text = datosEncotrados.t_Persona.Nombre_Completo;
                            cbCircuito.Text = datosEncotrados.Circuito.ToString();
                            txtContacto.Text = datosEncotrados.Contacto;
                            txtTelefono.Text = datosEncotrados.Telefono;
                        }
                        else
                        {
                            message.Danger(new Alertas.Alerta(), "No se encontro la institucion o junta, por favor ingrese una codigo valido");
                        }
                    }
                    else
                    {
                        message.Warning(new Alertas.Alerta(), "Debe de ingresar un codigo antes de buscar una institucion");
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
