using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class ParticipacaoMapeamento : IEntityTypeConfiguration<Participacao>
    {
        public void Configure(EntityTypeBuilder<Participacao> builder)
        {
            builder.ToTable("Participacao");



            builder.HasKey(t => t.IDParticipacao);



            builder.Property(t => t.DataHoraConfirmacao).HasColumnType("datetime");
            builder.Property(t => t.IDEvento).HasColumnType("int");
            builder.Property(t => t.IDSocio).HasColumnType("int");



        }
    }
}
