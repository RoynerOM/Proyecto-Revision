using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using Datos;

namespace Negocios
{
    //Plantilla
    public class RevisionNegocio : ICrud<t_Revision>
    {
        DatosRevision datosR = new DatosRevision();
        public bool eliminar(t_Revision e)
        {
            return datosR.eliminar(e);
        }

        public bool guardar(t_Revision e)
        {
            return datosR.guardar(e);
        }

        public bool modificar(t_Revision e)
        {
            return datosR.modificar(e);
        }



        public IEnumerable<t_Revision> obtenerTodo(t_Revision e)
        {
            return datosR.obtenerTodo(e);
        }

        //Extras
    
        public IEnumerable<t_Revision> obtenerPorConsecutivo(string consecutivo)
        {
            return datosR.obtenerPorConsecutivo(consecutivo);
        }

        public IEnumerable<t_Revision> obtenerPorContador(string persona)
        {
            return datosR.obtenerPorContador(persona);
        }

        public t_Revision obtenerPorId(t_Revision e)
        {
            return datosR.obtenerPorId(e);
        }
    }
}
