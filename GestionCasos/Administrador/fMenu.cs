﻿using GestionCasos.Reportes;
using GestionCasos.Usuarios;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Utilidades;
using Utilidades.Enumerables;

namespace GestionCasos.Administrador
{
    public partial class fMenu : Form
    {
        SqlConnection conexion = new SqlConnection(@"data source=192.168.100.76;initial catalog=BDJuntas;user id=sa;password=123456;MultipleActiveResultSets=True;");
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        private Form activeForm;
        private int Rol;
        showMessageDialog Alerta = new showMessageDialog();
        public fMenu(int Rol)
        {
            this.Rol = Rol;
            InitializeComponent();

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


        private void OpcionesPermitidas()
        {
            if (Rol == 1)
            {
                btnCasos.Visible = false;
                btnCasos.Enabled = false;
                btnReportes.Visible = false;
                btnReportes.Enabled = false;
                btnContadores.Enabled = false;
                btnContadores.Visible = false;

            }
            else
            {
                btnCasos.Visible = true;
                btnCasos.Enabled = true;
                btnReportes.Visible = false;
                btnReportes.Enabled = false;
                btnContadores.Enabled = true;
                btnContadores.Visible = true;
            }
        }



        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fContador(Rol));
        }



        private void btnContadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fInstituciones(Rol));
        }



        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AsignarCaso());
        }



        private void SetThemeColor()
        {
            if (isDark == "false")
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
                btnEntregas.BaseColor = Colors.Blue;
                this.BackColor = Colors.White;
                btnContadores.OnHoverBaseColor = Colors.BlueHover;
                btnCasos.OnHoverBaseColor = Colors.BlueHover;
                btnMode.OnHoverBaseColor = Colors.BlueHover;
                btnReportes.OnHoverBaseColor = Colors.BlueHover;
                btnJuntas.OnHoverBaseColor = Colors.BlueHover;
                btnBackup.OnHoverBaseColor = Colors.BlueHover;
                btnEntregas.OnHoverBaseColor = Colors.BlueHover;
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
            OpcionesPermitidas();
        }



        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOpcionesReportes(Rol));
        }



        private void btnBackup_Click(object sender, EventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "DBJuntas.bak");

            string comando_consulta = "BACKUP DATABASE [BDJuntas] TO  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'BDJuntas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                Alerta.Success(new Alertas.Alerta(), "La copia de la base de datos fue creada");
            }
            catch (Exception ex)
            {
                Alerta.Danger(new Alertas.Alerta(), "No se creo la base de datos");
                Alerta.Danger(new Alertas.Alerta(), ex.Message);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }



        private void btnEntregas_Click(object sender, EventArgs e)
        {
            if (Rol == (int)Enums.Tipo.Tramitador)
            {
                OpenChildForm(new CasosAsignados(true));
            }
            else
            {
                OpenChildForm(new fCasosAdmin(true));
            }
        }
    }
}
