using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosRevision
    {
        public bool eliminar(t_Revision e)
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {

                    context.Entry<t_Revision>(e).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool guardar(t_Revision e)
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {

                    context.t_Revision.Add(e);
                    context.SaveChanges();

                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool modificar(t_Revision e)
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {

                    context.Entry<t_Revision>(e).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<t_Revision> obtenerTodo(t_Revision e)
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {

                    IQueryable<t_Revision> datos = (IQueryable<t_Revision>)context.t_Revision.ToList();

                    if (datos != null)
                    {
                        return datos;
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
