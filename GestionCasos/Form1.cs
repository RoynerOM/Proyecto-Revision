using GestionCasos.Alertas;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Utilidades;

namespace GestionCasos
{
    public partial class Form1 : Form
    {

        showMessageDialog Message = new showMessageDialog();

        public Form1()
        {
            InitializeComponent();

            
        }

        //Success
        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Message.Success(new Alerta(), "Esto es un mensaje de prueba usando success");
        }

        //
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Message.Warning(new Alerta(), "Hola mundo");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Message.Danger(new Alerta(), "Esto es un mensaje de prueba usando danger");
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Message.Info(new Alerta(), "Hola mundo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string d = ConfigurationManager.AppSettings["DarkMode"];
            MessageBox.Show(d);
            if (d == "false")
            {
                this.BackColor = Color.White;
                this.button1.Image = GestionCasos.Properties.Resources.light_dimming_off_48px1;
                this.button1.BackColor = Color.White;
                this.button1.ForeColor = Color.Black;
            }
            else if(d=="true")
            {
                this.BackColor = Color.Black;
                this.button1.Image = GestionCasos.Properties.Resources.light_dimming_off_48px;
                this.button1.BackColor = Color.White;
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(33, 38, 45);
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Documentacion para dark mode
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
                            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
                            {
                                node.Attributes[1].Value = "true";
                            }
                            else
                            {
                                node.Attributes[1].Value = "false";
                            }
                        }
                    }
                }
            }
            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
