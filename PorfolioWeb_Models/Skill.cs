using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_Models
{
    public  class Skill
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre de la skill es obligatorio")]
        [Display(Name ="Slikk nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nivel es obligatorio 1 a 10")]
        [Range(0,10)]
        [Display(Name ="Nivel de Skill")]
        public float Nivel { get; set; }
        [Display(Name ="Descripción")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage ="La imagen es obligatoria.")]
        [DataType(DataType.ImageUrl)]
        public string  UrlImagen { get; set; }
    }
}
