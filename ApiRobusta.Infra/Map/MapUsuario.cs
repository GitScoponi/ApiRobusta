using ApiRobustaCurso.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Map
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.PrimeiroNome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.UltimoNome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Senha).HasMaxLength(36).IsRequired();
            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }


    }
}
