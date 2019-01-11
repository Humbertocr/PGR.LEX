using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PGR.LEX.Models.Metadata
{
    public class MetaTipo
    {
        [Display(Name = "ID")]

        public int idTipo { get; set; }

        [Display(Name = "Materia")]
        public int MatIdMateria { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        [MaxLength(50, ErrorMessage = "El espacio 'Descripción', no debe superar los 50 caracteres")]
        [MinLength(3, ErrorMessage = "El espacio 'Descripción', debe contener al menos 3 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Materia")]
        public virtual TMateria TMateria { get; set; }

    }
}