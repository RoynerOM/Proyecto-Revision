using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using Datos;
using Utilidades;

namespace Negocios
{
    //Plantilla
    public class ContadorNegocio : ICrud<t_Persona>
    {
        DatosContador contador = new DatosContador();
        public bool eliminar(t_Persona e)
        {
            //e.Estado == false;
            return contador.eliminar(e);
        }

        public bool guardar(t_Persona e)
        {
            return contador.guardar(e);
        }

        public bool modificar(t_Persona e)
        {
            return contador.modificar(e);
        }

        public t_Persona obtenerPorId(t_Persona e)
        {
            return contador.obtenerPorId(e);
        }

        public IEnumerable<t_Persona> obtenerTodo(t_Persona e)
        {
            return contador.obtenerTodo(e);
        }

        //Metodos fuera de la interfaz
        public int CantidadContadores()
        {
            return contador.CantidadContadores();
        }


        public bool GuardarTrabajador(t_Trabajador e)
        {
            return contador.GuardarTrabajador(e);
        }

        public IEnumerable<t_Trabajador> obtenerTrabador(int tipo)
        {
            return contador.obtenerTrabador(tipo);
        }

        public t_Trabajador obtenerTrabador(string cedula)
        {
            return contador.obtenerTrabador(cedula);
        }
    }
}
