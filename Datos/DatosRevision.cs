using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosRevision : ICrud<tRevision>
    {
        public bool eliminar(tRevision e)
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {

                    context.Entry<tRevision>(e).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool guardarAsync(tRevision e)
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {
                    context.tRevision.Add(e);
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

        public bool modificar(tRevision e)
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {

                    context.Entry<tRevision>(e).State = System.Data.Entity.EntityState.Modified;
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

        public async Task<List<tRevision>> obtenerTodo()
        {
            try
            {
                using (var context = new BDJuntasEntities())
                {

                    var datos = await context.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").ToListAsync();

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

        public tRevision ObtenerPorCaso(string consecutivo)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var caso = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").Where(x => x.Consecutivo.StartsWith(consecutivo.ToUpper())).SingleOrDefault();

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
        public IEnumerable<tRevision> obtenerPorConsecutivo(string consecutivo)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var caso = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").Where(x => x.Consecutivo.StartsWith(consecutivo.ToUpper())).ToList();

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
        public IEnumerable<tRevision> obtenerPorContador(string persona)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var casos = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").Where(x => x.Tramitador == persona).ToList();

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
        public tRevision obtenerPorId(tRevision e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var caso = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").FirstOrDefault(x => x.IdCaso == e.IdCaso);

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


        //Filter by tEstado
        public IEnumerable<tRevision> FilterBy(int estado)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var caso = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").Where(x => x.Estado == estado).ToList();

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
        public IEnumerable<tRevision> FilterBy(int recepcion, int opc = 0)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var caso = db.tRevision.Include("tPersona").Include("tEstado").Include("tInstitucion").Include("tRecepcion").Where(x => x.Recepcion == recepcion).ToList();

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
