using GestionCasos.Administrador;
using GestionCasos.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

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
        private void Principal_Load(object sender, EventArgs e)
        {
            SetPanelDefault();
            SetThemeColor();
            

        }

        private void SetPanelDefault()
        {
            Color color;
            fDashBoard dashBoard = new fDashBoard();
            dashBoard.TopLevel = false;
            dashBoard.FormBorderStyle = FormBorderStyle.None;
            dashBoard.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(dashBoard);
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                color = Colors.BlueHover;
            }
            else
            {
                color = Colors.DarkBack;
            }
            currentButton = this.btnDashBoard;
            currentButton.BackColor = color;
            dashBoard.Show();
        }
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                this.BackColor = Colors.White;
                this.DesktopPanel.BackColor = Colors.White;

                this.pnLateralIzquierda.BackColor = Colors.Blue;
                this.pnLateralIzquierda.ForeColor = Color.White;
            }
            else
            {

            }
        }


        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            this.Hide();

            login.Show();
        }



        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color;
                    if (ConfigurationManager.AppSettings["DarkMode"] == "false")
                    {
                        color = Colors.BlueHover;

                    }
                    else
                    {
                        color = Colors.DarkBack;
                    }
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
                    Color color;
                    if (ConfigurationManager.AppSettings["DarkMode"] == "false")
                    {
                        color = Colors.Blue;

                    }
                    else
                    {
                        color = Colors.DarkPanel;
                    }
                    previousBtn.BackColor = color;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Registrar(), sender);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fConfiguraciones(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMenu(), sender);
        }

    }

}
