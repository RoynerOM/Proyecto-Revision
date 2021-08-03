namespace Utilidades.Enumerables
{
    public class Enums
    {
        public enum MedioReceptivo
        {
            Correo = 1,
            Whatsapp = 2,
            Oficina = 3,
            Mensajero = 4,

        }

        public enum Recep
        {
            Oficina = 3,
            Mensajero = 4,
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
        public enum Rol
        {
            Administrador = 0,
            Normal = 1
        }
        public enum TipoCedula
        {
            Nacional = 0,
            Dimex = 1
        }

        public enum TipoEstado
        {
            PENDIENTE = 2,
            TRAMITADO = 3,
            ENTREGADO = 4,
            TODOS = 5
        }

        public enum TipoEscuela
        {
            ESCUELA = 1,
            COLEGIO = 2
        }
    }
}
