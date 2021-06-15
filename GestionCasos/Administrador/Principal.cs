using GestionCasos.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class Principal : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Principal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        Registrar llamarRegistrar = new Registrar();
        AsignarCaso llamarAsignarCaso = new AsignarCaso();
        private void Principal_Load(object sender, EventArgs e)
        {
            fDashBoard dashBoard = new fDashBoard();
            dashBoard.TopLevel = false;
            dashBoard.FormBorderStyle = FormBorderStyle.None;
            dashBoard.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(dashBoard);
            dashBoard.Show();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fContador(), sender);
        }
 
        private void btnAsignarCasos_Click(object sender, EventArgs e)
        {
            llamarAsignarCaso.Show();
            llamarAsignarCaso.TopMost = true;
        }

        private void btnDashBoard_MouseEnter(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(9, 12, 16);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(9,12,16);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnLateralIzquierda.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(33, 38, 45);
                }
            }
        }
        //Pintar formulario hijo
        //Formulario en uso
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDashBoard(), sender);
        }
    }

}
