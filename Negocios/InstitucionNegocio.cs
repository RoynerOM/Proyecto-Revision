using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    //Plantilla
    public class InstitucionNegocio : ICrud<tInstitucion>
    {
        DatosInstitucion datos = new DatosInstitucion();
        public bool eliminar(tInstitucion e)
        {
            e.Estado = false;
            return datos.eliminar(e);
        }

        public bool guardar(tInstitucion e)
        {
            return datos.guardar(e);
        }

        public bool modificar(tInstitucion e)
        {
            return datos.modificar(e);
        }

        public tInstitucion obtenerPorId(int e)
        {
            return datos.obtenerPorId(e);
        }

        public tInstitucion obtenerPorId(tInstitucion e)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<tInstitucion> obtenerTodo(tInstitucion e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
