using aplicacaoalmirtrabalho.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> optionals) : base(optionals) { }

        public DbSet<empresa> empresas { get; set; }
        public DbSet<jogos> jogos { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<venda> vendas { get; set; }


    }
}
