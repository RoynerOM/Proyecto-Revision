using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    //Plantilla
    public class DireccionRegionalNegocio : ICrud<t_Direccion_Regional>
    {
        DatosDireccionRegional datos = new DatosDireccionRegional();
        public bool eliminar(t_Direccion_Regional e)
        {
            return datos.eliminar(e);
        }

        public bool guardar(t_Direccion_Regional e)
        {
            return datos.guardar(e);
        }

        public bool modificar(t_Direccion_Regional e)
        {
            return datos.modificar(e);
        }

        public t_Direccion_Regional obtenerPorId(t_Direccion_Regional e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<t_Direccion_Regional> obtenerTodo(t_Direccion_Regional e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
