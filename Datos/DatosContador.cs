using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using System.Linq;
namespace Datos
{
    public class DatosContador : ICrud<t_Contador>
    {
        public bool eliminar(t_Contador e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Contador>(e).State = System.Data.Entity.EntityState.Modified;
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
        public bool guardar(t_Contador e)
        {
            using (var db = new BD_JuntasEntities())
            {
                try
                {
                    db.t_Contador.Add(e);
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



        public bool modificar(t_Contador e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Contador>(e).State = System.Data.Entity.EntityState.Modified;
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
        public t_Contador obtenerPorId(t_Contador e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Contador where query.Cedula == e.Cedula select query).FirstOrDefault();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }



        //Metodo que para obtener la lista de los contadores
        public IEnumerable<t_Contador> obtenerTodo(t_Contador e)
        {

            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Contador select query).ToList();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int CantidadContadores()
        {
            return obtenerTodo(new t_Contador()).Count();
        }
    }
}
