using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
   public class RecepcionDatos : ICrud<t_Recepcion>
    {
        public bool eliminar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public t_Recepcion obtenerPorId(t_Recepcion e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Recepcion> obtenerTodo(t_Recepcion e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var lista = db.t_Recepcion.ToList();

                    if (lista != null)
                    {
                        return lista;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
