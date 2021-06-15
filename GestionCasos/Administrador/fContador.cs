using Entidades;
using System;
using System.Windows.Forms;
using Negocios;
using Utilidades;

namespace GestionCasos.Administrador
{
    public partial class fContador : Form
    {
        t_Contador contador = new t_Contador();
        ContadorNegocio negocio = new ContadorNegocio();

        //Alertas
        showMessageDialog Message = new showMessageDialog();
        public fContador()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void fContador_Load(object sender, EventArgs e)
        {

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            contador.Cedula = txtCedula.Text;
            contador.Nombre = txtNombre.Text.ToUpper();
            contador.Apellido1 = txtApellido1.Text.ToUpper();
            contador.Apellido2 = txtApellido2.Text.ToUpper();

            if (negocio.guardar(contador) == true)
            {
                Message.Success(new Alertas.Alerta(),"El contador se guardo correctamente");
            }
            else
            {
                Message.Danger(new Alertas.Alerta(), "No se pudo guardar");
            }
        }
    }
}
