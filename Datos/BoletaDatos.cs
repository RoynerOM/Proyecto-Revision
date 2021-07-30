using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class BoletaDatos : ICrud<t_Boleta>
    {
        public bool eliminar(t_Boleta e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Boleta>(e).State = System.Data.Entity.EntityState.Modified;
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

        public bool guardar(t_Boleta e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.t_Boleta.Add(e);
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

        public bool modificar(t_Boleta e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Boleta>(e).State = System.Data.Entity.EntityState.Modified;
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

        public t_Boleta obtenerPorId(t_Boleta e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var boleta = db.t_Boleta.Include("t_Revision").Where(x => x.Id == e.Id).SingleOrDefault();

                    if (boleta != null)
                    {
                        return boleta;
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

        public t_Boleta obtenerPorId(int e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var boleta = db.t_Boleta.Include("t_Revision").Where(x => x.t_Revision.Id_Caso == e).SingleOrDefault();

                    if (boleta != null)
                    {
                        return boleta;
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

        public t_Boleta obtenerPorId(string e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var boleta = db.t_Boleta.Include("t_Revision").Where(x => x.t_Revision.Consecutivo == e).SingleOrDefault();

                    if (boleta != null)
                    {
                        return boleta;
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

        public IEnumerable<t_Boleta> obtenerTodo(t_Boleta e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var boleta = db.t_Boleta.Include("t_Revision").ToList();

                    if (boleta != null)
                    {
                        return boleta;
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
