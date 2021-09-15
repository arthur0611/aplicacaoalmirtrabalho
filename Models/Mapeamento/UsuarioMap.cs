using aplicacaoalmirtrabalho.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<usuario> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(25).IsRequired();
            builder.Property(p => p.idade).HasColumnType("int").IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(120).IsRequired();

            builder.ToTable("Usuario");
        }
    }
}
