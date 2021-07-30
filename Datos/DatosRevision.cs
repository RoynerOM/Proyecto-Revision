using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosRevision : ICrud<t_Revision>
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public IEnumerable<t_Revision> obtenerTodo(t_Revision e)
        {
            try
            {
                using (var context = new BD_JuntasEntities())
                {

                    var datos = context.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").ToList();

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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public t_Revision ObtenerPorCaso(string consecutivo)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var caso = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").Where(x => x.Consecutivo.StartsWith(consecutivo.ToUpper())).SingleOrDefault();

                    if (caso != null)
                    {
                        return caso;
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

        //Extras
        //Filter by onsecutivo
        public IEnumerable<t_Revision> obtenerPorConsecutivo(string consecutivo)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var caso = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").Where(x => x.Consecutivo.StartsWith(consecutivo.ToUpper())).ToList();

                    if (caso != null)
                    {
                        return caso;
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

        //Filter by Persona
        public IEnumerable<t_Revision> obtenerPorContador(string persona)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var casos = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").Where(x => x.Tramitador == persona).ToList();

                    if (casos != null)
                    {
                        return casos;
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

        //Filter by id caso
        public t_Revision obtenerPorId(t_Revision e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var caso = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").FirstOrDefault(x => x.Id_Caso == e.Id_Caso);

                    if (caso != null)
                    {
                        return caso;
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


        //Filter by estado
        public IEnumerable<t_Revision> FilterBy(int estado)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var caso = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").Where(x => x.Estado == estado).ToList();

                    if (caso != null)
                    {
                        return caso;
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

        //Extras
        //Filter by onsecutivo
        public IEnumerable<t_Revision> FilterBy(int recepcion,int opc = 0)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var caso = db.t_Revision.Include("t_Persona").Include("Estado1").Include("t_Institucion").Include("t_Recepcion").Where(x => x.Recepcion == recepcion).ToList();

                    if (caso != null)
                    {
                        return caso;
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
