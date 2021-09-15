using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aplicacaoalmirtrabalho.Models.Dominio;
using Microsoft.EntityFrameworkCore;

namespace aplicacaoalmirtrabalho.Models.Mapeamento
{
    public class VendaMap : IEntityTypeConfiguration<venda>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<venda> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.precototal).HasColumnType("float").IsRequired();
            builder.Property(p => p.cffc).HasMaxLength(25).IsRequired();
         
            builder.HasOne(p => p.usuarios).WithMany(p => p.venda).HasForeignKey(p => p.usuarioID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.jogo).WithMany(p => p.venda).HasForeignKey(p => p.jogosID).OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("Vendas");
        }
    }
}
