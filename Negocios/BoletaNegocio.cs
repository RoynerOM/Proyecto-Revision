using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    public class BoletaNegocio : ICrud<tBoleta>
    {

        BoletaDatos datos = new BoletaDatos();

        public bool eliminar(tBoleta e)
        {
            // e.estado = false;
            return datos.eliminar(e);
        }


        public bool guardar(tBoleta e)
        {
            return datos.guardar(e);
        }


        public bool modificar(tBoleta e)
        {
            return datos.modificar(e);
        }


        public tBoleta obtenerPorId(tBoleta e)
        {
            return datos.obtenerPorId(e);
        }

        public tBoleta obtenerPorId(string e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<tBoleta> obtenerTodo(tBoleta e)
        {
            return datos.obtenerTodo(e);
        }

        public tBoleta obtenerPorId(int caso)
        {
            return datos.obtenerPorId(caso);
        }
    }
}
