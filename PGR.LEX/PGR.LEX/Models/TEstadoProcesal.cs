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
    
    public partial class TEstadoProcesal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEstadoProcesal()
        {
            this.TEstadosxExpediente = new HashSet<TEstadosxExpediente>();
        }
    
        public int idEstadoProcesal { get; set; }
        public string Descripcion { get; set; }
        public string Area_Corresponde { get; set; }
        public string Tipo_Expediente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEstadosxExpediente> TEstadosxExpediente { get; set; }
    }
}
