using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    public class BoletaNegocio : ICrud<t_Boleta>
    {

        BoletaDatos datos = new BoletaDatos();

        public bool eliminar(t_Boleta e)
        {
            // e.estado = false;
            return datos.eliminar(e);
        }


        public bool guardar(t_Boleta e)
        {
            return datos.guardar(e);
        }


        public bool modificar(t_Boleta e)
        {
            return datos.modificar(e);
        }


        public t_Boleta obtenerPorId(t_Boleta e)
        {
            return datos.obtenerPorId(e);
        }


        public IEnumerable<t_Boleta> obtenerTodo(t_Boleta e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
