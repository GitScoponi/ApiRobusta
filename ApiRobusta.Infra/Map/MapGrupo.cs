using ApiRobustaCurso.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Map
{
    class MapGrupo : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Nicho).IsRequired();

            //Foreikey
            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey("IdUsuario");
        }
    }
}
