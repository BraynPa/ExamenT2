using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
       
        public int TypeId { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
       
        public string RutaImgPo { get; set; }
        // relaciones
        public Type Type { get; set; }

        public List<PokeUser> PokeUsers { get; set; }
    }
}
