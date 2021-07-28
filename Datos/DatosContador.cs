using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;
namespace Datos
{
    //
    public class DatosContador : ICrud<t_Persona>
    {
        public bool eliminar(t_Persona e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Persona>(e).State = System.Data.Entity.EntityState.Modified;
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



        //Metodo de Guardar un contador
        public bool guardar(t_Persona e)
        {
            using (var db = new BD_JuntasEntities())
            {
                try
                {
                    db.t_Persona.Add(e);
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

        public bool guardar(t_Mensajero e)
        {
            using (var db = new BD_JuntasEntities())
            {
                try
                {
                    db.t_Mensajero.Add(e);
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

        public bool modificar(t_Persona e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Persona>(e).State = System.Data.Entity.EntityState.Modified;
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



        //Metodo de obtener contador por cedula
        public t_Persona obtenerPorId(t_Persona e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Persona where query.Cedula == e.Cedula select query).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }



        //Metodo que para obtener la lista de los contadores
        public IEnumerable<t_Persona> obtenerTodo(t_Persona e)
        {

            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Persona select query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Extras
        public bool GuardarTrabajador(t_Trabajador e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.t_Trabajador.Add(e);
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

        /*
              0 normal
              1 admin
        este se usa en el formulario de entrega
           */
        public viewTrabajador obtenerTrabadorBy(string cedula)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var consulta = db.viewTrabajador.Where(x => x.Cedula == cedula).SingleOrDefault();
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

        public IEnumerable<viewTrabajador> obtenerTrabador(int tipo)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var consulta = db.viewTrabajador.Where(x => x.Tipo == tipo).ToList();
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


        public t_Trabajador obtenerTrabador(string cedula)
        {
            /*
                1 normal
                0 admin
             */
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    var consulta = db.t_Trabajador.Where(x => x.Cedula == cedula).SingleOrDefault();
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

        public int CantidadContadores()
        {
            return obtenerTodo(new t_Persona()).Count();
        }
    }
}
