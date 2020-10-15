using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T2.Models.Maps
{
    public class PokeUserMap : IEntityTypeConfiguration<PokeUser>
    {
        public void Configure(EntityTypeBuilder<PokeUser> builder)
        {
            builder.ToTable("PokeUser");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.IdUser);
            builder.HasOne(o => o.Pokemon)
                .WithMany()
                .HasForeignKey(o => o.IdPokemon);
        }
    }
}
