using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Negocios
{
    public class EstadoNegocio : ICrud<Estado>
    {
        EstadoDatos datos = new EstadoDatos();
        public bool eliminar(Estado e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(Estado e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(Estado e)
        {
            throw new NotImplementedException();
        }

        public Estado obtenerPorId(Estado e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<Estado> obtenerTodo(Estado e)
        {
            return datos.obtenerTodo(new Estado());
        }
    }
}
