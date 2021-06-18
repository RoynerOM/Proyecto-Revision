using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosRevision
    {
        public bool eliminar(t_Revision e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Revision e)
        {
            using (var context = new BD_JuntasEntities())
            {
                try
                {
                    context.t_Revision.Add(e);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }

        public bool modificar(t_Revision e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Revision> obtenerTodo(t_Revision e)
        {
            throw new NotImplementedException();
        }
    }
}
