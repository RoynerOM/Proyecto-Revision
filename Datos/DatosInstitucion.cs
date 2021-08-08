using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;
namespace Datos
{
    public class DatosInstitucion : ICrud<tInstitucion>
    {
        public bool eliminar(tInstitucion e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tInstitucion>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool guardarAsync(tInstitucion e)
        {
            using (var db = new BDJuntasEntities())
            {
                try
                {
                    db.tInstitucion.Add(e);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool modificar(tInstitucion e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tInstitucion>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public tInstitucion obtenerPorId(int e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = db.tInstitucion.Include("tPersona").Include("tTipoInstitucion").Where(x => x.Codigo == e && x.Estado == true).SingleOrDefault();
                    if (consulta != null)
                    {
                        return consulta;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public tInstitucion obtenerPorId(tInstitucion e)
        {
            throw new NotImplementedException();
        }

        public async Task<List<tInstitucion>> obtenerTodo()
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = await db.tInstitucion.Include("tPersona").Include("tTipoInstitucion").Where(x => x.Estado == true).ToListAsync();
                    if (consulta != null)
                    {
                        return consulta;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
