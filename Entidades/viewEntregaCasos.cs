//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class viewEntregaCasos
    {
        public string Consecutivo { get; set; }
        public int Codigo { get; set; }
        public int Circuito { get; set; }
        public string Institucion { get; set; }
        public string Asignado { get; set; }
        public System.DateTime FechaAsignada { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public string Observacion { get; set; }
        public string Mensajero { get; set; }
        public int Cheque { get; set; }
        public Nullable<int> Transferencia { get; set; }
    }
}
