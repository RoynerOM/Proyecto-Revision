using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
    public class EstadoDatos : ICrud<Estado>
    {
        public bool eliminar(Estado e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(Estado e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(Estado e)
        {
            throw new NotImplementedException();
        }

        public Estado obtenerPorId(Estado e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var filtro = db.Estado.Where(x => x.id == e.id).SingleOrDefault();
                    return filtro;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<Estado> obtenerTodo(Estado e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var lista = db.Estado.ToList();

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
