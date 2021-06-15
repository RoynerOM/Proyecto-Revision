using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using Datos;
namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<t_Contador>
    {
        DatosContador contador = new DatosContador();
        public bool eliminar(t_Contador e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Contador e)
        {
            return contador.guardar(e);
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
