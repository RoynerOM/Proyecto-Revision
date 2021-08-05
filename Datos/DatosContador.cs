using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades.Interfaces;
namespace Datos
{
    //
    public class DatosContador : ICrud<tPersona>
    {
        public bool eliminar(tPersona e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tPersona>(e).State = System.Data.Entity.EntityState.Modified;
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
        public bool guardar(tPersona e)
        {
            using (var db = new BDJuntasEntities())
            {
                try
                {
                    db.tPersona.Add(e);
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

        public bool guardar(tMensajero e)
        {
            using (var db = new BDJuntasEntities())
            {
                try
                {
                    db.tMensajero.Add(e);
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

        public bool modificar(tPersona e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.Entry<tPersona>(e).State = System.Data.Entity.EntityState.Modified;
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
        public tPersona obtenerPorId(tPersona e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var p = db.tPersona.Where(x => x.Cedula == e.Cedula).SingleOrDefault();
                    if (p != null)
                    {
                        return p;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public tPersona obtenerPorId(string e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var datos = db.tPersona.Where(x => x.Cedula == e).SingleOrDefault();
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
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Metodo que para obtener la lista de los contadores
        public IEnumerable<tPersona> obtenerTodo(tPersona e)
        {

            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var p = db.tPersona.Where(x => x.Estado == true).ToList();
                    if (p != null)
                    {
                        return p;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Extras
        public bool GuardarTrabajador(tTrabajador e)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    db.tTrabajador.Add(e);
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
                using (var db = new BDJuntasEntities())
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
        public tMensajero obtenerMBy(string cedula)
        {
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = db.tMensajero.Where(x => x.CedulaMensajero == cedula).SingleOrDefault();
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
                using (var db = new BDJuntasEntities())
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


        public tTrabajador obtenerTrabador(string cedula)
        {
            /*
                1 normal
                0 admin
             */
            try
            {
                using (var db = new BDJuntasEntities())
                {
                    var consulta = db.tTrabajador.Where(x => x.Cedula == cedula).SingleOrDefault();
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
            return obtenerTodo(new tPersona()).Count();
        }
    }
}
