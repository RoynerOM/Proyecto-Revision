﻿using System;
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
using System.Xml;
using Utilidades;
using GestionCasos.Reportes;
using System.Data.SqlClient;
using System.Diagnostics;

namespace GestionCasos.Administrador
{
    public partial class fMenu : Form
    {
        SqlConnection conexion = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=BD_Juntas;integrated security=True;MultipleActiveResultSets=True;");

        private Form activeForm;
        private int Rol = 0;
        public fMenu(int Rol)
        {
            InitializeComponent();
            this.Rol = Rol;
            SetThemeColor();

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


        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                btnMode.Image = global::GestionCasos.Properties.Resources.sun_60px;
                btnMode.Text = "Modo Claro";

                flowLayoutPanel1.BackColor = Colors.White;

                btnContadores.BaseColor = Colors.Blue;
                btnCasos.BaseColor = Colors.Blue;
                btnMode.BaseColor = Colors.Blue;
                btnReportes.BaseColor = Colors.Blue;
                btnJuntas.BaseColor = Colors.Blue;
                btnBackup.BaseColor = Colors.Blue;

                btnContadores.OnHoverBaseColor = Colors.BlueHover;
                btnCasos.OnHoverBaseColor = Colors.BlueHover;
                btnMode.OnHoverBaseColor = Colors.BlueHover;
                btnReportes.OnHoverBaseColor = Colors.BlueHover;
                btnJuntas.OnHoverBaseColor = Colors.BlueHover;
                btnBackup.OnHoverBaseColor = Colors.BlueHover;
            }
            else
            {
                btnMode.Image = global::GestionCasos.Properties.Resources.new_moon_60px;
                btnMode.Text = "Modo Oscuro";
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
                            messageDialog.Warning(new Alertas.Alerta(), "La aplicación se cerrará para aplicar los cambios");

                            ProcessStartInfo Info = new ProcessStartInfo();
                            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                            Info.WindowStyle = ProcessWindowStyle.Hidden;
                            Info.CreateNoWindow = true;
                            Info.FileName = "cmd.exe";
                            Process.Start(Info);
                            Application.Exit();
                        }
                    }
                }
            }

            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }


        private void fMenu_Load(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            Thread hilo = new Thread(new ThreadStart(proceso.ProcesoInicial));   // Creamos el subproceso
            hilo.Start();                           // Ejecutamos el subproceso
            while (!hilo.IsAlive) ;
            OpenChildForm(new fLoader(1, hilo));
        }


        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOpcionesReportes(Rol));
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "DBJuntas");

            string comando_consulta = "BACKUP DATABASE [BD_Juntas] TO  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'BD_Juntas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia de la base de datos fue creada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

        }
    }
}
