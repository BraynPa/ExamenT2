using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        public List<PokeUser> PokeUsers { get; set; }
    }
}
