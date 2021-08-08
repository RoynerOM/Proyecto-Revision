using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Negocios
{
    public class EstadoNegocio : ICrud<tEstado>
    {
        readonly EstadoDatos datos = new EstadoDatos();
        public bool eliminar(tEstado e)
        {
            throw new NotImplementedException();
        }

        public bool guardarAsync(tEstado e)
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

        public async Task<List<tEstado>> obtenerTodo()
        {
            return await datos.obtenerTodo();
        }
    }
}
