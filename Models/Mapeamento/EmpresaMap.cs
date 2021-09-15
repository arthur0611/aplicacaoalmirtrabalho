using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using aplicacaoalmirtrabalho.Models.Dominio;
using Microsoft.EntityFrameworkCore;

namespace aplicacaoalmirtrabalho.Models.Mapeamento
{
    public class EmpresaMap : IEntityTypeConfiguration<empresa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<empresa> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(25).IsRequired();
          
            builder.ToTable("Empresas");
        }
    }
}
