using N00029793T2.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models
{
    public class N00029793T2Context : DbContext
    {
        //Esto se hace por cada tabla de base de datos
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<PokeUser> PokeUsers { get; set; }

        public N00029793T2Context(DbContextOptions<N00029793T2Context> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Esto se hace por cada tabla de base de datos
            modelBuilder.ApplyConfiguration(new PokemonMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TypeMap());
            modelBuilder.ApplyConfiguration(new PokeUserMap());
        }
    }
}
