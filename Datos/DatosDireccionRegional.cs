using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using System.Linq;
namespace Datos
{
    public class DatosDireccionRegional : ICrud<t_Direccion_Regional>
    {
        public bool eliminar(t_Direccion_Regional e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Direccion_Regional>(e).State = System.Data.Entity.EntityState.Modified;
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

        public bool guardar(t_Direccion_Regional e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.t_Direccion_Regional.Add(e);
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

        public bool modificar(t_Direccion_Regional e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Direccion_Regional>(e).State = System.Data.Entity.EntityState.Modified;
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

        public t_Direccion_Regional obtenerPorId(t_Direccion_Regional e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                   IQueryable<t_Direccion_Regional> consulta =  db.t_Direccion_Regional;
                    if (consulta != null)
                    {
                        return (t_Direccion_Regional)consulta;
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

        public IEnumerable<t_Direccion_Regional> obtenerTodo(t_Direccion_Regional e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    IQueryable<t_Direccion_Regional> consulta = db.t_Direccion_Regional;
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
