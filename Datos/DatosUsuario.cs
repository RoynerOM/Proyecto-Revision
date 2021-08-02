using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosUsuario : ICrud<tUsuario>
    {
        public bool eliminar(tUsuario e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(tUsuario e)
        {
            using (var context = new BDJuntasEntities())
            {
                try
                {
                    context.tUsuario.Add(e);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public bool modificar(tUsuario e)
        {
            throw new NotImplementedException();
        }

        public tUsuario obtenerPorId(tUsuario e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tUsuario> obtenerTodo(tUsuario e)
        {
            throw new NotImplementedException();
        }
    }
}
