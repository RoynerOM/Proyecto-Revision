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
    
    public partial class tInstitucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tInstitucion()
        {
            this.tEntregaCasos = new HashSet<tEntregaCasos>();
            this.tRevision = new HashSet<tRevision>();
        }
    
        public int Codigo { get; set; }
        public int Circuito { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public string CedulaJuridica { get; set; }
        public string CuentaLey { get; set; }
        public string Contador { get; set; }
        public string Responsable { get; set; }
        public string Contacto { get; set; }
        public bool Estado { get; set; }
        public int CodigoAux { get; set; }
        public string DiaRuta { get; set; }
        public string TipoCuenta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tEntregaCasos> tEntregaCasos { get; set; }
        public virtual tPersona tPersona { get; set; }
        public virtual tTipoInstitucion tTipoInstitucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tRevision> tRevision { get; set; }
    }
}
