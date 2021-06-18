using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using Datos;
using Utilidades;

namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<t_Contador>
    {
        DatosContador contador = new DatosContador();
        public bool eliminar(t_Contador e)
        {
            //e.Estado == false;
            return contador.eliminar(e);
        }

        public bool guardar(t_Contador e)
        {
            return contador.guardar(e);
        }

        public bool modificar(t_Contador e)
        {
            return contador.modificar(e);
        }

        public t_Contador obtenerPorId(t_Contador e)
        {
            return contador.obtenerPorId(e);
        }

        public IEnumerable<t_Contador> obtenerTodo(t_Contador e)
        {
            return contador.obtenerTodo(e);
        }

        //Metodos fuera de la interfaz
        public int CantidadContadores()
        {
            return contador.CantidadContadores();
        }
    }
}
