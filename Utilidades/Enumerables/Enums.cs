using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Enumerables
{
    public class Enums
    {
        public enum MedioReceptivo
        {
            Correo,
            Oficina,
            Mensajero,
            Whatsapp
        }

        public enum Estado
        {
            activo,
            inactivo
        }

        public enum Tipo
        {
            Contador = 0,
            Tramitador = 1
        }

        public enum TipoCedula
        {
            Nacional = 0,
            Dimex = 1
        }

    }
}
