using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aplicacaoalmirtrabalho.Models.Dominio;
using Microsoft.EntityFrameworkCore;

namespace aplicacaoalmirtrabalho.Models.Mapeamento
{
    public class JogosMap : IEntityTypeConfiguration<jogos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<jogos> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Categoria).HasMaxLength(25).IsRequired();
            builder.Property(p => p.preco).HasColumnType("float").IsRequired();
            builder.Property(p => p.quantidade).HasColumnType("int").IsRequired();

            builder.HasOne(p => p.empresas).WithMany(p => p.jogos).HasForeignKey(p => p.empresaID).OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("Jogos");
        }
    }
}
