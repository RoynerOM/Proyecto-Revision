//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensajeria
    {
        public int Id { get; set; }
        public Nullable<int> id_caso { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Mensajero { get; set; }
    
        public virtual t_Persona t_Persona { get; set; }
        public virtual t_Revision t_Revision { get; set; }
    }
}
