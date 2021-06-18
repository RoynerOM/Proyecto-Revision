using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;
using Utilidades.Interfaces;
using System.Windows.Forms;


namespace Negocios
{
    //Plantilla
    public class UsuarioNegocio : ICrud<t_Usuario>
    {
        DatosUsuario datosUsuario = new DatosUsuario();
        showMessageDialog Message = new showMessageDialog();


        public bool eliminar(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Usuario e)
        {
            return datosUsuario.guardar(e);
        }

        public bool ComprobarCedula(string ced)
        {

            using (BD_JuntasEntities context = new BD_JuntasEntities())
            {
                var cedula = context.t_Contador.FirstOrDefault(x => x.Cedula == ced);
                var v_cedula = context.t_Usuario.FirstOrDefault(x => x.Cedula == ced);

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

        public bool modificar(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public t_Usuario obtenerPorId(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Usuario> obtenerTodo(t_Usuario e)
        {
            throw new NotImplementedException();
        }
    }
}
