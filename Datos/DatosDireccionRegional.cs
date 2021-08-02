using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;
namespace Datos
{
    public class DatosDireccionRegional : ICrud<tDireccionRegional>
    {
        public bool eliminar(tDireccionRegional e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tDireccionRegional>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;
            }
        }

        public bool guardar(tDireccionRegional e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.tDireccionRegional.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;
            }
        }

        public bool modificar(tDireccionRegional e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tDireccionRegional>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;
            }
        }

        public tDireccionRegional obtenerPorId(tDireccionRegional e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    IQueryable<tDireccionRegional> consulta = db.tDireccionRegional;
                    if (consulta != null)
                    {
                        return (tDireccionRegional)consulta;
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

        public IEnumerable<tDireccionRegional> obtenerTodo(tDireccionRegional e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    IQueryable<tDireccionRegional> consulta = db.tDireccionRegional;
                    if (consulta != null)
                    {
                        return consulta.ToList();
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
