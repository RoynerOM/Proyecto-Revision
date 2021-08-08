using Datos;
using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;
namespace Negocios
{
    public class BoletaNegocio : ICrud<tBoleta>
    {

       readonly BoletaDatos datos = new BoletaDatos();

        public bool eliminar(tBoleta e)
        {
            // e.estado = false;
            return datos.eliminar(e);
        }


        public bool guardarAsync(tBoleta e)
        {
            return datos.guardarAsync(e);
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

        public async Task<List<tBoleta>> obtenerTodo()
        {
            return await datos.obtenerTodo();
        }

        public tBoleta obtenerPorId(int caso)
        {
            return datos.obtenerPorId(caso);
        }
    }
}
