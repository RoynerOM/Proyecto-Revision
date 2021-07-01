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
using System.Xml;
using Utilidades;

namespace GestionCasos.Administrador
{
    public partial class fMenu : Form
    {
        private Form activeForm;

        public fMenu()
        {
            InitializeComponent();
            SetColorTheme();
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

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fContador());
        }

        private void btnContadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fInstituciones());
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AsignarCaso());
        }
        void SetColorTheme()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                gunaTileButton4.Image = global::GestionCasos.Properties.Resources.sun_60px;
                gunaTileButton4.Text = "Modo Claro";
            }
            else
            {
                gunaTileButton4.Image = global::GestionCasos.Properties.Resources.new_moon_60px;
                gunaTileButton4.Text = "Modo Oscuro";
            }
        }
        private void gunaTileButton4_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xml.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "DarkMode")
                        {


                            if (ConfigurationManager.AppSettings["DarkMode"] == "true")
                            {
                                node.Attributes[1].Value = "false";
                            }
                            else
                            {
                                node.Attributes[1].Value = "true";
                            }
                            showMessageDialog messageDialog = new showMessageDialog();
                            messageDialog.Warning(new Alertas.Alerta(), "Debe reiniciar la aplicacion para aplicar los cambios");
                        }
                    }
                }
            }

            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
