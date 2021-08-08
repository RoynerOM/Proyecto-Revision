using Datos;
using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;
namespace Negocios
{
    //Plantilla
    public class InstitucionNegocio : ICrud<tInstitucion>
    {
        readonly DatosInstitucion datos = new DatosInstitucion();
        public bool eliminar(tInstitucion e)
        {
            e.Estado = false;
            return datos.eliminar(e);
        }

        public bool guardarAsync(tInstitucion e)
        {
            return datos.guardarAsync(e);
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

        public async Task<List<tInstitucion>> obtenerTodo()
        {
            return await datos.obtenerTodo();
        }
    }
}
