using ApiRobusta.Infra.Map;
using ApiRobustaCurso.Entities;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Repositories
{
    public partial class ApiRobustaContext : DbContext

    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<Envio> Envio { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Contato> Contato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=VINICIUS\SQLEXPRESS; Initial Catalog=ApiRobusta; User Id=Scoponi; Password=Pi314159265;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new MapUsuario());
            modelBuilder.ApplyConfiguration(new MapContato());
            modelBuilder.ApplyConfiguration(new MapCampanha());
            modelBuilder.ApplyConfiguration(new MapGrupo());
            modelBuilder.ApplyConfiguration(new MapEnvio());
        }
    }
}
