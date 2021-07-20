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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace GestionCasos
{
    public partial class Principal : Form
    {
        private Button currentButton;
        private Form activeForm;
        private int Rol = 0;
        public Principal(int role)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Rol = role;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            SetPanelDefault();
            SetThemeColor();
        }

        private void SetPanelDefault()
        {
            Color color;
            fDashBoard dashBoard = new fDashBoard(Rol);
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
                BackColor = Colors.White;
                DesktopPanel.BackColor = Colors.White;

                pnLateralIzquierda.BackColor = Colors.Blue;
                pnLateralIzquierda.ForeColor = Color.White;
                btnDashBoard.FlatAppearance.MouseOverBackColor = Colors.BlueHover;
                btnMenu.FlatAppearance.MouseOverBackColor = Colors.BlueHover;
            }
            else
            {
                BackColor = Colors.DarkBack;
                DesktopPanel.BackColor = Colors.DarkBack;

                pnLateralIzquierda.BackColor = Colors.DarkPanel;
                pnLateralIzquierda.ForeColor = Color.White;

                btnDashBoard.FlatAppearance.MouseOverBackColor = Colors.DarkHover;
                btnMenu.FlatAppearance.MouseOverBackColor = Colors.DarkHover;
            }
        }


        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            this.Hide();

            login.Show();
        }


        //Cuando el boton esta en uso
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


        //Caundo el boton no esta en uso
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
            DatosTemp.Form = childForm;
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


        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            DatosTemp.Form = childForm;
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
            OpenChildForm(new fDashBoard(Rol), sender);
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
