using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<t_Persona>
    {
        readonly DatosContador contador = new DatosContador();
        public bool eliminar(t_Persona e)
        {
            //e.Estado == false;
            return contador.eliminar(e);
        }

        public bool guardar(t_Persona e)
        {
            return contador.guardar(e);
        }

        public bool guardar(t_Mensajero e)
        {
            return contador.guardar(e);
        }

        public bool modificar(t_Persona e)
        {
            return contador.modificar(e);
        }

        public t_Persona obtenerPorId(t_Persona e)
        {
            return contador.obtenerPorId(e);
        }

        public IEnumerable<t_Persona> obtenerTodo(t_Persona e)
        {
            return contador.obtenerTodo(e);
        }

        //Metodos fuera de la interfaz
        public int CantidadContadores()
        {
            return contador.CantidadContadores();
        }


        public bool GuardarTrabajador(t_Trabajador e)
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
        public t_Trabajador obtenerTrabador(string cedula)
        {
            return contador.obtenerTrabador(cedula);
        }
    }
}
