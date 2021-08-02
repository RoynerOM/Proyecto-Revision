using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;
namespace Negocios
{
    public class EntregaNegocio : ICrud<tEntregaCasos>
    {
        EntregaDatos datos = new EntregaDatos();
        public bool eliminar(tEntregaCasos e)
        {
            return datos.eliminar(e);
        }

        public bool guardar(tEntregaCasos e)
        {
            return datos.guardar(e);
        }

        public bool modificar(tEntregaCasos e)
        {
            return datos.modificar(e);
        }

        public tEntregaCasos obtenerPorId(tEntregaCasos e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<tEntregaCasos> obtenerTodo(tEntregaCasos e)
        {
            return datos.obtenerTodo(e);
        }

        //Funciones extras
        public tEntregaCasos obtenerPorCaso(string consecutivo)
        {
            return datos.obtenerPorCaso(consecutivo);
        }
    }
}
