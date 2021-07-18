using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Utilidades.Interfaces;
namespace Negocios
{
    public class EntregaNegocio : ICrud<t_EntregaCasos>
    {
        EntregaDatos datos = new EntregaDatos();
        public bool eliminar(t_EntregaCasos e)
        {
            return datos.eliminar(e);
        }

        public bool guardar(t_EntregaCasos e)
        {
            return datos.guardar(e);
        }

        public bool modificar(t_EntregaCasos e)
        {
            return datos.modificar(e);
        }

        public t_EntregaCasos obtenerPorId(t_EntregaCasos e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<t_EntregaCasos> obtenerTodo(t_EntregaCasos e)
        {
            return datos.obtenerTodo(e);
        }

        //Funciones extras
        public t_EntregaCasos obtenerPorCaso(string consecutivo)
        {
            return datos.obtenerPorCaso(consecutivo);
        }
    }
}
