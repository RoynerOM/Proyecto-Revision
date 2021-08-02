using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class RecepcionDatos : ICrud<tRecepcion>
    {
        public bool eliminar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public tRecepcion obtenerPorId(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tRecepcion> obtenerTodo(tRecepcion e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var lista = db.tRecepcion.ToList();

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
