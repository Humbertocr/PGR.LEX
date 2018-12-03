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
    
    public partial class TExpediente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TExpediente()
        {
            this.TAudienciasDetalleExpediente = new HashSet<TAudienciasDetalleExpediente>();
            this.TNegociacionesxExpediente = new HashSet<TNegociacionesxExpediente>();
            this.TPlanosxExpediente = new HashSet<TPlanosxExpediente>();
            this.TExpedientesAcumulados = new HashSet<TExpedientesAcumulados>();
            this.TInstitucionesxExpediente = new HashSet<TInstitucionesxExpediente>();
            this.TNotificacionesxExpediente = new HashSet<TNotificacionesxExpediente>();
            this.TTerrenosxExpediente = new HashSet<TTerrenosxExpediente>();
            this.TVotosxExpediente = new HashSet<TVotosxExpediente>();
        }
    
        public string NumExpediente { get; set; }
        public string Promovente { get; set; }
        public string Demandados { get; set; }
        public string Perjudicado { get; set; }
        public bool AgotamientoVia { get; set; }
        public int IdTipoExpediente { get; set; }
        public int idFormatoExpediente { get; set; }
        public Nullable<bool> Acumulado { get; set; }
        public System.DateTime fechaIngresoPGR { get; set; }
        public Nullable<int> InfPos_Consecutivo { get; set; }
        public Nullable<int> Inf_Pos_Mes { get; set; }
        public Nullable<int> Inf_Pos_Anio { get; set; }
        public string ProcuradorSugerido { get; set; }
        public Nullable<int> idDespacho { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAudienciasDetalleExpediente> TAudienciasDetalleExpediente { get; set; }
        public virtual TDespachosJudiciales TDespachosJudiciales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNegociacionesxExpediente> TNegociacionesxExpediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPlanosxExpediente> TPlanosxExpediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TExpedientesAcumulados> TExpedientesAcumulados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TInstitucionesxExpediente> TInstitucionesxExpediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNotificacionesxExpediente> TNotificacionesxExpediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTerrenosxExpediente> TTerrenosxExpediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVotosxExpediente> TVotosxExpediente { get; set; }
    }
}