using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Negocios
{
    public class RecepcionNegocio : ICrud<tRecepcion>
    {
        readonly RecepcionDatos datos = new RecepcionDatos();
        public bool eliminar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardarAsync(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public tRecepcion obtenerPorId(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public async Task<List<tRecepcion>> obtenerTodo()
        {
            return await datos.obtenerTodo();
        }
    }
}
