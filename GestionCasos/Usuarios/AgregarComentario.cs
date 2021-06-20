using System;
using System.Configuration;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos.Usuarios
{
    public partial class AgregarComentario : Form
    {
        public AgregarComentario()
        {
            InitializeComponent();

        }
        string isDark = ConfigurationManager.AppSettings["DarkMode"];

        private void SetThemeColor()
        {
            if (isDark == "false")
            {

                this.BackColor = Colors.White;
                this.ForeColor = Colors.Black;

                checkBox1.ForeColor = Colors.Black;
                checkBox2.ForeColor = Colors.Black;
                checkBox3.ForeColor = Colors.Black;
                checkBox4.ForeColor = Colors.Black;
                checkBox5.ForeColor = Colors.Black;
                checkBox8.ForeColor = Colors.Black;
                checkBox9.ForeColor = Colors.Black;
                checkBox10.ForeColor = Colors.Black;
                lblConsecutivo.ForeColor = Colors.Black;
                gunaLabel1.ForeColor = Colors.Black;
                label1.ForeColor = Colors.Black;
            }
            else
            {

            }
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarComentario_Load(object sender, EventArgs e)
        {
            SetThemeColor();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                gunaTextBox2.Visible = true;
            }
            else
            {
                gunaTextBox2.Visible = false;
            }
        }
    }
}
