using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aplicacaoalmirtrabalho.Models.Dominio;
using aplicacaoalmirtrabalho.Models.Mapeamento;

namespace aplicacaoalmirtrabalho.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<empresa> empresas { get; set; }
        public DbSet<jogos> jogos { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<venda> vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmpresaMap());
            builder.ApplyConfiguration(new JogosMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VendaMap());
        }

    }
}
