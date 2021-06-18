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

namespace GestionCasos.Configuracion
{
    public partial class fConfiguraciones : Form
    {
        public fConfiguraciones()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ToggleSwitch1_Click(object sender, EventArgs e)
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
     

                            if (guna2ToggleSwitch1.Checked == false)
                            {
                                node.Attributes[1].Value = "false";
                                guna2ToggleSwitch1.Checked = false;

                            }
                            else
                            {
                                node.Attributes[1].Value = "true";
                                guna2ToggleSwitch1.Checked = true;
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

        private void fConfiguraciones_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                guna2ToggleSwitch1.Checked = false;
                this.panel1.BackColor = Color.White;
                this.label1.ForeColor = Color.FromArgb(9, 12, 16);
            }
            else
            {
                guna2ToggleSwitch1.Checked = true;
            }
        }
    }
}
