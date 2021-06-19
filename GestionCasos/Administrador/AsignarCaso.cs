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

namespace GestionCasos

{
    public partial class AsignarCaso : Form
    {

        RevisionNegocio rnegocio = new RevisionNegocio();
        public AsignarCaso()
        {
            InitializeComponent();
        }

        private void AsignarCaso_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void AsignarCaso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
