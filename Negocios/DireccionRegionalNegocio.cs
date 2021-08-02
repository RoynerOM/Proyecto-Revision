using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    //Plantilla
    public class DireccionRegionalNegocio : ICrud<tDireccionRegional>
    {
        DatosDireccionRegional datos = new DatosDireccionRegional();
        public bool eliminar(tDireccionRegional e)
        {
            return datos.eliminar(e);
        }

        public bool guardar(tDireccionRegional e)
        {
            return datos.guardar(e);
        }

        public bool modificar(tDireccionRegional e)
        {
            return datos.modificar(e);
        }

        public tDireccionRegional obtenerPorId(tDireccionRegional e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<tDireccionRegional> obtenerTodo(tDireccionRegional e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
