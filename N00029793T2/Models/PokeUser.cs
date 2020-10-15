using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models
{
    public class PokeUser
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdPokemon { get; set; }
        public DateTime FechaCaptura { get; set; }

        // relaciones
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }
    }
}
