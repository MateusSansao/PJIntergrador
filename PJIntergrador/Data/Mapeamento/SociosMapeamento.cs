using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PJIntergrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class SociosMapeamento : IEntityTypeConfiguration<Socios>
    {
        public void Configure(EntityTypeBuilder<Socios> builder)
        {
            builder.ToTable("Socios");



            builder.HasKey(t => t.IDSocio);



            builder.Property(t => t.NomeCompleto).HasColumnType("varchar(100)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(20)");
            builder.Property(t => t.DataNascimento).HasColumnType("date");
            builder.Property(t => t.Endereco).HasColumnType("varchar(100)");
            builder.Property(t => t.Telefone).HasColumnType("varchar(20)");
            builder.Property(t => t.Email).HasColumnType("varchar(100)");
            builder.Property(t => t.DataAdesao).HasColumnType("date");
            builder.Property(t => t.FlagTitular).HasColumnType("bit");
            builder.Property(t => t.IDUsuario).HasColumnType("int");



        }
    }
}
