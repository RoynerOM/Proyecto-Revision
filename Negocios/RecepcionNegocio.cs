using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Negocios
{
    public class RecepcionNegocio : ICrud<tRecepcion>
    {
        RecepcionDatos datos = new RecepcionDatos();
        public bool eliminar(tRecepcion e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(tRecepcion e)
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

        public IEnumerable<tRecepcion> obtenerTodo(tRecepcion e)
        {
            return datos.obtenerTodo(e);
        }
    }
}
