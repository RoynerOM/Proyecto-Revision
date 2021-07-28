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
        private Form activeForm = null;
        public AsignarCaso()
        {
            InitializeComponent();
            SetThemeColor();
        }

        //Modificado
        private void CargarCombos()
        {


            cbAsignados.DataSource = persona.obtenerTodo(new t_Persona());
            cbAsignados.DisplayMember = "Nombre_Completo";
            cbAsignados.ValueMember = "Cedula";


            //Modificado
            cbTipoRecepcion.DataSource = recepcion.obtenerTodo(new t_Recepcion());
            cbTipoRecepcion.ValueMember = "id";
            cbTipoRecepcion.DisplayMember = "Nombre";


        }

        //Modificado
        private void MostrarConsecutivo()
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {
                    var id = context.t_Revision.Max(x => x.Id_Caso) + 1;
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
        //private void Actualizar()
        //{
        //    try
        //    {
        //        t_Revision rev = new t_Revision();
        //        using (BD_JuntasEntities con = new BD_JuntasEntities())
        //        {

        //            rev = con.t_Revision.First(x => x.Id_Caso == 1);

        //            rev.Contador = "1-1111-1111";

        //            con.Entry<t_Revision>(rev).State = System.Data.Entity.EntityState.Modified;
        //            con.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());

        //    }
        //}

        private void AsignarCaso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                using (BD_JuntasEntities context = new BD_JuntasEntities())
                {

                    if (txtCodigo.Text != string.Empty)
                    {
                        int cod = int.Parse(txtCodigo.Text);

                        var codigo = context.t_Institucion.FirstOrDefault(x => x.Codigo == cod);

                        if (codigo != null)
                        {
                            txtJuntaAdm.Text = codigo.Nombre;
                            txtCircuito.Text = codigo.Circuito.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"El codigo {txtCodigo.Text} no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta llenar el codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }


        }

        //Metodo de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                t_Revision revision = new t_Revision();

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
                    MessageBox.Show("Caso asignado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarConsecutivo();

                }
                else
                {
                    MessageBox.Show("Error al asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
