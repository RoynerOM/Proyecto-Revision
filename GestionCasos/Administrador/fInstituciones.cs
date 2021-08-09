using Entidades;
using Negocios;
using System;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    /*
     Falta revisar el edit and delete
     */
    public partial class fInstituciones : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];

        readonly ContadorNegocio persona = new ContadorNegocio();
        readonly InstitucionNegocio negocio = new InstitucionNegocio();
        readonly showMessageDialog message = new showMessageDialog();
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
            CargarCombosAsync();
            CargarDatosForm();

        }


        private async void CargarCombosAsync()
        {
            try
            {
                //Combo box de Contador
                cbContador.DataSource = await persona.obtenerTrabador((int)Enums.Tipo.Contador);
                cbContador.ValueMember = "Cedula";
                cbContador.DisplayMember = "NombreCompleto";


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
        }


        private void CargarDatosForm()
        {
            tInstitucion institucion = DatosTemp.tInstitucion;
            if (institucion != null)
            {
                txtCodigo.Text = institucion.Codigo.ToString();
                txtInstitucion.Text = institucion.Nombre;
                txtCedulaJuridica.Text = institucion.CedulaJuridica;
                txtCuentaDanea.Text = institucion.CuentaDanea;
                txtCuentaLey.Text = institucion.CuentaLey;
                txtContacto.Text = institucion.Responsable;
                txtTelefono.Text = institucion.Contacto;
                cbCircuito.Text = institucion.Circuito.ToString();
                cbContador.Text = institucion.tPersona.NombreCompleto;
                cbTipo.Text = institucion.tTipoInstitucion.NombreTipo;
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



        private void LimpiarCampos()
        {
            txtCodigo.ResetText();
            cbCircuito.ResetText();
            txtInstitucion.ResetText();
            txtCuentaDanea.ResetText();
            txtCuentaLey.ResetText();
            txtCedulaJuridica.ResetText();
            cbContador.ResetText();
            cbTipo.ResetText();
            txtContacto.ResetText();
            txtTelefono.ResetText();

        }


        //Guardar
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampos() == true)
                {
                    tInstitucion institucion = new tInstitucion();
                    var i = negocio.obtenerPorId(int.Parse(txtCodigo.Text));
                    if (i == null)
                    {
                        institucion.Codigo = int.Parse(txtCodigo.Text);
                        institucion.Circuito= int.Parse(cbCircuito.Text);
                        institucion.Tipo = (int)cbTipo.SelectedValue;
                        institucion.Nombre = txtInstitucion.Text.ToUpper();
                        institucion.CedulaJuridica = txtCedulaJuridica.Text;
                        institucion.CuentaDanea = txtCuentaDanea.Text;
                        institucion.CuentaLey = txtCuentaLey.Text;
                        institucion.Contador = (string)cbContador.SelectedValue;
                        if (txtContacto.Text != string.Empty)
                        {
                            institucion.Responsable = txtContacto.Text.ToUpper();
                        }
                        else
                        {
                            institucion.Responsable = "-";
                        }
                        institucion.Contacto = txtTelefono.Text;
                        institucion.Estado = true;

                        if (negocio.guardarAsync(institucion) == true)
                        {
                            message.Success(new Alertas.Alerta(), "La Junta se guardó correctamente");
                            LimpiarCampos();
                        }
                        else
                        {
                            message.Danger(new Alertas.Alerta(), "No se pudo guardar la junta");
                        }
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se pudo guardar. Institución o junta ya existe");
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
                if (txtCodigo.Text != string.Empty)
                {
                    var datosEncotrados = negocio.obtenerPorId(int.Parse(txtCodigo.Text));
                    if (datosEncotrados != null)
                    {
                        txtCuentaLey.Text = datosEncotrados.CuentaLey;
                        txtCuentaDanea.Text = datosEncotrados.CuentaDanea;
                        txtInstitucion.Text = datosEncotrados.Nombre;
                        txtCedulaJuridica.Text = datosEncotrados.CedulaJuridica;
                        cbTipo.Text = Enum.GetName(typeof(Enums.TipoEscuela), datosEncotrados.Tipo);
                        cbContador.Text = datosEncotrados.tPersona.NombreCompleto;
                        cbCircuito.Text = datosEncotrados.Circuito.ToString();
                        txtContacto.Text = datosEncotrados.Responsable;
                        txtTelefono.Text = datosEncotrados.Contacto;
                    }
                    else
                    {
                        message.Danger(new Alertas.Alerta(), "No se encontró la institución o junta, por favor ingrese un codigo válido");
                    }
                }
                else
                {
                    message.Warning(new Alertas.Alerta(), "Debe de ingresar un código antes de buscar una institución");
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
                tInstitucion institucion = new tInstitucion();
                if (txtCodigo.Text != string.Empty)
                {
                    institucion = negocio.obtenerPorId(int.Parse(txtCodigo.Text));

                    if (negocio.eliminar(institucion) == true)
                    {
                        message.Success(new Alertas.Alerta(), "El contador fue eliminado con éxito");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        //Modificar
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                tPersona p = new tPersona();
                tInstitucion institucion = new tInstitucion();
                if (ValidarCampos() == true)
                {
                    institucion = negocio.obtenerPorId(int.Parse(txtCodigo.Text));
                    institucion.CuentaLey = txtCuentaLey.Text;
                    institucion.Nombre = txtInstitucion.Text;
                    institucion.CuentaDanea = txtCuentaDanea.Text;
                    institucion.CedulaJuridica = txtCedulaJuridica.Text;
                    //institucion.Circuito = (int)cbCircuito.SelectedValue;
                    //institucion.Tipo = (int)cbTipo.SelectedValue;

                    p.Cedula = cbContador.SelectedValue.ToString();
                    p = persona.obtenerPorId(p);
                    institucion.Contador = p.Cedula;
                    institucion.tPersona = p;
                    if (negocio.modificar(institucion) == true)
                    {
                        message.Success(new Alertas.Alerta(), "La Junta modificada correctamente");
                        LimpiarCampos();
                        DatosTemp.tInstitucion = null;
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
                    if (txtCodigo.Text != string.Empty)
                    {
                        var datosEncotrados = negocio.obtenerPorId(int.Parse(txtCodigo.Text));
                        if (datosEncotrados != null)
                        {
                            txtCuentaLey.Text = datosEncotrados.CuentaLey;
                            txtCuentaDanea.Text = datosEncotrados.CuentaDanea;
                            txtInstitucion.Text = datosEncotrados.Nombre;
                            txtCedulaJuridica.Text = datosEncotrados.CedulaJuridica;
                            cbTipo.Text = Enum.GetName(typeof(Enums.TipoEscuela), datosEncotrados.Tipo);
                            cbContador.Text = datosEncotrados.tPersona.NombreCompleto;
                            cbCircuito.Text = datosEncotrados.Circuito.ToString();
                            txtContacto.Text = datosEncotrados.Responsable;
                            txtTelefono.Text = datosEncotrados.Contacto;
                        }
                        else
                        {
                            message.Danger(new Alertas.Alerta(), "No se encontró la institución o junta, por favor ingrese una código válido");
                        }
                    }
                    else
                    {
                        message.Warning(new Alertas.Alerta(), "Debe de ingresar un código antes de buscar una institución");
                    }
                }
                catch (Exception ex)
                {
                    //En caso de que ocurra  un error en el programa se lanza la excepcion  y que no se rompa la ejecucion
                    Console.WriteLine(ex.Message);
                }
            }
        }



        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
