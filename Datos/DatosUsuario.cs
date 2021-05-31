using Entidades;
using Utilidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
