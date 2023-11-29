using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;
using ProjetoIntegrador.Data.Mapeamento;

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
        }



        public DbSet<Socios> Socios { get; set; }
        public DbSet<Dependentes> Dependentes { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Faturas> Faturas { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Exames> Exames { get; set; }
        public DbSet<Participacao> Participacao { get; set; }

    }
}
