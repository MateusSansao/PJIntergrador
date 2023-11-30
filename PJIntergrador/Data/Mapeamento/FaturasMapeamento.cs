using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Mapeamento
{
    public class FaturasMapeamento : IEntityTypeConfiguration<Faturas>
    {
        public void Configure(EntityTypeBuilder<Faturas> builder)
        {
            builder.ToTable("Faturas");



            builder.HasKey(t => t.IDFatura);



            builder.Property(t => t.MesAnoFatura).HasColumnType("varchar(7)");
            builder.Property(t => t.Valor).HasColumnType("decimal(10,2)");
            builder.Property(t => t.FlagPagamento).HasColumnType("bool");
            builder.Property(t => t.IDSocio).HasColumnType("int");


        }
    }
}
