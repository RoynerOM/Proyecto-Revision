using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace Datos
{
    public class DatosContador : ICrud<t_Contador>
    {
        public bool eliminar(t_Contador e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Contador e)
        {
            throw new NotImplementedException();
        }

        public bool modificar(t_Contador e)
        {
            throw new NotImplementedException();
        }

        public t_Contador obtenerPorId(t_Contador e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<t_Contador> obtenerTodo(t_Contador e)
        {
            throw new NotImplementedException();
        }
    }
}
