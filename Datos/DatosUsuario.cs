using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;
namespace Datos
{
    public class DatosUsuario : ICrud<tUsuario>
    {
        public bool eliminar(tUsuario e)
        {
            throw new NotImplementedException();
        }

        public bool guardarAsync(tUsuario e)
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
            using (var context = new BDJuntasEntities())
            {
                try
                {
                    context.Entry<tUsuario>(e).State =  System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public tUsuario obtenerPorId(tUsuario e)
        {
            throw new NotImplementedException();
        }
        public tUsuario obtenerPorId(string e)
        {
            using (var db = new BDJuntasEntities())
            {
                try
                {
                    var u = db.tUsuario.Include("tPersona").Where(x => x.Cedula == e && x.tPersona.Estado == true).SingleOrDefault();
                    if (u != null)
                    {
                        return u;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }

            }
        }
        public Task<List<tUsuario>> obtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
