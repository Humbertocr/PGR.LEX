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
    
    public partial class TBitacoraNotificaciones
    {
        public int Id_Excepcion { get; set; }
        public string Archivo_XML { get; set; }
        public string Archivo_Zip { get; set; }
        public string Expediente { get; set; }
        public System.DateTime Fecha_Excepcion { get; set; }
        public bool Procesado { get; set; }
        public string Resolucion { get; set; }
        public string Resultado { get; set; }
        public string Despacho_No_Registrado { get; set; }
        public string ConCopias_Chk { get; set; }
        public string Parte { get; set; }
    }
}