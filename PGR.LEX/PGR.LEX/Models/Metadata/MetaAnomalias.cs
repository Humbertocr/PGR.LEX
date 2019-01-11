using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PGR.LEX.Models.Metadata
{
   
    public class MetaAnomalias
    {
        [Display(Name = "ID")]
        public int idAnomalia { get; set; }
        [Display(Name = "Descripción")]
        [Required]
        [MaxLength(150, ErrorMessage = "El espacio 'Descripción', no debe superar los 150 caracteres")]
        [MinLength(3, ErrorMessage = "El espacio 'Descripción', debe contener al menos 3 caracteres")]
        public string Descripcion { get; set; }
    }
}