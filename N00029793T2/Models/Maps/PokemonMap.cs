using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models.Maps
{
    public class PokemonMap : IEntityTypeConfiguration<Pokemon>
    {

        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.ToTable("Pokemon");
            builder.HasKey(o => o.Id);


            builder.HasOne(o => o.Type)
                .WithMany()
                .HasForeignKey(o => o.TypeId);

            builder.HasMany(o => o.PokeUsers)
                .WithOne()
                .HasForeignKey(o => o.Id);


        }
    }
}
