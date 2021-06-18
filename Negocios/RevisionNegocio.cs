using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using Datos;

namespace Negocios
{
    //Plantilla
    public class RevisionNegocio
    {
        DatosRevision datosR = new DatosRevision();
        public bool eliminar(t_Revision e)
        {
            throw new NotImplementedException();
        }

        public bool guardar(t_Revision e)
        {
            return datosR.guardar(e);
        }

        public bool modificar(t_Revision e)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<t_Revision> obtenerTodo(t_Revision e)
        {
            throw new NotImplementedException();
        }
    }
}
