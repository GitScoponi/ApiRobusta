using ApiRobustaCurso.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Map
{
    public class MapContato : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Nicho).IsRequired();

            //Foreikey
            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey("IdUsuario");
        }

    }
}
