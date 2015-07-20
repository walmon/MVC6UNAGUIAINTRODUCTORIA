using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wm.website.ui.Models
{
    public class Item
    {
        [Required(ErrorMessage = "El identificador del ítem es obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del ítem es obligatorio")]
        [Display(Name = "Nombre de ítem")]
        [MaxLength(10, ErrorMessage = "El nombre del ítem no debe superar los 10 caracteres")]
        public string Nombre { get; set; }
    }


}
