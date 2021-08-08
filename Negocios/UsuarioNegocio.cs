using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Interfaces;


namespace Negocios
{
    //Plantilla
    public class UsuarioNegocio : ICrud<tUsuario>
    {
        readonly DatosUsuario datosUsuario = new DatosUsuario();

        public bool eliminar(tUsuario e)
        {
            throw new NotImplementedException();
        }


        public bool guardarAsync(tUsuario e)
        {
            return datosUsuario.guardarAsync(e);
        }


        public bool ComprobarCedula(string ced)
        {

            using (BDJuntasEntities context = new BDJuntasEntities())
            {
                var cedula = context.tPersona.FirstOrDefault(x => x.Cedula == ced && x.Estado == true);
                var v_cedula = context.tUsuario.FirstOrDefault(x => x.Cedula == ced);

                if (cedula != null && v_cedula == null)
                {
                    return true;
                }
                else
                {
                    //Message.Danger(new Alertas.Alerta(), "No se pudo registrar el usuario");
                    MessageBox.Show("La cedula digitada no coincide con una cedula de algun contador, compruebe la cedula y vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

            }
        }


        public bool modificar(tUsuario e)
        {
            return datosUsuario.modificar(e);
        }


        public tUsuario obtenerPorId(tUsuario e)
        {
            throw new NotImplementedException();
        }


        public tUsuario obtenerPorId(string e)
        {
            return datosUsuario.obtenerPorId(e);
        }


        public Task<List<tUsuario>> obtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
