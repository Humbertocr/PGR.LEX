//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PGR.LEX.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TDespachosJudiciales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TDespachosJudiciales()
        {
            this.TExpediente = new HashSet<TExpediente>();
        }
    
        public int idDespacho { get; set; }
        public int idCircuito { get; set; }
        public string CodigoDespachoPJ { get; set; }
        public string Descripcion { get; set; }
        public bool Electronico { get; set; }
        public bool EntregaInmediata { get; set; }
    
        public virtual TCircuitosJudiciales TCircuitosJudiciales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TExpediente> TExpediente { get; set; }
    }
}
