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
    
    public partial class tBoleta
    {
        public int Id { get; set; }
        public int IdCaso { get; set; }
        public bool Motivo1 { get; set; }
        public bool Motivo2 { get; set; }
        public bool Motivo3 { get; set; }
        public bool Motivo4 { get; set; }
        public bool Motivo5 { get; set; }
        public bool Motivo6 { get; set; }
        public bool Motivo7 { get; set; }
        public string Motivo8 { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaCreado { get; set; }
    
        public virtual tRevision tRevision { get; set; }
    }
}
