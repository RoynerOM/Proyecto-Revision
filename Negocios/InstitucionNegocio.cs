using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    //Plantilla
    public class InstitucionNegocio : ICrud<t_Institucion>
    {
        DatosInstitucion datos = new DatosInstitucion();
        public bool eliminar(t_Institucion e)
        {
            e.Estado = false;
            return datos.eliminar(e);
        }

        public bool guardar(t_Institucion e)
        {
            return datos.guardar(e);
        }

        public bool modificar(t_Institucion e)
        {
            return datos.modificar(e);
        }

        public t_Institucion obtenerPorId(int e)
        {
            return datos.obtenerPorId(e);
        }

        public t_Institucion obtenerPorId(t_Institucion e)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<t_Institucion> obtenerTodo(t_Institucion e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
