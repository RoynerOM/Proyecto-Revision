using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
    public class EstadoDatos : ICrud<tEstado>
    {
        public bool eliminar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public bool guardarAsync(tEstado e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public tEstado obtenerPorId(tEstado e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var filtro = db.tEstado.Where(x => x.IdEstado == e.IdEstado).SingleOrDefault();
                    return filtro;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<List<tEstado>> obtenerTodo()
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var lista = await db.tEstado.ToListAsync();

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
            catch (Exception)
            {

                return null;
            }
        }
    }
}
