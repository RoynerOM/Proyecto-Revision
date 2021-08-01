using GestionCasos.Usuarios;
using System;
using System.Windows.Forms;

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
            Application.Run(new Login());
        }

        /*
         
         el problema es la llave hay que hacer una clave compuesta
        hay que aplicar el mismo toque como las relacion provincia canton distrito

        el problema es que no pueden haber llaves foraneas repetidas
        hay que hacer una clave compuesta


        informacion del mensajero quitar entidad(metodo sucio xd)
         */
    }
}
