using Datos;
using Entidades;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace Negocios
{
    //Plantilla
    public class RevisionNegocio : ICrud<tRevision>
    {
        DatosRevision datosR = new DatosRevision();
        public bool eliminar(tRevision e)
        {
            return datosR.eliminar(e);
        }

        public bool guardar(tRevision e)
        {
            return datosR.guardar(e);
        }

        public bool modificar(tRevision e)
        {
            return datosR.modificar(e);
        }



        public IEnumerable<tRevision> obtenerTodo(tRevision e)
        {
            return datosR.obtenerTodo(e);
        }

        //Extras

        public IEnumerable<tRevision> obtenerPorConsecutivo(string consecutivo)
        {
            return datosR.obtenerPorConsecutivo(consecutivo);
        }
        public tRevision ObtenerPorCaso(string consecutivo)
        {
            return datosR.ObtenerPorCaso(consecutivo);
        }
        public IEnumerable<tRevision> obtenerPorContador(string persona)
        {
            return datosR.obtenerPorContador(persona);
        }

        public tRevision obtenerPorId(tRevision e)
        {
            return datosR.obtenerPorId(e);
        }


        public IEnumerable<tRevision> FilterBy(int recepcion, int opc = 0)
        {
            return datosR.FilterBy(recepcion, opc);
        }

        public IEnumerable<tRevision> FilterBy(int estado)
        {
            return datosR.FilterBy(estado);
        }
    }
}
