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
    
    public partial class TExpedientesAcumulados
    {
        public string ExpedientePrincipal { get; set; }
        public string ExpedienteHijo { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual TExpediente TExpediente { get; set; }
    }
}