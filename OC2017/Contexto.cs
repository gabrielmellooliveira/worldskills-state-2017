namespace OC2017
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using OC2017.Migrations;
    using OC2017.Model;
    
    public partial class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Configuration>());
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Perfil> Perfis { get; set; }
        public virtual DbSet<Funcionalidade> Funcionalidades { get; set; }
        public virtual DbSet<Idioma> Idiomas { get; set; }

        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Foto> Fotos { get; set; }
        public virtual DbSet<Convite> Convites { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Nome)
                .IsUnicode(false);
        }
    }
}
