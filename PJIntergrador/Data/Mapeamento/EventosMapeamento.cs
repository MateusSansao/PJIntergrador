using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Mapeamento
{
    public class EventosMapeamento : IEntityTypeConfiguration<Eventos>
    {
        public void Configure(EntityTypeBuilder<Eventos> builder)
        {
            builder.ToTable("Eventos");



            builder.HasKey(t => t.IDEvento);



            builder.Property(t => t.NomeEvento).HasColumnType("varchar(100)");
            builder.Property(t => t.DataEvento).HasColumnType("date");
            builder.Property(t => t.DescricaoEvento).HasColumnType("varchar(500)");
            builder.Property(t => t.Participante).HasColumnType("bit");
            builder.Property(t => t.CapacidadeMaxima).HasColumnType("int");



        }
    }
}
