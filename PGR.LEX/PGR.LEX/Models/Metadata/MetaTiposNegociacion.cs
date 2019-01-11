using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PGR.LEX.Models.Metadata
{
    public class MetaTiposNegociacion
    {
        [Display(Name = "ID")]
        public byte Tipo_Negociacion { get; set; }
       
        [Display(Name = "Descripción")]
        [Required]
        [MaxLength(50, ErrorMessage = "El espacio 'Descripción', no debe superar los 50 caracteres")]
        [MinLength(3, ErrorMessage = "El espacio 'Descripción', debe contener al menos 3 caracteres")]
        public string Nombre { get; set; }
    }
}