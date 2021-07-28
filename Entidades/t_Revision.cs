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
    
    public partial class t_Revision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Revision()
        {
            this.t_Boleta = new HashSet<t_Boleta>();
            this.t_EntregaCasos = new HashSet<t_EntregaCasos>();
            this.t_Mensajeria = new HashSet<t_Mensajeria>();
        }
    
        public int Id_Caso { get; set; }
        public string Consecutivo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string FechaInsertada { get; set; }
        public string FechaRevisada { get; set; }
        public int Codigo { get; set; }
        public int Recepcion { get; set; }
        public string Tramitador { get; set; }
        public string Comentario { get; set; }
        public string Observacion { get; set; }
        public int Estado { get; set; }
        public Nullable<int> numeroActa { get; set; }
        public Nullable<int> numeroFolio { get; set; }
        public Nullable<System.DateTime> fechaActa { get; set; }
    
        public virtual Estado Estado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Boleta> t_Boleta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_EntregaCasos> t_EntregaCasos { get; set; }
        public virtual t_Institucion t_Institucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Mensajeria> t_Mensajeria { get; set; }
        public virtual t_Persona t_Persona { get; set; }
        public virtual t_Recepcion t_Recepcion { get; set; }
    }
}
