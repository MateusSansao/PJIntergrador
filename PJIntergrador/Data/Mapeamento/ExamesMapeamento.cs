using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Mapeamento
{
    public class ExamesMapeamento : IEntityTypeConfiguration<Exames>
    {
        public void Configure(EntityTypeBuilder<Exames> builder)
        {
            builder.ToTable("Exames");



            builder.HasKey(t => t.IDExame);



            builder.Property(t => t.TipoExame).HasColumnType("varchar(50)");
            builder.Property(t => t.DataExame).HasColumnType("date");
            builder.Property(t => t.IDSocio).HasColumnType("int");



        }
    }
}
