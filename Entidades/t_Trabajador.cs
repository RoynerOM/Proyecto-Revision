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
    
    public partial class t_Trabajador
    {
        public string Cedula { get; set; }
        public Nullable<int> Tipo { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual t_Persona t_Persona { get; set; }
    }
}
