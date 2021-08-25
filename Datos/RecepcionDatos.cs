using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
    public class RecepcionDatos : ICrud<tRecepcion>
    {
        public bool eliminar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardarAsync(tRecepcion e)
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

        public async Task<List<tRecepcion>> obtenerTodo()
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var lista = await db.tRecepcion.ToListAsync();

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
