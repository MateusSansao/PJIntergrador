using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;
using PJIntergrador.Data.Mapeamento;

namespace PJIntergrador.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SociosMapeamento());
            modelBuilder.ApplyConfiguration(new DependentesMapeamento());
            modelBuilder.ApplyConfiguration(new EventosMapeamento());
            modelBuilder.ApplyConfiguration(new FaturasMapeamento());
            modelBuilder.ApplyConfiguration(new ExamesMapeamento());
            modelBuilder.ApplyConfiguration(new ParticipacaoMapeamento());


        }



        public DbSet<Socios> Socios { get; set; }
        public DbSet<Dependentes> Dependentes { get; set; }
        public DbSet<Faturas> Faturas { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Exames> Exames { get; set; }
        public DbSet<Participacao> Participacao { get; set; }

    }
}
