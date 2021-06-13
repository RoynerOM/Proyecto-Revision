using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosUsuario : ICrud<t_Usuario>
    {
        public bool eliminar(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public t_Usuario obtenerPorId(t_Usuario e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Usuario> obtenerTodo(t_Usuario e)
        {
            throw new NotImplementedException();
        }
    }
}
