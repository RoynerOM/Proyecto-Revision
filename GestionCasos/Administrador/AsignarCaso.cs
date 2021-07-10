using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using Negocios;
using Datos;
using System.IO;
//using Utilidades.Enumerables;
using System.Data.SqlClient;

namespace GestionCasos

{
    public partial class AsignarCaso : Form
    {

        RevisionNegocio Rnegocio = new RevisionNegocio();
        ContadorNegocio persona = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        public AsignarCaso()
        {
            InitializeComponent();
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
                    var id = context.t_Revision.Max(x => x.Id_Caso)+1;
                    string cons = "R-"+id.ToString();
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
            //Actualizar();
            CargarCombos();
            MostrarConsecutivo();
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

        //Modificado
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            t_Revision revision = new t_Revision();

            revision.Codigo = int.Parse(txtCodigo.Text);
            revision.Fecha = DateTime.Parse(dtpFecha.Value.ToShortDateString());
            revision.Tramitador = cbAsignados.SelectedValue.ToString();
            revision.Recepcion = (int)cbTipoRecepcion.SelectedValue;
            revision.Estado = 1;
            revision.Comentario = "No tiene comentario";
            revision.Observacion = "No tiene observacion";
            revision.Estado = 1;

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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
