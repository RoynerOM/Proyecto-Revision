using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<tPersona>
    {
        readonly DatosContador contador = new DatosContador();
        public bool eliminar(tPersona e)
        {
            e.Estado = false;
            return contador.eliminar(e);
        }

        public bool guardar(tPersona e)
        {
            return contador.guardar(e);
        }

        public bool guardar(tMensajero e)
        {
          
            return contador.guardar(e);
        }

        public bool modificar(tPersona e)
        {
            return contador.modificar(e);
        }

        public tPersona obtenerPorId(tPersona e)
        {
            return contador.obtenerPorId(e);
        }
        public tPersona obtenerPorId(string e)
        {
            return contador.obtenerPorId(e);
        }
        public IEnumerable<tPersona> obtenerTodo(tPersona e)
        {
            return contador.obtenerTodo(e);
        }

        //Metodos fuera de la interfaz
        public int CantidadContadores()
        {
            return contador.CantidadContadores();
        }


        public bool GuardarTrabajador(tTrabajador e)
        {

            return contador.GuardarTrabajador(e);
        }

        public IEnumerable<viewTrabajador> obtenerTrabador(int tipo)
        {
            return contador.obtenerTrabador(tipo);
        }
        public viewTrabajador obtenerTrabadorBy(string cedula)
        {
            return contador.obtenerTrabadorBy(cedula);
        }
        public tMensajero obtenerMBy(string cedula)
        {
            return contador.obtenerMBy(cedula);
        }
        public tTrabajador obtenerTrabador(string cedula)
        {
            return contador.obtenerTrabador(cedula);
        }
    }
}
