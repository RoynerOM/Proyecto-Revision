using System;
using System.Windows.Forms;
using GestionCasos.Administrador;
using GestionCasos.Usuarios;
namespace GestionCasos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  Login());
        }
    }
}
