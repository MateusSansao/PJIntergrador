using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Mapeamento
{
    public class UsuariosMapeamento : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");



            builder.HasKey(t => t.IDUsuario);



            builder.Property(t => t.NomeUsuario).HasColumnType("varchar(50)");
            builder.Property(t => t.Senha).HasColumnType("varchar(50)");
            builder.Property(t => t.FlagStatus).HasColumnType("bit");



        }
    }
}
