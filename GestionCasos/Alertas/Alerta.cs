using System;
using System.Windows.Forms;
using Utilidades;
namespace GestionCasos.Alertas
{
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();
        }

        private void Alerta_Load(object sender, EventArgs e)
        {

            if (Params.Icon == 1)
            {
                btnOK.Image = global::GestionCasos.Properties.Resources.okpx;
            }
            else
            {
                btnOK.Image = global::GestionCasos.Properties.Resources.error_60px;
            }
            label1.Text = Params.Message;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >= 5500)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
