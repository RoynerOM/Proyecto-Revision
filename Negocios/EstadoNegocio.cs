using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Negocios
{
    public class EstadoNegocio : ICrud<tEstado>
    {
        EstadoDatos datos = new EstadoDatos();
        public bool eliminar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public tEstado obtenerPorId(tEstado e)
        {
            return datos.obtenerPorId(e);
        }

        public IEnumerable<tEstado> obtenerTodo(tEstado e)
        {
            return datos.obtenerTodo(new tEstado());
        }
    }
}
