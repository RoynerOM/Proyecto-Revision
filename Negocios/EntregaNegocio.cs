using Datos;
using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;
namespace Negocios
{
    public class EntregaNegocio : ICrud<tEntregaCasos>
    {
        readonly EntregaDatos datos = new EntregaDatos();
        public bool eliminar(tEntregaCasos e)
        {
            return datos.eliminar(e);
        }

        public bool guardarAsync(tEntregaCasos e)
        {
            return datos.guardarAsync(e);
        }

        public bool modificar(tEntregaCasos e)
        {
            return datos.modificar(e);
        }

        public tEntregaCasos obtenerPorId(tEntregaCasos e)
        {
            return datos.obtenerPorId(e);
        }

        public async Task<List<tEntregaCasos>> obtenerTodo()
        {
            return await datos.obtenerTodo();
        }

        //Funciones extras
        public async Task<tEntregaCasos> obtenerPorCasoAsync(string consecutivo)
        {
            return await datos.obtenerPorCasoAsync(consecutivo);
        }
    }
}
