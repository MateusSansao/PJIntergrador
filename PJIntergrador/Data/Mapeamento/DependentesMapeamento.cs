using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Mapeamento
{

    public class DependentesMapeamento : IEntityTypeConfiguration<Dependentes>
    {
        public void Configure(EntityTypeBuilder<Dependentes> builder)
        {
            builder.ToTable("Dependentes");



            builder.HasKey(t => t.IDDepente);



            builder.Property(t => t.NomeCompleto).HasColumnType("varchar(100)");
            builder.Property(t => t.DataNascimento).HasColumnType("date");
            builder.Property(t => t.Parentesco).HasColumnType("varchar(50)");
            builder.Property(t => t.IDSocio).HasColumnType("int");
            builder.Property(t => t.IDUsuario).HasColumnType("int");



        }
    }
}
