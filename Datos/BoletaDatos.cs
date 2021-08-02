using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class BoletaDatos : ICrud<tBoleta>
    {
        public bool eliminar(tBoleta e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tBoleta>(e).State = System.Data.Entity.EntityState.Modified;
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

        public bool guardar(tBoleta e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.tBoleta.Add(e);
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

        public bool modificar(tBoleta e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tBoleta>(e).State = System.Data.Entity.EntityState.Modified;
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

        public tBoleta obtenerPorId(tBoleta e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var boleta = db.tBoleta.Include("tRevision").Where(x => x.Id == e.Id).SingleOrDefault();

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

        public tBoleta obtenerPorId(int e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var boleta = db.tBoleta.Include("tRevision").Where(x => x.tRevision.IdCaso == e).SingleOrDefault();

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

        public tBoleta obtenerPorId(string e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var boleta = db.tBoleta.Include("tRevision").Where(x => x.tRevision.Consecutivo == e).SingleOrDefault();

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

        public IEnumerable<tBoleta> obtenerTodo(tBoleta e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var boleta = db.tBoleta.Include("tRevision").ToList();

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
