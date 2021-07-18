using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Utilidades.Interfaces;
namespace Datos
{
    public class EntregaDatos : ICrud<t_EntregaCasos>
    {
        public bool eliminar(t_EntregaCasos e)
        {
            throw new NotImplementedException();
        }

        //  Metodo de guardar la informacion de la entrega
        public bool guardar(t_EntregaCasos e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.t_EntregaCasos.Add(e);
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

        public bool modificar(t_EntregaCasos e)
        {
            throw new NotImplementedException();
        }

        public t_EntregaCasos obtenerPorId(t_EntregaCasos e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var consulta = db.t_EntregaCasos.Include("t_Persona")
                                                    .Include("t_Revision")
                                                    .Include("t_Recepcion")
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

        public IEnumerable<t_EntregaCasos> obtenerTodo(t_EntregaCasos e)
        {
            throw new NotImplementedException();
        }


        //Funciones extras
        public t_EntregaCasos obtenerPorCaso(string consecutivo)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var consulta = db.t_EntregaCasos.Include("t_Persona")
                                                    .Include("t_Revision")
                                                    .Include("t_Recepcion")
                                                    .Where(x => x.t_Revision.Consecutivo == consecutivo).SingleOrDefault();
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
