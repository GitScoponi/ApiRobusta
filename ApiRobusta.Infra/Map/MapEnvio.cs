using ApiRobustaCurso.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Map
{
    public class MapEnvio : IEntityTypeConfiguration<Envio>
    {
        public void Configure(EntityTypeBuilder<Envio> builder)
        {
            builder.ToTable("Envio");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Enviado).IsRequired();
            

            //Foreikey
            builder.HasOne(x => x.Campanha).WithMany().HasForeignKey("IdCampanha");
            builder.HasOne(x => x.Grupo).WithMany().HasForeignKey("IdGrupo");
            builder.HasOne(x => x.Contato).WithMany().HasForeignKey("IdContato");
        }

      
    }
}
