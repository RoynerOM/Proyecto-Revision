using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interfaces;
using System.Data.Entity;
namespace Datos
{
    public class EntregaDatos : ICrud<tEntregaCasos>
    {
        public bool eliminar(tEntregaCasos e)
        {
            throw new NotImplementedException();
        }

        //  Metodo de guardar la informacion de la entrega
        public bool guardarAsync(tEntregaCasos e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.tEntregaCasos.Add(e);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Entrega de casos: " + ex);
                return false;
            }
        }

        public bool modificar(tEntregaCasos e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tEntregaCasos>(e).State = System.Data.Entity.EntityState.Modified;
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

        public tEntregaCasos obtenerPorId(tEntregaCasos e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = db.tEntregaCasos.Include("tPersona")
                                                    .Include("tRevision")
                                                    .Include("tRecepcion")
                                                    .Where(x => x.Id == e.Id).SingleOrDefault();
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

                Console.WriteLine(ex);
                return null;
            }
        }

        public Task<List<tEntregaCasos>> obtenerTodo()
        {
            throw new NotImplementedException();
        }


        //Funciones extras
        public async Task<tEntregaCasos> obtenerPorCasoAsync(string consecutivo)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = await db.tEntregaCasos.Include("tRevision")
                                                    .Include("tMensajero")
                                                    .Where(x => x.tRevision.Consecutivo == consecutivo).SingleOrDefaultAsync();
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

                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
