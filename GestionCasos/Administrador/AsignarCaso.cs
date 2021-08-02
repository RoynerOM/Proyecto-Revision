using Datos;
using Entidades;
using GestionCasos.Administrador;
using Negocios;
using System;
//using Utilidades.Enumerables;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos

{
    public partial class AsignarCaso : Form
    {

        RevisionNegocio Rnegocio = new RevisionNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        showMessageDialog Alerta = new showMessageDialog();
        private Form activeForm = null;

        public AsignarCaso()
        {
            InitializeComponent();
            SetThemeColor();
        }

        //Modificado
        private void CargarCombos()
        {
            cbAsignados.DataSource = persona.obtenerTodo(new tPersona());
            cbAsignados.DisplayMember = "NombreCompleto";
            cbAsignados.ValueMember = "Cedula";

            //Modificado
            cbTipoRecepcion.DataSource = recepcion.obtenerTodo(new tRecepcion());
            cbTipoRecepcion.ValueMember = "id";
            cbTipoRecepcion.DisplayMember = "Nombre";
        }

        //Modificado
        private void MostrarConsecutivo()
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {
                    var id = context.tRevision.Max(x => x.IdCaso) + 1;
                    string cons = "R-" + id.ToString();
                    txtConsecutivo.Text = cons;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AsignarCaso_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
            //Actualizar();
            CargarCombos();
            MostrarConsecutivo();
        }

        //Cambio de colores
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                this.BackColor = Colors.White;
                this.panel1.BackColor = Colors.White;
                this.panel2.BackColor = Colors.Blue;

                lbConsecutivo.ForeColor = Colors.DarkBack;
                lbCodigo.ForeColor = Colors.DarkBack;
                lbCircuiton.ForeColor = Colors.DarkBack;
                lbFecha.ForeColor = Colors.DarkBack;
                lbJunta.ForeColor = Colors.DarkBack;
                lbMedioReceptivo.ForeColor = Colors.DarkBack;
                lbAsignado.ForeColor = Colors.DarkBack;
            }
            else
            {

            }
        }


        private void AsignarCaso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                using (var context = new BDJuntasEntities())
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        int cod = int.Parse(txtCodigo.Text);

                        var codigo = context.tInstitucion.FirstOrDefault(x => x.Codigo == cod);

                        if (codigo != null)
                        {
                            txtJuntaAdm.Text = codigo.Nombre;
                            txtCircuito.Text = codigo.Circuito.ToString();
                        }
                        else
                        {
                            Alerta.Danger(new Alertas.Alerta(), $"El código {txtCodigo.Text} no existe");
                        }
                    }
                    else
                    {
                        Alerta.Danger(new Alertas.Alerta(), $"Falta llenar el código");
                    }
                }
            }
        }

        //Metodo de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tRevision revision = new tRevision();

                revision.Codigo = int.Parse(txtCodigo.Text);
                revision.Fecha = dtpFecha.Value;
                revision.Tramitador = cbAsignados.SelectedValue.ToString();
                revision.Recepcion = (int)cbTipoRecepcion.SelectedValue;
                revision.Comentario = "No tiene comentario";
                revision.Observacion = "No tiene observacion";
                revision.Estado = 2;
                revision.numeroActa = 0;
                revision.numeroFolio = 0;
                revision.fechaActa = null;

                if (Rnegocio.guardar(revision) == true)
                {
                    Alerta.Success(new Alertas.Alerta(), "Caso asignado");
                    MostrarConsecutivo();
                    txtCodigo.ResetText();
                }
                else
                {
                    Alerta.Success(new Alertas.Alerta(), "Error al asignar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
